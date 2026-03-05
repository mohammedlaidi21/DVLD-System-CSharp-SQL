namespace DVLD_PresentationLayer_PL_.Applications
{
    partial class LocalDrivingLicenseApplications
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.dgvLocalDrivingLicenseApp = new System.Windows.Forms.DataGridView();
            this.cmsApplications = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tmsiShowApplicationDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tmsiEditApp = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiDeleteApp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tmsiCancelApp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tmsiTests = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiVisionTest = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiWrittenTest = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiStreetTest = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiIssueDrivingLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tmsiShowLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tmsiShowPersonLicenseHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCountLDLApp = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalDrivingLicenseApp)).BeginInit();
            this.cmsApplications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(424, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(798, 65);
            this.label1.TabIndex = 1;
            this.label1.Text = "Local Driving License Applications";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Filter by: ";
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "None",
            "L.D.L.AppID",
            "National No",
            "Full Name",
            "Status"});
            this.cbFilterBy.Location = new System.Drawing.Point(136, 295);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(206, 37);
            this.cbFilterBy.TabIndex = 3;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // dgvLocalDrivingLicenseApp
            // 
            this.dgvLocalDrivingLicenseApp.AllowUserToAddRows = false;
            this.dgvLocalDrivingLicenseApp.AllowUserToDeleteRows = false;
            this.dgvLocalDrivingLicenseApp.AllowUserToOrderColumns = true;
            this.dgvLocalDrivingLicenseApp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocalDrivingLicenseApp.ContextMenuStrip = this.cmsApplications;
            this.dgvLocalDrivingLicenseApp.Location = new System.Drawing.Point(35, 347);
            this.dgvLocalDrivingLicenseApp.Name = "dgvLocalDrivingLicenseApp";
            this.dgvLocalDrivingLicenseApp.ReadOnly = true;
            this.dgvLocalDrivingLicenseApp.RowHeadersWidth = 62;
            this.dgvLocalDrivingLicenseApp.RowTemplate.Height = 28;
            this.dgvLocalDrivingLicenseApp.Size = new System.Drawing.Size(1200, 277);
            this.dgvLocalDrivingLicenseApp.TabIndex = 5;
            // 
            // cmsApplications
            // 
            this.cmsApplications.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmsApplications.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.cmsApplications.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmsiShowApplicationDetails,
            this.toolStripSeparator1,
            this.tmsiEditApp,
            this.tmsiDeleteApp,
            this.toolStripSeparator2,
            this.tmsiCancelApp,
            this.toolStripSeparator3,
            this.tmsiTests,
            this.tmsiIssueDrivingLicense,
            this.toolStripSeparator4,
            this.toolStripSeparator5,
            this.tmsiShowLicense,
            this.toolStripSeparator6,
            this.tmsiShowPersonLicenseHistory});
            this.cmsApplications.Name = "contextMenuStrip1";
            this.cmsApplications.Size = new System.Drawing.Size(373, 316);
            this.cmsApplications.Opening += new System.ComponentModel.CancelEventHandler(this.cmsApplications_Opening);
            // 
            // tmsiShowApplicationDetails
            // 
            this.tmsiShowApplicationDetails.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tmsiShowApplicationDetails.Image = global::DVLD_PresentationLayer_PL_.Properties.Resources.PersonDetails_32;
            this.tmsiShowApplicationDetails.Name = "tmsiShowApplicationDetails";
            this.tmsiShowApplicationDetails.Size = new System.Drawing.Size(372, 34);
            this.tmsiShowApplicationDetails.Text = "Show Application Details";
            this.tmsiShowApplicationDetails.Click += new System.EventHandler(this.tmsiShowApplicationDetails_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(369, 6);
            // 
            // tmsiEditApp
            // 
            this.tmsiEditApp.AutoSize = false;
            this.tmsiEditApp.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tmsiEditApp.Image = global::DVLD_PresentationLayer_PL_.Properties.Resources.edit_32;
            this.tmsiEditApp.Name = "tmsiEditApp";
            this.tmsiEditApp.Size = new System.Drawing.Size(358, 38);
            this.tmsiEditApp.Text = "Edit Application";
            this.tmsiEditApp.Click += new System.EventHandler(this.tmsiEditApp_Click);
            // 
            // tmsiDeleteApp
            // 
            this.tmsiDeleteApp.Image = global::DVLD_PresentationLayer_PL_.Properties.Resources.Delete_32_2;
            this.tmsiDeleteApp.Name = "tmsiDeleteApp";
            this.tmsiDeleteApp.Size = new System.Drawing.Size(372, 34);
            this.tmsiDeleteApp.Text = "Delete Application";
            this.tmsiDeleteApp.Click += new System.EventHandler(this.tmsiDeleteApp_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(369, 6);
            // 
            // tmsiCancelApp
            // 
            this.tmsiCancelApp.Image = global::DVLD_PresentationLayer_PL_.Properties.Resources.Delete_32;
            this.tmsiCancelApp.Name = "tmsiCancelApp";
            this.tmsiCancelApp.Size = new System.Drawing.Size(372, 34);
            this.tmsiCancelApp.Text = "Cancel Application";
            this.tmsiCancelApp.Click += new System.EventHandler(this.cancToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(369, 6);
            // 
            // tmsiTests
            // 
            this.tmsiTests.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmsiVisionTest,
            this.tmsiWrittenTest,
            this.tmsiStreetTest});
            this.tmsiTests.Image = global::DVLD_PresentationLayer_PL_.Properties.Resources.Schedule_Test_5121;
            this.tmsiTests.Name = "tmsiTests";
            this.tmsiTests.Size = new System.Drawing.Size(372, 34);
            this.tmsiTests.Text = "Schdule Tests";
            // 
            // tmsiVisionTest
            // 
            this.tmsiVisionTest.Image = global::DVLD_PresentationLayer_PL_.Properties.Resources.Vision_Test_32;
            this.tmsiVisionTest.Name = "tmsiVisionTest";
            this.tmsiVisionTest.Size = new System.Drawing.Size(293, 36);
            this.tmsiVisionTest.Text = "Schdule Vision Test";
            this.tmsiVisionTest.Click += new System.EventHandler(this.tmsiVisionTest_Click);
            // 
            // tmsiWrittenTest
            // 
            this.tmsiWrittenTest.Image = global::DVLD_PresentationLayer_PL_.Properties.Resources.Written_Test_32;
            this.tmsiWrittenTest.Name = "tmsiWrittenTest";
            this.tmsiWrittenTest.Size = new System.Drawing.Size(293, 36);
            this.tmsiWrittenTest.Text = "Schdule Written Test";
            this.tmsiWrittenTest.Click += new System.EventHandler(this.tmsiWrittenTest_Click);
            // 
            // tmsiStreetTest
            // 
            this.tmsiStreetTest.Image = global::DVLD_PresentationLayer_PL_.Properties.Resources.Street_Test_32;
            this.tmsiStreetTest.Name = "tmsiStreetTest";
            this.tmsiStreetTest.Size = new System.Drawing.Size(293, 36);
            this.tmsiStreetTest.Text = "Schdule Street Test";
            this.tmsiStreetTest.Click += new System.EventHandler(this.tmsiStreetTest_Click);
            // 
            // tmsiIssueDrivingLicense
            // 
            this.tmsiIssueDrivingLicense.Image = global::DVLD_PresentationLayer_PL_.Properties.Resources.IssueDrivingLicense_32;
            this.tmsiIssueDrivingLicense.Name = "tmsiIssueDrivingLicense";
            this.tmsiIssueDrivingLicense.Size = new System.Drawing.Size(372, 34);
            this.tmsiIssueDrivingLicense.Text = "Issue Driving License (First Time)";
            this.tmsiIssueDrivingLicense.Click += new System.EventHandler(this.tmsiIssueDrivingLicense_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(369, 6);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(369, 6);
            // 
            // tmsiShowLicense
            // 
            this.tmsiShowLicense.Image = global::DVLD_PresentationLayer_PL_.Properties.Resources.LicenseView_400;
            this.tmsiShowLicense.Name = "tmsiShowLicense";
            this.tmsiShowLicense.Size = new System.Drawing.Size(372, 34);
            this.tmsiShowLicense.Text = "Show License";
            this.tmsiShowLicense.Click += new System.EventHandler(this.tmsiShowLicense_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(369, 6);
            // 
            // tmsiShowPersonLicenseHistory
            // 
            this.tmsiShowPersonLicenseHistory.Image = global::DVLD_PresentationLayer_PL_.Properties.Resources.PersonLicenseHistory_32;
            this.tmsiShowPersonLicenseHistory.Name = "tmsiShowPersonLicenseHistory";
            this.tmsiShowPersonLicenseHistory.Size = new System.Drawing.Size(372, 34);
            this.tmsiShowPersonLicenseHistory.Text = "Show Person License History";
            this.tmsiShowPersonLicenseHistory.Click += new System.EventHandler(this.tmsiShowPersonLicenseHistory_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 634);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "#Records: ";
            // 
            // lblCountLDLApp
            // 
            this.lblCountLDLApp.AutoSize = true;
            this.lblCountLDLApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountLDLApp.Location = new System.Drawing.Point(168, 637);
            this.lblCountLDLApp.Name = "lblCountLDLApp";
            this.lblCountLDLApp.Size = new System.Drawing.Size(30, 32);
            this.lblCountLDLApp.TabIndex = 7;
            this.lblCountLDLApp.Text = "0\r\n";
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(348, 296);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(251, 35);
            this.txtFilter.TabIndex = 9;
            this.txtFilter.Visible = false;
            this.txtFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilter_KeyPress);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DVLD_PresentationLayer_PL_.Properties.Resources.Local_32;
            this.pictureBox2.Location = new System.Drawing.Point(670, 60);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNew.Image = global::DVLD_PresentationLayer_PL_.Properties.Resources.New_Application_64;
            this.btnAddNew.Location = new System.Drawing.Point(1153, 272);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(69, 70);
            this.btnAddNew.TabIndex = 4;
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_PresentationLayer_PL_.Properties.Resources.Applications1;
            this.pictureBox1.Location = new System.Drawing.Point(501, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LocalDrivingLicenseApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 679);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblCountLDLApp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvLocalDrivingLicenseApp);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "LocalDrivingLicenseApplications";
            this.Text = "LocalDrivingLicenseApplications";
            this.Load += new System.EventHandler(this.LocalDrivingLicenseApplications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalDrivingLicenseApp)).EndInit();
            this.cmsApplications.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.DataGridView dgvLocalDrivingLicenseApp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCountLDLApp;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.ContextMenuStrip cmsApplications;
        private System.Windows.Forms.ToolStripMenuItem tmsiShowApplicationDetails;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tmsiEditApp;
        private System.Windows.Forms.ToolStripMenuItem tmsiDeleteApp;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tmsiCancelApp;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tmsiTests;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem tmsiIssueDrivingLicense;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem tmsiShowLicense;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem tmsiShowPersonLicenseHistory;
        private System.Windows.Forms.ToolStripMenuItem tmsiVisionTest;
        private System.Windows.Forms.ToolStripMenuItem tmsiWrittenTest;
        private System.Windows.Forms.ToolStripMenuItem tmsiStreetTest;
    }
}