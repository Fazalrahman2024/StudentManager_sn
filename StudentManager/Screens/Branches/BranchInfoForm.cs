using FAZALDBFramework;
using FAZALDBFramework.Windows;
using StudentManager.Models.Branches;
using StudentManager.Models.Users;
using StudentManager.Screens.Template;
using StudentManager.Utilities;
using StudentManager.Utilities.Lists;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManager.Screens.Branches
{
    public partial class BranchInfoForm : TemplateForm
    {
        public BranchInfoForm()
        {
            InitializeComponent();
        }
        public int BranchId { get; set; }

        private void BranchNametextBox_TextChanged(object sender, EventArgs e)
        {
            // yaha par yeh lable ko text assign kar rha hai textbox sy
            HeadLabelText.Text=BranchNametextBox.Text;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LogoPictureBox_Click(object sender, EventArgs e)
        {
            // jab hum is pic box par click kary gy tu...

            OpenFileDialog opn= new OpenFileDialog();
            opn.Title = "Select Logo";
            opn.Filter = "Logo file (*.jpg;*.bmp;*.gif)|*.jpg;*.bmp;*.gif";

            //// for pic ko selection ky bad show karny aur cancel karny ky lye
            if (opn.ShowDialog() == DialogResult.OK) {

                LogoPictureBox.Image = new Bitmap(opn.FileName);             
            }
        }

        private void BranchInfoForm_Load(object sender, EventArgs e)
        {
            // this for combo box data load
            LoadDataIntoComboBoxes();

            // yeh method form ma data load kary ga form ky under aur show kary ga
            LoadDataAndBindToControlIfUpdate();
        }

        private void LoadDataIntoComboBoxes()
        {
            ListData.LoadDataIntoComboBox(CityNamecomboBox, new DbParameter { Parameter = "@ListTypeId", Value =ListTypes.City }) ;
            ListData.LoadDataIntoComboBox(DistrictNameComboBox, new DbParameter { Parameter = "@ListTypeId", Value = ListTypes.District });
        }

        private void LoadDataAndBindToControlIfUpdate()
        {
            if (this.IsUpdate) 
            {
                // database connection dekhna hai

                DbSQLServer db = new DbSQLServer(AppSetting.ConnectionString());

                // ab hum ny parameter store karna hai
                             
                // ab is ko use krty howe hum Data Table ma show karty hai
                DataTable dtBranch = db.GetDataList("usp_BranchesGetBrancheDetailByBranchId",new DbParameter { Parameter="@BranchId",Value=this.BranchId});

                // ab hum is ko dataRow ma convert karty hai 
                DataRow row = dtBranch.Rows[0];

                // ab is ko dalty hai apny controls ma like name filed to BranchName
                BranchNametextBox.Text = row["BranchName"].ToString(); // note branch name should be same as database name

                // ab sary fields ky leye kar lety hai 

                EmailAddresstextBox.Text= row["email"].ToString();

                TelephonetextBox.Text= row["Telephone"].ToString();
                WebsiteAddresstextBox.Text = row["website"].ToString();
                AddressLinetextBox.Text = row["AddressLine"].ToString();

                // for combo box
                CityNamecomboBox.SelectedValue = row["CityId"];
                DistrictNameComboBox.SelectedValue = row["DistrictId"];
                PostCodeTextBox.Text = row["PostCode"].ToString();

                // for Image MemoryStream to convert kary gy image ma here aur show kary ga
                // agar (row["branchImage"] is DBNull) ? null yeh null hai to show error nahi hoga
                LogoPictureBox.Image = (row["branchImage"] is DBNull) ? null: ImageManipulations.PutPhoto((byte[])row["branchImage"]);


            }

        }// end here

        private void saveRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Form Validation here
            if(IsFormValidated())// branchid, BranchName,BranchEmail should not be empty
            { 

            // after validation pass go for save and update record process

            if (this.IsUpdate)
            {
                UpdateRecord();
                    FAZALMessageBox.ShowSuccessMessage("Record is update successfully");
               // MessageBox.Show("Record is update successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                SaveRecord();
                    FAZALMessageBox.ShowSuccessMessage("Record is add successfully");
                    // MessageBox.Show("Record is add successfully", "Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

            }
            this.Close();
        }

        private void SaveRecord() 
        {
            DbSQLServer db = new DbSQLServer(AppSetting.ConnectionString());
            db.SaveOrUpdateRecord("usp_BranchesAddNewBranch",GetObject());

                
        }

        private Branch GetObject()
        {
            Branch branch=new Branch();
            branch.BranchId = (this.IsUpdate) ? this.BranchId : 0; //agar yeh update ka process hai tu BranchId zero hony chahye
            branch.BranchName=BranchNametextBox.Text;
            branch.Email = EmailAddresstextBox.Text;
            branch.Telephone=TelephonetextBox.Text;
            branch.AddressLine=AddressLinetextBox.Text;
            branch.Website = WebsiteAddresstextBox.Text;
            branch.CityId=Convert.ToInt32(CityNamecomboBox.SelectedValue);
            branch.DistrictId = Convert.ToInt32(DistrictNameComboBox.SelectedValue);
            branch.PostCode = PostCodeTextBox.Text;
            // agar image nahe hai tu yeh phir bhi save hoga record.
            branch.BranchImage = (LogoPictureBox.Image==null)? null:ImageManipulations.GetPhoto(LogoPictureBox);
            branch.CreatedBy = LoggedInUser.UserName;// user name send kar rahy hai 
            
            return branch;
        }

        private void UpdateRecord()
        {
            DbSQLServer db = new DbSQLServer(AppSetting.ConnectionString());
            db.SaveOrUpdateRecord("usp_BranchesUpdateBranchDetails", GetObject());

        }

        private bool IsFormValidated()
        {
            // for Branch Name field
            if (BranchNametextBox.Text.Trim() == string.Empty) 
            {
                FAZALMessageBox.ShowErrorMessage("Branch Name is required");

                //MessageBox.Show("Branch Name is required ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BranchNametextBox.Focus();// focus ausy field py hoga
                return false;
            }

            // for Branch Email field
            if (EmailAddresstextBox.Text.Trim() == string.Empty)
            {
                FAZALMessageBox.ShowErrorMessage("Email is required");
               // MessageBox.Show("Email is required ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EmailAddresstextBox.Focus();// focus ausy field py hoga
                return false;
            }

            // for Branch Telephone field
            if (TelephonetextBox.Text.Trim() == string.Empty)
            {
                FAZALMessageBox.ShowErrorMessage("Telephone is required");
                //MessageBox.Show("Email is required ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TelephonetextBox.Focus();// focus ausy field py hoga
                return false;
            }
            return true;    
        }
    }
}
