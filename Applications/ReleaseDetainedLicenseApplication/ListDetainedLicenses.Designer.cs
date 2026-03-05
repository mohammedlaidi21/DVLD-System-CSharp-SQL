namespace DVLD_PresentationLayer_PL_.Detain_Release_Licenses
{
    partial class ListDetainedLicenses
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
            this.cbDetainedLicense = new System.Windows.Forms.ComboBox();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.dgvListDetainedLicenses = new System.Windows.Forms.DataGridView();
            this.cmsOperations = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showPersonDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicenseDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonHistoryLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.releaseDetainedLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.btnDetain = new System.Windows.Forms.Button();
            this.btnRelease = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pYesNo = new System.Windows.Forms.Panel();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.rbYes = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListDetainedLicenses)).BeginInit();
            this.cmsOperations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pYesNo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(429, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 60);
            this.label1.TabIndex = 1;
            this.label1.Text = "List Detined Licenses ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Filter By: ";
            // 
            // cbDetainedLicense
            // 
            this.cbDetainedLicense.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDetainedLicense.FormattingEnabled = true;
            this.cbDetainedLicense.Items.AddRange(new object[] {
            "None",
            "Detain ID",
            "Is Released",
            "National No",
            "Full Name",
            "Release Application ID"});
            this.cbDetainedLicense.Location = new System.Drawing.Point(120, 246);
            this.cbDetainedLicense.Name = "cbDetainedLicense";
            this.cbDetainedLicense.Size = new System.Drawing.Size(221, 37);
            this.cbDetainedLicense.TabIndex = 3;
            this.cbDetainedLicense.SelectedIndexChanged += new System.EventHandler(this.cbDetainedLicense_SelectedIndexChanged);
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(347, 247);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(252, 35);
            this.txtFilter.TabIndex = 4;
            this.txtFilter.Visible = false;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            this.txtFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilter_KeyPress);
            // 
            // dgvListDetainedLicenses
            // 
            this.dgvListDetainedLicenses.AllowUserToAddRows = false;
            this.dgvListDetainedLicenses.AllowUserToDeleteRows = false;
            this.dgvListDetainedLicenses.AllowUserToOrderColumns = true;
            this.dgvListDetainedLicenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListDetainedLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListDetainedLicenses.ContextMenuStrip = this.cmsOperations;
            this.dgvListDetainedLicenses.Location = new System.Drawing.Point(17, 302);
            this.dgvListDetainedLicenses.Name = "dgvListDetainedLicenses";
            this.dgvListDetainedLicenses.ReadOnly = true;
            this.dgvListDetainedLicenses.RowHeadersWidth = 62;
            this.dgvListDetainedLicenses.RowTemplate.Height = 28;
            this.dgvListDetainedLicenses.Size = new System.Drawing.Size(1201, 263);
            this.dgvListDetainedLicenses.TabIndex = 7;
            // 
            // cmsOperations
            // 
            this.cmsOperations.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsOperations.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPersonDetailsToolStripMenuItem,
            this.showLicenseDetailsToolStripMenuItem,
            this.showPersonHistoryLicenseToolStripMenuItem,
            this.releaseDetainedLicensesToolStripMenuItem});
            this.cmsOperations.Name = "cmsOperations";
            this.cmsOperations.Size = new System.Drawing.Size(318, 165);
            this.cmsOperations.Opening += new System.ComponentModel.CancelEventHandler(this.cmsOperations_Opening);
            // 
            // showPersonDetailsToolStripMenuItem
            // 
            this.showPersonDetailsToolStripMenuItem.Image = global::DVLD_PresentationLayer_PL_.Properties.Resources.PersonDetails_32;
            this.showPersonDetailsToolStripMenuItem.Name = "showPersonDetailsToolStripMenuItem";
            this.showPersonDetailsToolStripMenuItem.Size = new System.Drawing.Size(317, 32);
            this.showPersonDetailsToolStripMenuItem.Text = "Show Person Details";
            this.showPersonDetailsToolStripMenuItem.Click += new System.EventHandler(this.showPersonDetailsToolStripMenuItem_Click);
            // 
            // showLicenseDetailsToolStripMenuItem
            // 
            this.showLicenseDetailsToolStripMenuItem.Image = global::DVLD_PresentationLayer_PL_.Properties.Resources.License_View_32;
            this.showLicenseDetailsToolStripMenuItem.Name = "showLicenseDetailsToolStripMenuItem";
            this.showLicenseDetailsToolStripMenuItem.Size = new System.Drawing.Size(317, 32);
            this.showLicenseDetailsToolStripMenuItem.Text = "Show License Details";
            this.showLicenseDetailsToolStripMenuItem.Click += new System.EventHandler(this.showLicenseDetailsToolStripMenuItem_Click);
            // 
            // showPersonHistoryLicenseToolStripMenuItem
            // 
            this.showPersonHistoryLicenseToolStripMenuItem.Image = global::DVLD_PresentationLayer_PL_.Properties.Resources.PersonLicenseHistory_321;
            this.showPersonHistoryLicenseToolStripMenuItem.Name = "showPersonHistoryLicenseToolStripMenuItem";
            this.showPersonHistoryLicenseToolStripMenuItem.Size = new System.Drawing.Size(317, 32);
            this.showPersonHistoryLicenseToolStripMenuItem.Text = "Show PersonLicense  History";
            this.showPersonHistoryLicenseToolStripMenuItem.Click += new System.EventHandler(this.showPersonHistoryLicenseToolStripMenuItem_Click);
            // 
            // releaseDetainedLicensesToolStripMenuItem
            // 
            this.releaseDetainedLicensesToolStripMenuItem.Image = global::DVLD_PresentationLayer_PL_.Properties.Resources.Release_Detained_License_32;
            this.releaseDetainedLicensesToolStripMenuItem.Name = "releaseDetainedLicensesToolStripMenuItem";
            this.releaseDetainedLicensesToolStripMenuItem.Size = new System.Drawing.Size(317, 32);
            this.releaseDetainedLicensesToolStripMenuItem.Text = "Release Detained Licenses";
            this.releaseDetainedLicensesToolStripMenuItem.Click += new System.EventHandler(this.releaseDetainedLicensesToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 577);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 30);
            this.label3.TabIndex = 8;
            this.label3.Text = "#Records: ";
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::DVLD_PresentationLayer_PL_.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1048, 575);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(170, 41);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(138, 578);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(26, 29);
            this.lblCount.TabIndex = 10;
            this.lblCount.Text = "0";
            // 
            // btnDetain
            // 
            this.btnDetain.Image = global::DVLD_PresentationLayer_PL_.Properties.Resources.Detain_641;
            this.btnDetain.Location = new System.Drawing.Point(1143, 231);
            this.btnDetain.Name = "btnDetain";
            this.btnDetain.Size = new System.Drawing.Size(75, 67);
            this.btnDetain.TabIndex = 6;
            this.btnDetain.UseVisualStyleBackColor = true;
            this.btnDetain.Click += new System.EventHandler(this.btnDetain_Click);
            // 
            // btnRelease
            // 
            this.btnRelease.Image = global::DVLD_PresentationLayer_PL_.Properties.Resources.Release_Detained_License_64;
            this.btnRelease.Location = new System.Drawing.Point(1062, 231);
            this.btnRelease.Name = "btnRelease";
            this.btnRelease.Size = new System.Drawing.Size(75, 67);
            this.btnRelease.TabIndex = 5;
            this.btnRelease.UseVisualStyleBackColor = true;
            this.btnRelease.Click += new System.EventHandler(this.btnRelease_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_PresentationLayer_PL_.Properties.Resources.Detain_512;
            this.pictureBox1.Location = new System.Drawing.Point(512, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pYesNo
            // 
            this.pYesNo.Controls.Add(this.rbNo);
            this.pYesNo.Controls.Add(this.rbYes);
            this.pYesNo.Location = new System.Drawing.Point(370, 246);
            this.pYesNo.Name = "pYesNo";
            this.pYesNo.Size = new System.Drawing.Size(217, 39);
            this.pYesNo.TabIndex = 11;
            this.pYesNo.Visible = false;
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.Location = new System.Drawing.Point(119, 1);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(70, 33);
            this.rbNo.TabIndex = 1;
            this.rbNo.Text = "No";
            this.rbNo.UseVisualStyleBackColor = true;
            this.rbNo.CheckedChanged += new System.EventHandler(this.rbYesNo_CheckedChanged);
            // 
            // rbYes
            // 
            this.rbYes.AutoSize = true;
            this.rbYes.Checked = true;
            this.rbYes.Location = new System.Drawing.Point(18, 2);
            this.rbYes.Name = "rbYes";
            this.rbYes.Size = new System.Drawing.Size(80, 33);
            this.rbYes.TabIndex = 0;
            this.rbYes.TabStop = true;
            this.rbYes.Text = "Yes";
            this.rbYes.UseVisualStyleBackColor = true;
            this.rbYes.CheckedChanged += new System.EventHandler(this.rbYesNo_CheckedChanged);
            // 
            // ListDetainedLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 624);
            this.Controls.Add(this.pYesNo);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvListDetainedLicenses);
            this.Controls.Add(this.btnDetain);
            this.Controls.Add(this.btnRelease);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.cbDetainedLicense);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "ListDetainedLicenses";
            this.Text = "ListDetainedLicenses";
            this.Load += new System.EventHandler(this.ListDetainedLicenses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListDetainedLicenses)).EndInit();
            this.cmsOperations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pYesNo.ResumeLayout(false);
            this.pYesNo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbDetainedLicense;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Button btnRelease;
        private System.Windows.Forms.Button btnDetain;
        private System.Windows.Forms.DataGridView dgvListDetainedLicenses;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Panel pYesNo;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.RadioButton rbYes;
        private System.Windows.Forms.ContextMenuStrip cmsOperations;
        private System.Windows.Forms.ToolStripMenuItem showPersonDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonHistoryLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem releaseDetainedLicensesToolStripMenuItem;
    }
}