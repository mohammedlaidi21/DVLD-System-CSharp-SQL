namespace DVLD_PresentationLayer_PL_.Applications.LocalDrivingLicenseApplication
{
    partial class frmLocalDrivingLicenseApplicationInfo
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
            this.cntrlVisionTestAppointments1 = new DVLD_PresentationLayer_PL_.User_Controls.CntrlVisionTestAppointments();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cntrlVisionTestAppointments1
            // 
            this.cntrlVisionTestAppointments1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cntrlVisionTestAppointments1.Location = new System.Drawing.Point(13, 13);
            this.cntrlVisionTestAppointments1.Margin = new System.Windows.Forms.Padding(4);
            this.cntrlVisionTestAppointments1.Name = "cntrlVisionTestAppointments1";
            this.cntrlVisionTestAppointments1.Size = new System.Drawing.Size(1088, 477);
            this.cntrlVisionTestAppointments1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::DVLD_PresentationLayer_PL_.Properties.Resources.Close_32;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(949, 497);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmLocalDrivingLicenseApplicationInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 551);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cntrlVisionTestAppointments1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLocalDrivingLicenseApplicationInfo";
            this.ShowIcon = false;
            this.Text = "frmLocalDrivingLicenseApplicationInfo";
            this.Load += new System.EventHandler(this.frmLocalDrivingLicenseApplicationInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private User_Controls.CntrlVisionTestAppointments cntrlVisionTestAppointments1;
        private System.Windows.Forms.Button button1;
    }
}