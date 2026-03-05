namespace DVLD_PresentationLayer_PL_.LocalDrivingLicenseApplication
{
    partial class NewLocalDrivingLicenseApplication
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
            this.tcLocalDrivingLicenceApplication = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.cntrlPersonDetailsWithFilter1 = new DVLD_PresentationLayer_PL_.User_Controls.CntrlPersonDetailsWithFilter();
            this.tbApplicationInfo = new System.Windows.Forms.TabPage();
            this.cbLicenseClass = new System.Windows.Forms.ComboBox();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.lblAppFees = new System.Windows.Forms.Label();
            this.lblDLAppID = new System.Windows.Forms.Label();
            this.lblAppDate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tcLocalDrivingLicenceApplication.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tbApplicationInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcLocalDrivingLicenceApplication
            // 
            this.tcLocalDrivingLicenceApplication.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tcLocalDrivingLicenceApplication.Controls.Add(this.tabPage1);
            this.tcLocalDrivingLicenceApplication.Controls.Add(this.tbApplicationInfo);
            this.tcLocalDrivingLicenceApplication.Location = new System.Drawing.Point(10, 74);
            this.tcLocalDrivingLicenceApplication.Name = "tcLocalDrivingLicenceApplication";
            this.tcLocalDrivingLicenceApplication.SelectedIndex = 0;
            this.tcLocalDrivingLicenceApplication.Size = new System.Drawing.Size(1076, 693);
            this.tcLocalDrivingLicenceApplication.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnNext);
            this.tabPage1.Controls.Add(this.cntrlPersonDetailsWithFilter1);
            this.tabPage1.Location = new System.Drawing.Point(4, 41);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1068, 648);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Personal Info";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNext.Image = global::DVLD_PresentationLayer_PL_.Properties.Resources.Next_32;
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNext.Location = new System.Drawing.Point(858, 540);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(138, 46);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // cntrlPersonDetailsWithFilter1
            // 
            this.cntrlPersonDetailsWithFilter1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cntrlPersonDetailsWithFilter1.FilterEnable = true;
            this.cntrlPersonDetailsWithFilter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cntrlPersonDetailsWithFilter1.Location = new System.Drawing.Point(19, 22);
            this.cntrlPersonDetailsWithFilter1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cntrlPersonDetailsWithFilter1.Name = "cntrlPersonDetailsWithFilter1";
            this.cntrlPersonDetailsWithFilter1.ShowAddPerson = true;
            this.cntrlPersonDetailsWithFilter1.Size = new System.Drawing.Size(1042, 568);
            this.cntrlPersonDetailsWithFilter1.TabIndex = 0;
            this.cntrlPersonDetailsWithFilter1.OnSendPerson += new System.Action<int>(this.cntrlPersonDetailsWithFilter1_OnSendPerson_1);
            // 
            // tbApplicationInfo
            // 
            this.tbApplicationInfo.Controls.Add(this.cbLicenseClass);
            this.tbApplicationInfo.Controls.Add(this.lblCreatedBy);
            this.tbApplicationInfo.Controls.Add(this.lblAppFees);
            this.tbApplicationInfo.Controls.Add(this.lblDLAppID);
            this.tbApplicationInfo.Controls.Add(this.lblAppDate);
            this.tbApplicationInfo.Controls.Add(this.label6);
            this.tbApplicationInfo.Controls.Add(this.label5);
            this.tbApplicationInfo.Controls.Add(this.label4);
            this.tbApplicationInfo.Controls.Add(this.label3);
            this.tbApplicationInfo.Controls.Add(this.label2);
            this.tbApplicationInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbApplicationInfo.Location = new System.Drawing.Point(4, 41);
            this.tbApplicationInfo.Name = "tbApplicationInfo";
            this.tbApplicationInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbApplicationInfo.Size = new System.Drawing.Size(1068, 648);
            this.tbApplicationInfo.TabIndex = 1;
            this.tbApplicationInfo.Text = "Application Info.";
            this.tbApplicationInfo.UseVisualStyleBackColor = true;
            // 
            // cbLicenseClass
            // 
            this.cbLicenseClass.FormattingEnabled = true;
            this.cbLicenseClass.Location = new System.Drawing.Point(428, 191);
            this.cbLicenseClass.Name = "cbLicenseClass";
            this.cbLicenseClass.Size = new System.Drawing.Size(236, 40);
            this.cbLicenseClass.TabIndex = 9;
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedBy.Location = new System.Drawing.Point(422, 329);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(47, 32);
            this.lblCreatedBy.TabIndex = 8;
            this.lblCreatedBy.Text = "???";
            // 
            // lblAppFees
            // 
            this.lblAppFees.AutoSize = true;
            this.lblAppFees.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppFees.Location = new System.Drawing.Point(422, 258);
            this.lblAppFees.Name = "lblAppFees";
            this.lblAppFees.Size = new System.Drawing.Size(47, 32);
            this.lblAppFees.TabIndex = 7;
            this.lblAppFees.Text = "???";
            // 
            // lblDLAppID
            // 
            this.lblDLAppID.AutoSize = true;
            this.lblDLAppID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDLAppID.Location = new System.Drawing.Point(422, 67);
            this.lblDLAppID.Name = "lblDLAppID";
            this.lblDLAppID.Size = new System.Drawing.Size(65, 32);
            this.lblDLAppID.TabIndex = 6;
            this.lblDLAppID.Text = "[???]";
            // 
            // lblAppDate
            // 
            this.lblAppDate.AutoSize = true;
            this.lblAppDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppDate.Location = new System.Drawing.Point(422, 133);
            this.lblAppDate.Name = "lblAppDate";
            this.lblAppDate.Size = new System.Drawing.Size(47, 32);
            this.lblAppDate.TabIndex = 5;
            this.lblAppDate.Text = "???";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Image = global::DVLD_PresentationLayer_PL_.Properties.Resources.User_32__2;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(123, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(260, 32);
            this.label6.TabIndex = 4;
            this.label6.Text = "Created By: ";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Image = global::DVLD_PresentationLayer_PL_.Properties.Resources.money_32;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(123, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(260, 32);
            this.label5.TabIndex = 3;
            this.label5.Text = "Application Fees: ";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Image = global::DVLD_PresentationLayer_PL_.Properties.Resources.License_Type_32;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(123, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(260, 32);
            this.label4.TabIndex = 2;
            this.label4.Text = "License Class: ";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = global::DVLD_PresentationLayer_PL_.Properties.Resources.Calendar_32;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(123, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Application Date: ";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = global::DVLD_PresentationLayer_PL_.Properties.Resources.Number_32;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(123, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 34);
            this.label2.TabIndex = 0;
            this.label2.Text = "D.L.Application ID: ";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(146, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(820, 60);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "New Local Driving License Application";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClose.Image = global::DVLD_PresentationLayer_PL_.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(741, 773);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(138, 46);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSave.Enabled = false;
            this.btnSave.Image = global::DVLD_PresentationLayer_PL_.Properties.Resources.Save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(900, 773);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(138, 46);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // NewLocalDrivingLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1098, 831);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.tcLocalDrivingLicenceApplication);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NewLocalDrivingLicenseApplication";
            this.Text = "NewLocalDrivingLicenseApplication";
            this.Activated += new System.EventHandler(this.NewLocalDrivingLicenseApplication_Activated);
            this.Load += new System.EventHandler(this.NewLocalDrivingLicenseApplication_Load);
            this.tcLocalDrivingLicenceApplication.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tbApplicationInfo.ResumeLayout(false);
            this.tbApplicationInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcLocalDrivingLicenceApplication;
        private System.Windows.Forms.TabPage tabPage1;
        private User_Controls.CntrlPersonDetailsWithFilter cntrlPersonDetailsWithFilter1;
        private System.Windows.Forms.TabPage tbApplicationInfo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblDLAppID;
        private System.Windows.Forms.Label lblAppDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbLicenseClass;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Label lblAppFees;
    }
}