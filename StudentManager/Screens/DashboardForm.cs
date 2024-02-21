using StudentManager.Screens.Branches;
using StudentManager.Screens.Template;
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
    public partial class DashboardForm : TemplateForm
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ManageBranchesToolStripButton_Click(object sender, EventArgs e)
        {
            ManageBranchesForm manageBranchesForm = new ManageBranchesForm();
            manageBranchesForm.ShowDialog();
        }
    }
}
