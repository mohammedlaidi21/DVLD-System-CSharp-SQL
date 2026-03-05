namespace DVLD_PresentationLayer_PL_.User_Controls
{
    partial class CntrlVisionTestAppointments
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPassedTest = new System.Windows.Forms.Label();
            this.lblLicenseType = new System.Windows.Forms.Label();
            this.lblDLAppID = new System.Windows.Forms.Label();
            this.lbllShowLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cntrlBaseApplicationInfo1 = new DVLD_PresentationLayer_PL_.Applications.Controls.CntrlBaseApplicationInfo();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPassedTest);
            this.groupBox1.Controls.Add(this.lblLicenseType);
            this.groupBox1.Controls.Add(this.lblDLAppID);
            this.groupBox1.Controls.Add(this.lbllShowLicenseInfo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1065, 129);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Driving License Application Info";
            // 
            // lblPassedTest
            // 
            this.lblPassedTest.AutoSize = true;
            this.lblPassedTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassedTest.Location = new System.Drawing.Point(652, 86);
            this.lblPassedTest.Name = "lblPassedTest";
            this.lblPassedTest.Size = new System.Drawing.Size(43, 25);
            this.lblPassedTest.TabIndex = 6;
            this.lblPassedTest.Text = "0/3";
            // 
            // lblLicenseType
            // 
            this.lblLicenseType.AutoSize = true;
            this.lblLicenseType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenseType.Location = new System.Drawing.Point(653, 43);
            this.lblLicenseType.Name = "lblLicenseType";
            this.lblLicenseType.Size = new System.Drawing.Size(48, 25);
            this.lblLicenseType.TabIndex = 5;
            this.lblLicenseType.Text = "???";
            // 
            // lblDLAppID
            // 
            this.lblDLAppID.AutoSize = true;
            this.lblDLAppID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDLAppID.Location = new System.Drawing.Point(192, 43);
            this.lblDLAppID.Name = "lblDLAppID";
            this.lblDLAppID.Size = new System.Drawing.Size(48, 25);
            this.lblDLAppID.TabIndex = 4;
            this.lblDLAppID.Text = "???";
            // 
            // lbllShowLicenseInfo
            // 
            this.lbllShowLicenseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllShowLicenseInfo.Image = global::DVLD_PresentationLayer_PL_.Properties.Resources.License_View_32;
            this.lbllShowLicenseInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbllShowLicenseInfo.Location = new System.Drawing.Point(66, 86);
            this.lbllShowLicenseInfo.Name = "lbllShowLicenseInfo";
            this.lbllShowLicenseInfo.Size = new System.Drawing.Size(228, 25);
            this.lbllShowLicenseInfo.TabIndex = 3;
            this.lbllShowLicenseInfo.TabStop = true;
            this.lbllShowLicenseInfo.Text = "         Show License Info";
            this.lbllShowLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbllShowLicenseInfo_LinkClicked);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = global::DVLD_PresentationLayer_PL_.Properties.Resources.PassedTests_32;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(457, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Passed Test: ";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = global::DVLD_PresentationLayer_PL_.Properties.Resources.License_Type_32;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(390, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Applied For License:  ";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::DVLD_PresentationLayer_PL_.Properties.Resources.Number_32;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(17, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "D.L.App ID: ";
            // 
            // cntrlBaseApplicationInfo1
            // 
            this.cntrlBaseApplicationInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cntrlBaseApplicationInfo1.Location = new System.Drawing.Point(5, 147);
            this.cntrlBaseApplicationInfo1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cntrlBaseApplicationInfo1.Name = "cntrlBaseApplicationInfo1";
            this.cntrlBaseApplicationInfo1.Size = new System.Drawing.Size(1083, 323);
            this.cntrlBaseApplicationInfo1.TabIndex = 1;
            // 
            // CntrlVisionTestAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cntrlBaseApplicationInfo1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CntrlVisionTestAppointments";
            this.Size = new System.Drawing.Size(1093, 483);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lbllShowLicenseInfo;
        private System.Windows.Forms.Label lblPassedTest;
        private System.Windows.Forms.Label lblLicenseType;
        private System.Windows.Forms.Label lblDLAppID;
        private Applications.Controls.CntrlBaseApplicationInfo cntrlBaseApplicationInfo1;
    }
}
