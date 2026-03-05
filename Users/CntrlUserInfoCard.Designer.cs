namespace DVLD_PresentationLayer_PL_.User_Controls
{
    partial class CntrlUserInfoCard
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
            this.cntrlPersonDetails1 = new DVLD_PresentationLayer_PL_.CntrlPersonDetails();
            this.gpLoginInfo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblIsActive = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gpLoginInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // cntrlPersonDetails1
            // 
            this.cntrlPersonDetails1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cntrlPersonDetails1.Location = new System.Drawing.Point(5, 13);
            this.cntrlPersonDetails1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cntrlPersonDetails1.Name = "cntrlPersonDetails1";
            //this.cntrlPersonDetails1.PersonID = "???";
            this.cntrlPersonDetails1.Size = new System.Drawing.Size(1041, 375);
            this.cntrlPersonDetails1.TabIndex = 0;
            // 
            // gpLoginInfo
            // 
            this.gpLoginInfo.Controls.Add(this.lblIsActive);
            this.gpLoginInfo.Controls.Add(this.label6);
            this.gpLoginInfo.Controls.Add(this.lblUsername);
            this.gpLoginInfo.Controls.Add(this.label4);
            this.gpLoginInfo.Controls.Add(this.lblUserID);
            this.gpLoginInfo.Controls.Add(this.label1);
            this.gpLoginInfo.Location = new System.Drawing.Point(7, 397);
            this.gpLoginInfo.Name = "gpLoginInfo";
            this.gpLoginInfo.Size = new System.Drawing.Size(1038, 124);
            this.gpLoginInfo.TabIndex = 1;
            this.gpLoginInfo.TabStop = false;
            this.gpLoginInfo.Text = "Login Information: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserID: ";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.Location = new System.Drawing.Point(219, 55);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(52, 29);
            this.lblUserID.TabIndex = 1;
            this.lblUserID.Text = "???";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(521, 55);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(52, 29);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "???";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(380, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "UserName: ";
            // 
            // lblIsActive
            // 
            this.lblIsActive.AutoSize = true;
            this.lblIsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsActive.Location = new System.Drawing.Point(869, 55);
            this.lblIsActive.Name = "lblIsActive";
            this.lblIsActive.Size = new System.Drawing.Size(52, 29);
            this.lblIsActive.TabIndex = 5;
            this.lblIsActive.Text = "???";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(760, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 29);
            this.label6.TabIndex = 4;
            this.label6.Text = "is Active: ";
            // 
            // CntrlUserInfoCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gpLoginInfo);
            this.Controls.Add(this.cntrlPersonDetails1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "CntrlUserInfoCard";
            this.Size = new System.Drawing.Size(1046, 528);
            this.gpLoginInfo.ResumeLayout(false);
            this.gpLoginInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CntrlPersonDetails cntrlPersonDetails1;
        private System.Windows.Forms.GroupBox gpLoginInfo;
        private System.Windows.Forms.Label lblIsActive;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label label1;
    }
}
