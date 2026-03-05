namespace DVLD_PresentationLayer_PL_.Drivers
{
    partial class ListDrivers
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
            this.dgvDrivers = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCountDrivers = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmsDrivers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiShowPersonInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiIssueInternationalLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowPersonLicenseHistory = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrivers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.cmsDrivers.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(491, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 65);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage Drivers";
            // 
            // dgvDrivers
            // 
            this.dgvDrivers.AllowUserToAddRows = false;
            this.dgvDrivers.AllowUserToDeleteRows = false;
            this.dgvDrivers.AllowUserToOrderColumns = true;
            this.dgvDrivers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDrivers.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvDrivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDrivers.Location = new System.Drawing.Point(12, 318);
            this.dgvDrivers.Name = "dgvDrivers";
            this.dgvDrivers.ReadOnly = true;
            this.dgvDrivers.RowHeadersWidth = 62;
            this.dgvDrivers.RowTemplate.Height = 28;
            this.dgvDrivers.Size = new System.Drawing.Size(1200, 287);
            this.dgvDrivers.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 620);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "#Records: ";
            // 
            // lblCountDrivers
            // 
            this.lblCountDrivers.AutoSize = true;
            this.lblCountDrivers.Location = new System.Drawing.Point(120, 622);
            this.lblCountDrivers.Name = "lblCountDrivers";
            this.lblCountDrivers.Size = new System.Drawing.Size(26, 29);
            this.lblCountDrivers.TabIndex = 4;
            this.lblCountDrivers.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 30);
            this.label4.TabIndex = 6;
            this.label4.Text = "Filter By: ";
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(341, 275);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(258, 35);
            this.txtFilter.TabIndex = 7;
            this.txtFilter.Visible = false;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            this.txtFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilter_KeyPress);
            // 
            // cbFilter
            // 
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "None",
            "Driver ID",
            "Person ID",
            "National No",
            "Full Name"});
            this.cbFilter.Location = new System.Drawing.Point(112, 274);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(223, 37);
            this.cbFilter.TabIndex = 8;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::DVLD_PresentationLayer_PL_.Properties.Resources.Close_32;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1063, 621);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 44);
            this.button1.TabIndex = 5;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_PresentationLayer_PL_.Properties.Resources.Driver_Main;
            this.pictureBox1.Location = new System.Drawing.Point(502, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cmsDrivers
            // 
            this.cmsDrivers.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsDrivers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiShowPersonInfo,
            this.tsmiIssueInternationalLicense,
            this.ShowPersonLicenseHistory});
            this.cmsDrivers.Name = "cmsDrivers";
            this.cmsDrivers.Size = new System.Drawing.Size(318, 100);
            // 
            // tsmiShowPersonInfo
            // 
            this.tsmiShowPersonInfo.Image = global::DVLD_PresentationLayer_PL_.Properties.Resources.PersonDetails_32;
            this.tsmiShowPersonInfo.Name = "tsmiShowPersonInfo";
            this.tsmiShowPersonInfo.Size = new System.Drawing.Size(317, 32);
            this.tsmiShowPersonInfo.Text = "Show Person Info";
            this.tsmiShowPersonInfo.Click += new System.EventHandler(this.tsmiShowPersonInfo_Click);
            // 
            // tsmiIssueInternationalLicense
            // 
            this.tsmiIssueInternationalLicense.Image = global::DVLD_PresentationLayer_PL_.Properties.Resources.International_32;
            this.tsmiIssueInternationalLicense.Name = "tsmiIssueInternationalLicense";
            this.tsmiIssueInternationalLicense.Size = new System.Drawing.Size(317, 32);
            this.tsmiIssueInternationalLicense.Text = "Issue International License";
            this.tsmiIssueInternationalLicense.Click += new System.EventHandler(this.tsmiIssueInternationalLicense_Click);
            // 
            // ShowPersonLicenseHistory
            // 
            this.ShowPersonLicenseHistory.Image = global::DVLD_PresentationLayer_PL_.Properties.Resources.PersonLicenseHistory_32;
            this.ShowPersonLicenseHistory.Name = "ShowPersonLicenseHistory";
            this.ShowPersonLicenseHistory.Size = new System.Drawing.Size(317, 32);
            this.ShowPersonLicenseHistory.Text = "Show Person License History";
            this.ShowPersonLicenseHistory.Click += new System.EventHandler(this.ShowPersonLicenseHistory_Click);
            // 
            // ListDrivers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 693);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblCountDrivers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvDrivers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListDrivers";
            this.ShowIcon = false;
            this.Text = "ListDrivers";
            this.Load += new System.EventHandler(this.ListDrivers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrivers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.cmsDrivers.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDrivers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCountDrivers;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.ContextMenuStrip cmsDrivers;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowPersonInfo;
        private System.Windows.Forms.ToolStripMenuItem tsmiIssueInternationalLicense;
        private System.Windows.Forms.ToolStripMenuItem ShowPersonLicenseHistory;
    }
}