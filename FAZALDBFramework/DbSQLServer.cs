using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FAZALDBFramework
{ 
    // this class contain only for Database 
    public class DbSQLServer
    {

        // Describe about the  Database procedure
        //1: ExecuteReader: this will return one row or more than one row
        //2: ExecuteScalar: this will return only one value any one
        //3: ExecuteNoQuery: this will produce functionality about INSERT, DELETE, UPADATE

        // Generalize connection string 

        private string _connstring;   

        /// <summary>
        ///  this constructor for getting connstring
        /// </summary>
        /// <param name="connstring"></param>
        public DbSQLServer(string connstring) 
        {
            _connstring = connstring;   


        }
        // ExecuteReader function here
        public DataTable GetDataList(string storedProceName)
        {
            DataTable dtData=new DataTable();

            // connection name 

            using ( SqlConnection conn = new SqlConnection(_connstring))
            {
                using(SqlCommand cmd= new SqlCommand(storedProceName, conn))
                {
                    cmd.CommandType=CommandType.StoredProcedure;

                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();
                    
                    dtData.Load(reader);
                }
            }

            return dtData;
        }

        public DataTable GetDataList(string storedProceName, DbParameter parameter)
        {
            DataTable dtData = new DataTable();

            // connection name 

            using (SqlConnection conn = new SqlConnection(_connstring))
            {
                using (SqlCommand cmd = new SqlCommand(storedProceName, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();

                    cmd.Parameters.AddWithValue(parameter.Parameter, parameter.Value);

                    SqlDataReader reader = cmd.ExecuteReader();

                    dtData.Load(reader);
                }
            }

            return dtData;
        }
        // for multiple parameters
        public DataTable GetDataList(string storedProceName, DbParameter[] parameters)
        {
            DataTable dtData = new DataTable();

            // connection name 

            using (SqlConnection conn = new SqlConnection(_connstring))
            {
                using (SqlCommand cmd = new SqlCommand(storedProceName, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    foreach (var para in parameters)
                    {
                    cmd.Parameters.AddWithValue(para.Parameter, para.Value);

                    }

                    SqlDataReader reader = cmd.ExecuteReader();

                    dtData.Load(reader);
                }
            }

            return dtData;
        }

        // ExecuteScalar function here 
        public object GetScalarValue(string storedProceName)
        {
            object value=null;

            using (SqlConnection conn= new SqlConnection(_connstring))
            {
                using (SqlCommand cmd = new SqlCommand(storedProceName, conn)) 
                { 
                cmd.CommandType= System.Data.CommandType.StoredProcedure;

                    conn.Open();

                    value = cmd.ExecuteScalar();
                
                }
            }

            return value;   
        }

        // for one parameter suppler
        public object GetScalarValue(string storedProceName,DbParameter parameter)
        {
            object value = null;

            using (SqlConnection conn = new SqlConnection(_connstring))
            {
                using (SqlCommand cmd = new SqlCommand(storedProceName, conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    conn.Open();
                    cmd.Parameters.AddWithValue(parameter.Parameter, parameter.Value);

                    value = cmd.ExecuteScalar();

                }
            }

            return value;
        }

        // for Multiple  parameters suppler
        public object GetScalarValue(string storedProceName, DbParameter[] parameters)
        {
            object value = null;

            using (SqlConnection conn = new SqlConnection(_connstring))
            {
                using (SqlCommand cmd = new SqlCommand(storedProceName, conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    conn.Open();

                    // foreach loop because more then one parameter is here

                    foreach (var para in parameters)
                    {

                     cmd.Parameters.AddWithValue(para.Parameter, para.Value);
                   
                    }
                    value = cmd.ExecuteScalar();
                    
                }
            }

            return value;
        }

        //3: ExecuteNoQuery Function

        public void SaveOrUpdateRecord(string storedProceName, object obj)

        {
            // yeh connection string hai jo ky constructor ma load kar rahy hai
            using (SqlConnection conn = new SqlConnection(_connstring))
            {
                // q ky hum storeprocedure use kar rahy hai iss leye command line dena pary ga

                using (SqlCommand command = new SqlCommand(storedProceName, conn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    conn.Open();

                    // parameters

                    Type type= obj.GetType(); // type aik property hai
                                              
                    BindingFlags flags=BindingFlags.Instance | BindingFlags.Public; // BindingFlags aik property hai 

                    PropertyInfo[] properties= type.GetProperties(flags); // PropertyInfo aik array type hai

                    // foreach loops for array

                    foreach (var property in properties)
                    {
                        command.Parameters.AddWithValue("@" + property.Name, property.GetValue(obj, null));

                    }

                    command.ExecuteNonQuery();
                }

            }

         }
            

        //usp_BranchesUpdateBranchDetails
        //usp_BranchesAddNewBranch

    }
}
