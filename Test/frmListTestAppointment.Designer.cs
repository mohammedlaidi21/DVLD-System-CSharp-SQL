namespace DVLD_PresentationLayer_PL_
{
    partial class frmListTestAppointment
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvAppointments = new System.Windows.Forms.DataGridView();
            this.cmsAppointments = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCountAppointments = new System.Windows.Forms.Label();
            this.cntrlVisionTestAppointments1 = new DVLD_PresentationLayer_PL_.User_Controls.CntrlVisionTestAppointments();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAppointment = new System.Windows.Forms.Button();
            this.pbListAppointment = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).BeginInit();
            this.cmsAppointments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbListAppointment)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(364, 164);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(641, 65);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Vision Test Appointments";
            // 
            // dgvAppointments
            // 
            this.dgvAppointments.AllowUserToAddRows = false;
            this.dgvAppointments.AllowUserToDeleteRows = false;
            this.dgvAppointments.AllowUserToOrderColumns = true;
            this.dgvAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAppointments.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointments.ContextMenuStrip = this.cmsAppointments;
            this.dgvAppointments.Location = new System.Drawing.Point(19, 739);
            this.dgvAppointments.Name = "dgvAppointments";
            this.dgvAppointments.ReadOnly = true;
            this.dgvAppointments.RowHeadersWidth = 62;
            this.dgvAppointments.RowTemplate.Height = 28;
            this.dgvAppointments.Size = new System.Drawing.Size(1061, 196);
            this.dgvAppointments.TabIndex = 3;
            // 
            // cmsAppointments
            // 
            this.cmsAppointments.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsAppointments.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.takeTestToolStripMenuItem});
            this.cmsAppointments.Name = "contextMenuStrip1";
            this.cmsAppointments.Size = new System.Drawing.Size(162, 68);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::DVLD_PresentationLayer_PL_.Properties.Resources.edit_32;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(161, 32);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // takeTestToolStripMenuItem
            // 
            this.takeTestToolStripMenuItem.Image = global::DVLD_PresentationLayer_PL_.Properties.Resources.Test_32;
            this.takeTestToolStripMenuItem.Name = "takeTestToolStripMenuItem";
            this.takeTestToolStripMenuItem.Size = new System.Drawing.Size(161, 32);
            this.takeTestToolStripMenuItem.Text = "Take Test";
            this.takeTestToolStripMenuItem.Click += new System.EventHandler(this.takeTestToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 690);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Appointments: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 951);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "#Records: ";
            // 
            // lblCountAppointments
            // 
            this.lblCountAppointments.AutoSize = true;
            this.lblCountAppointments.Location = new System.Drawing.Point(135, 949);
            this.lblCountAppointments.Name = "lblCountAppointments";
            this.lblCountAppointments.Size = new System.Drawing.Size(26, 29);
            this.lblCountAppointments.TabIndex = 8;
            this.lblCountAppointments.Text = "0";
            // 
            // cntrlVisionTestAppointments1
            // 
            this.cntrlVisionTestAppointments1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cntrlVisionTestAppointments1.Location = new System.Drawing.Point(5, 224);
            this.cntrlVisionTestAppointments1.Margin = new System.Windows.Forms.Padding(4);
            this.cntrlVisionTestAppointments1.Name = "cntrlVisionTestAppointments1";
            this.cntrlVisionTestAppointments1.Size = new System.Drawing.Size(1091, 448);
            this.cntrlVisionTestAppointments1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Image = global::DVLD_PresentationLayer_PL_.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(941, 942);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(138, 40);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAppointment
            // 
            this.btnAppointment.Image = global::DVLD_PresentationLayer_PL_.Properties.Resources.AddAppointment_32;
            this.btnAppointment.Location = new System.Drawing.Point(1014, 677);
            this.btnAppointment.Name = "btnAppointment";
            this.btnAppointment.Size = new System.Drawing.Size(65, 58);
            this.btnAppointment.TabIndex = 4;
            this.btnAppointment.UseVisualStyleBackColor = true;
            this.btnAppointment.Click += new System.EventHandler(this.btnAppointment_Click);
            // 
            // pbListAppointment
            // 
            this.pbListAppointment.Image = global::DVLD_PresentationLayer_PL_.Properties.Resources.Vision_512;
            this.pbListAppointment.Location = new System.Drawing.Point(478, 12);
            this.pbListAppointment.Name = "pbListAppointment";
            this.pbListAppointment.Size = new System.Drawing.Size(176, 149);
            this.pbListAppointment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbListAppointment.TabIndex = 1;
            this.pbListAppointment.TabStop = false;
            // 
            // frmListTestAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1127, 989);
            this.Controls.Add(this.lblCountAppointments);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAppointment);
            this.Controls.Add(this.dgvAppointments);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbListAppointment);
            this.Controls.Add(this.cntrlVisionTestAppointments1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListTestAppointment";
            this.ShowIcon = false;
            this.Text = "ListTestAppointment";
            this.Load += new System.EventHandler(this.VisionTestAppointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).EndInit();
            this.cmsAppointments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbListAppointment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private User_Controls.CntrlVisionTestAppointments cntrlVisionTestAppointments1;
        private System.Windows.Forms.PictureBox pbListAppointment;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvAppointments;
        private System.Windows.Forms.Button btnAppointment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblCountAppointments;
        private System.Windows.Forms.ContextMenuStrip cmsAppointments;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takeTestToolStripMenuItem;
    }
}