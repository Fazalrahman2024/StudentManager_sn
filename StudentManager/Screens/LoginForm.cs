using FAZALDBFramework;
using FAZALDBFramework.Windows;
using StudentManager.Models.Users;
using StudentManager.Screens.Template;
using StudentManager.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManager.Screens
{
    public partial class LoginForm : TemplateForm

    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {


              //check the validatation of the password and user name 
            if (IsFormValid())
            {
                // DBSever connectionstring object

                DbSQLServer db = new DbSQLServer(AppSetting.ConnectionString());

                // Check in database to correct the user name and password
                bool isLoginDetailsCorrect = Convert.ToBoolean(db.GetScalarValue("usp_UsersCheckLoginDetails", GetParameters()));

                if (isLoginDetailsCorrect)
                {
                    // jab user login hoga tu aus ka data show hoga
                    GetLoggInUserSettings();


                    this.Hide();// to hide login page when button signin press

                    // to show dashboardform after clicking singin button
                    DashboardForm df= new DashboardForm();
                    df.Show();

                }
                else
                {
                    FAZALMessageBox.ShowErrorMessage("Username and password is not correct");
                 //   MessageBox.Show("Username and password is not correct", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void GetLoggInUserSettings()
        {
            LoggedInUser.UserName= userNametext.Text;

        }

        // paramenters more then one accepting 
        private DbParameter[] GetParameters()
        {
           List<DbParameter> parameters = new List<DbParameter>();
            
            // for username 
            DbParameter dbparam1=new DbParameter();
            dbparam1.Parameter = "@UserName";
            dbparam1.Value = userNametext.Text;
            parameters.Add(dbparam1);

            // for password
            DbParameter dbparam2 = new DbParameter();
            dbparam2.Parameter = "@Password";
            dbparam2.Value = PasswordText.Text;

            parameters.Add(dbparam2);
            return parameters.ToArray();
        }

        private bool IsFormValid()
        {
            // check if username 

            if (userNametext.Text.Trim() == string.Empty)
            {
                FAZALMessageBox.ShowErrorMessage("User Name is required");
                //MessageBox.Show("User Name is required","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                userNametext.Clear();   
                userNametext.Focus();
                return false;
            }

            // check if password empty

            if (PasswordText.Text.Trim() == string.Empty)
            {
                FAZALMessageBox.ShowErrorMessage("Password is required");
                //MessageBox.Show("Password is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PasswordText.Clear();
                PasswordText.Focus();
                return false;
            }
            return true;
        }
    }
}
