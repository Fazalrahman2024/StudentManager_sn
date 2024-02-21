using FAZALDBFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManager.Utilities.Lists
{
    public class ListData
    {
        // this is for dataGridView 
        public static void LoadDataIntoDataGridView(DataGridView dgv, string storedProceName)
        {
            DbSQLServer db = new DbSQLServer(AppSetting.ConnectionString());
            dgv.DataSource = db.GetDataList(storedProceName);

            dgv.MultiSelect = false;
            dgv.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.Fill;
            dgv.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
        }

        // end here dataGridview


        public static void LoadDataIntoComboBox(ComboBox cb, DbParameter parameter) 
        
        {
            DbSQLServer db = new DbSQLServer(AppSetting.ConnectionString());
            cb.DataSource = db.GetDataList("usp_ListTypesDataGetDateByListTypeId", parameter);
            cb.DisplayMember = "Description";
            cb.ValueMember = "Id";

            cb.SelectedIndex = -1;
            cb.DropDownStyle = ComboBoxStyle.DropDownList;  

        }
    }
}
