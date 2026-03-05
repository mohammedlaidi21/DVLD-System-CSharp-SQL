namespace DVLD_PresentationLayer_PL_.Licenses
{
    partial class LicensesHistory
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
            this.label1 = new System.Windows.Forms.Label();
            this.cntrlPersonDetailsWithFilter1 = new DVLD_PresentationLayer_PL_.User_Controls.CntrlPersonDetailsWithFilter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cntrlDriverLicenseHistory1 = new DVLD_PresentationLayer_PL_.User_Controls.CntrlDriverLicenseHistory();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(414, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 65);
            this.label1.TabIndex = 1;
            this.label1.Text = "License History";
            // 
            // cntrlPersonDetailsWithFilter1
            // 
            this.cntrlPersonDetailsWithFilter1.FilterEnable = true;
            this.cntrlPersonDetailsWithFilter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cntrlPersonDetailsWithFilter1.Location = new System.Drawing.Point(217, 81);
            this.cntrlPersonDetailsWithFilter1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cntrlPersonDetailsWithFilter1.Name = "cntrlPersonDetailsWithFilter1";
            this.cntrlPersonDetailsWithFilter1.ShowAddPerson = true;
            this.cntrlPersonDetailsWithFilter1.Size = new System.Drawing.Size(1039, 513);
            this.cntrlPersonDetailsWithFilter1.TabIndex = 2;
            this.cntrlPersonDetailsWithFilter1.OnSendPerson += new System.Action<int>(this.cntrlPersonDetailsWithFilter1_OnSendPerson);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_PresentationLayer_PL_.Properties.Resources.PersonLicenseHistory_512;
            this.pictureBox1.Location = new System.Drawing.Point(10, 224);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 219);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cntrlDriverLicenseHistory1
            // 
            this.cntrlDriverLicenseHistory1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cntrlDriverLicenseHistory1.Location = new System.Drawing.Point(51, 599);
            this.cntrlDriverLicenseHistory1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cntrlDriverLicenseHistory1.Name = "cntrlDriverLicenseHistory1";
            this.cntrlDriverLicenseHistory1.Size = new System.Drawing.Size(1192, 391);
            this.cntrlDriverLicenseHistory1.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::DVLD_PresentationLayer_PL_.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(990, 996);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(154, 43);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // LicensesHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1269, 1050);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cntrlDriverLicenseHistory1);
            this.Controls.Add(this.cntrlPersonDetailsWithFilter1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "LicensesHistory";
            this.Text = "LicensesHistory";
            this.Load += new System.EventHandler(this.LicensesHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private User_Controls.CntrlPersonDetailsWithFilter cntrlPersonDetailsWithFilter1;
        private User_Controls.CntrlDriverLicenseHistory cntrlDriverLicenseHistory1;
        private System.Windows.Forms.Button btnClose;
    }
}