namespace DVLD_PresentationLayer_PL_.People
{
    partial class frmFindPerson
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
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(424, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 70);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find Person";
            // 
            // cntrlPersonDetailsWithFilter1
            // 
            this.cntrlPersonDetailsWithFilter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cntrlPersonDetailsWithFilter1.Location = new System.Drawing.Point(50, 91);
            this.cntrlPersonDetailsWithFilter1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cntrlPersonDetailsWithFilter1.Name = "cntrlPersonDetailsWithFilter1";
            this.cntrlPersonDetailsWithFilter1.Size = new System.Drawing.Size(1104, 531);
            this.cntrlPersonDetailsWithFilter1.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::DVLD_PresentationLayer_PL_.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(927, 627);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(148, 39);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmFindPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 699);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cntrlPersonDetailsWithFilter1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmFindPerson";
            this.Text = "frmFindPerson";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private User_Controls.CntrlPersonDetailsWithFilter cntrlPersonDetailsWithFilter1;
        private System.Windows.Forms.Button btnClose;
    }
}