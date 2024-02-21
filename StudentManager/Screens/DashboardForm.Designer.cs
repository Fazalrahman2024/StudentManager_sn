namespace StudentManager.Screens
{
    partial class DashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutStudentManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.NewStudentToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ManageBranchesToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.EditProfileToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ManageUsersToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ManageReportsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.SystemSetupToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.HelpAndSupportToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.DashboardDataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DashboardDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolStripMenuItem1,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1303, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(27, 24);
            this.toolStripMenuItem1.Text = "|";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutStudentManagerToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutStudentManagerToolStripMenuItem
            // 
            this.aboutStudentManagerToolStripMenuItem.Name = "aboutStudentManagerToolStripMenuItem";
            this.aboutStudentManagerToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.aboutStudentManagerToolStripMenuItem.Text = "About Student Manager";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewStudentToolStripButton,
            this.toolStripSeparator1,
            this.ManageBranchesToolStripButton,
            this.toolStripSeparator2,
            this.EditProfileToolStripButton,
            this.toolStripSeparator3,
            this.ManageUsersToolStripButton,
            this.toolStripSeparator4,
            this.ManageReportsToolStripButton,
            this.toolStripSeparator5,
            this.SystemSetupToolStripButton,
            this.toolStripSeparator6,
            this.HelpAndSupportToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1303, 47);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // NewStudentToolStripButton
            // 
            this.NewStudentToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("NewStudentToolStripButton.Image")));
            this.NewStudentToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewStudentToolStripButton.Name = "NewStudentToolStripButton";
            this.NewStudentToolStripButton.Size = new System.Drawing.Size(98, 44);
            this.NewStudentToolStripButton.Text = "New Student";
            this.NewStudentToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 47);
            // 
            // ManageBranchesToolStripButton
            // 
            this.ManageBranchesToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ManageBranchesToolStripButton.Image")));
            this.ManageBranchesToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ManageBranchesToolStripButton.Name = "ManageBranchesToolStripButton";
            this.ManageBranchesToolStripButton.Size = new System.Drawing.Size(130, 44);
            this.ManageBranchesToolStripButton.Text = "Manage Branches";
            this.ManageBranchesToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ManageBranchesToolStripButton.Click += new System.EventHandler(this.ManageBranchesToolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 47);
            // 
            // EditProfileToolStripButton
            // 
            this.EditProfileToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("EditProfileToolStripButton.Image")));
            this.EditProfileToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditProfileToolStripButton.Name = "EditProfileToolStripButton";
            this.EditProfileToolStripButton.Size = new System.Drawing.Size(86, 44);
            this.EditProfileToolStripButton.Text = "Edit Profile";
            this.EditProfileToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 47);
            // 
            // ManageUsersToolStripButton
            // 
            this.ManageUsersToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ManageUsersToolStripButton.Image")));
            this.ManageUsersToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ManageUsersToolStripButton.Name = "ManageUsersToolStripButton";
            this.ManageUsersToolStripButton.Size = new System.Drawing.Size(106, 44);
            this.ManageUsersToolStripButton.Text = "Manage Users";
            this.ManageUsersToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 47);
            // 
            // ManageReportsToolStripButton
            // 
            this.ManageReportsToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ManageReportsToolStripButton.Image")));
            this.ManageReportsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ManageReportsToolStripButton.Name = "ManageReportsToolStripButton";
            this.ManageReportsToolStripButton.Size = new System.Drawing.Size(122, 44);
            this.ManageReportsToolStripButton.Text = "Manage Reports";
            this.ManageReportsToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 47);
            // 
            // SystemSetupToolStripButton
            // 
            this.SystemSetupToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("SystemSetupToolStripButton.Image")));
            this.SystemSetupToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SystemSetupToolStripButton.Name = "SystemSetupToolStripButton";
            this.SystemSetupToolStripButton.Size = new System.Drawing.Size(102, 44);
            this.SystemSetupToolStripButton.Text = "System Setup";
            this.SystemSetupToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 47);
            // 
            // HelpAndSupportToolStripButton
            // 
            this.HelpAndSupportToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("HelpAndSupportToolStripButton.Image")));
            this.HelpAndSupportToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HelpAndSupportToolStripButton.Name = "HelpAndSupportToolStripButton";
            this.HelpAndSupportToolStripButton.Size = new System.Drawing.Size(140, 44);
            this.HelpAndSupportToolStripButton.Text = "Help and Suppport";
            this.HelpAndSupportToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // DashboardDataGridView
            // 
            this.DashboardDataGridView.AllowUserToAddRows = false;
            this.DashboardDataGridView.AllowUserToDeleteRows = false;
            this.DashboardDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DashboardDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DashboardDataGridView.Location = new System.Drawing.Point(12, 95);
            this.DashboardDataGridView.Name = "DashboardDataGridView";
            this.DashboardDataGridView.ReadOnly = true;
            this.DashboardDataGridView.RowHeadersWidth = 51;
            this.DashboardDataGridView.RowTemplate.Height = 24;
            this.DashboardDataGridView.Size = new System.Drawing.Size(1279, 498);
            this.DashboardDataGridView.TabIndex = 2;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 605);
            this.Controls.Add(this.DashboardDataGridView);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.Name = "DashboardForm";
            this.ShowInTaskbar = true;
            this.Text = "DashboardForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DashboardDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutStudentManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton NewStudentToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ManageBranchesToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton EditProfileToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton ManageUsersToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton ManageReportsToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton SystemSetupToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton HelpAndSupportToolStripButton;
        private System.Windows.Forms.DataGridView DashboardDataGridView;
    }
}