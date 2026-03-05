namespace DVLD_PresentationLayer_PL_.Test_Appointments
{
    partial class ScheduleTest
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
            this.cntrlScheduleTest1 = new DVLD_PresentationLayer_PL_.Test.CntrlScheduleTest();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cntrlScheduleTest1
            // 
            this.cntrlScheduleTest1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cntrlScheduleTest1.Location = new System.Drawing.Point(14, 13);
            this.cntrlScheduleTest1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cntrlScheduleTest1.Name = "cntrlScheduleTest1";
            this.cntrlScheduleTest1.Size = new System.Drawing.Size(850, 837);
            this.cntrlScheduleTest1.TabIndex = 0;
            this.cntrlScheduleTest1.TestTypeID = DVLD_BusinessLogicLayer_BLL_.Test_Types.clsTestTypes.enTestType.VisionTest;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVLD_PresentationLayer_PL_.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(390, 857);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(167, 45);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ScheduleTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(890, 914);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cntrlScheduleTest1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "ScheduleTest";
            this.Text = "ScheduleTest";
            this.Load += new System.EventHandler(this.ScheduleTest_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Test.CntrlScheduleTest cntrlScheduleTest1;
        private System.Windows.Forms.Button btnClose;
    }
}