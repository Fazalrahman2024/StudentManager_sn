using StudentManager.Screens.Template;
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
    public partial class ManageBranchesForm : TemplateForm

    {
        public ManageBranchesForm()
        {
            InitializeComponent();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addNewBranchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowBranchInfoScreen(0, false);
        }

        private void ShowBranchInfoScreen(int branchId, bool isUpdate)
        {
            BranchInfoForm bif = new BranchInfoForm();
            bif.BranchId = branchId;
            bif.IsUpdate = isUpdate;
             
             bif.ShowDialog();

            LoadDataIntoDataGridView();
        }

        private void ManageBranchesForm_Load(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();
        }

        private void LoadDataIntoDataGridView()
        {
            ListData.LoadDataIntoDataGridView(BranchesDataGridView, "usp_BranchesGetAllBranches");
        }

        private void BranchesDataGridView_DoubleClick(object sender, EventArgs e)
        {
            // jab form ky data par click kary tu data dosry form ma show ho

            int rowIndex = BranchesDataGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);// variable #rowIndex ma select row ka index save ho jaye ga
            int branchId= Convert.ToInt32(BranchesDataGridView.Rows[rowIndex].Cells["BranchId"].Value);// find branch id here

            ShowBranchInfoScreen(branchId, true);

        }
    }
}
