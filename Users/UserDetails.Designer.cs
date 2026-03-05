namespace DVLD_PresentationLayer_PL_.Users
{
    partial class UserDetails
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
            this.btnClose = new System.Windows.Forms.Button();
            this.cntrlUserInfoCard1 = new DVLD_PresentationLayer_PL_.User_Controls.CntrlUserInfoCard();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Image = global::DVLD_PresentationLayer_PL_.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(914, 541);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(144, 41);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // cntrlUserInfoCard1
            // 
            this.cntrlUserInfoCard1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cntrlUserInfoCard1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cntrlUserInfoCard1.Location = new System.Drawing.Point(11, 6);
            this.cntrlUserInfoCard1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cntrlUserInfoCard1.Name = "cntrlUserInfoCard1";
            this.cntrlUserInfoCard1.Size = new System.Drawing.Size(1059, 528);
            this.cntrlUserInfoCard1.TabIndex = 0;
            this.cntrlUserInfoCard1.Load += new System.EventHandler(this.cntrlUserInfoCard1_Load);
            // 
            // UserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 596);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cntrlUserInfoCard1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "UserDetails";
            this.Text = "UserDetails";
            this.ResumeLayout(false);

        }

        #endregion

        private User_Controls.CntrlUserInfoCard cntrlUserInfoCard1;
        private System.Windows.Forms.Button btnClose;
    }
}