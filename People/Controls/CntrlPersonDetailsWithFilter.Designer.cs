namespace DVLD_PresentationLayer_PL_.User_Controls
{
    partial class CntrlPersonDetailsWithFilter
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
            this.components = new System.ComponentModel.Container();
            this.gpFilterBy = new System.Windows.Forms.GroupBox();
            this.btnAddNewPerson = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchPerson = new System.Windows.Forms.TextBox();
            this.cbSearchPerson = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cntrlPersonDetails1 = new DVLD_PresentationLayer_PL_.CntrlPersonDetails();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gpFilterBy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gpFilterBy
            // 
            this.gpFilterBy.Controls.Add(this.btnAddNewPerson);
            this.gpFilterBy.Controls.Add(this.btnSearch);
            this.gpFilterBy.Controls.Add(this.txtSearchPerson);
            this.gpFilterBy.Controls.Add(this.cbSearchPerson);
            this.gpFilterBy.Controls.Add(this.label1);
            this.gpFilterBy.Location = new System.Drawing.Point(16, 4);
            this.gpFilterBy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpFilterBy.Name = "gpFilterBy";
            this.gpFilterBy.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpFilterBy.Size = new System.Drawing.Size(1007, 132);
            this.gpFilterBy.TabIndex = 1;
            this.gpFilterBy.TabStop = false;
            this.gpFilterBy.Text = "Filter: ";
            this.gpFilterBy.Enter += new System.EventHandler(this.gpFilterBy_Enter);
            // 
            // btnAddNewPerson
            // 
            this.btnAddNewPerson.Image = global::DVLD_PresentationLayer_PL_.Properties.Resources.Add_Person_402;
            this.btnAddNewPerson.Location = new System.Drawing.Point(615, 59);
            this.btnAddNewPerson.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddNewPerson.Name = "btnAddNewPerson";
            this.btnAddNewPerson.Size = new System.Drawing.Size(56, 41);
            this.btnAddNewPerson.TabIndex = 4;
            this.btnAddNewPerson.UseVisualStyleBackColor = true;
            this.btnAddNewPerson.Click += new System.EventHandler(this.btnAddNewPerson_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::DVLD_PresentationLayer_PL_.Properties.Resources.SearchPerson;
            this.btnSearch.Location = new System.Drawing.Point(545, 60);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(56, 41);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchPerson
            // 
            this.txtSearchPerson.Location = new System.Drawing.Point(317, 66);
            this.txtSearchPerson.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchPerson.Name = "txtSearchPerson";
            this.txtSearchPerson.Size = new System.Drawing.Size(209, 30);
            this.txtSearchPerson.TabIndex = 2;
            this.txtSearchPerson.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchPerson_KeyPress);
            this.txtSearchPerson.Validating += new System.ComponentModel.CancelEventHandler(this.txtSearchPerson_Validating);
            // 
            // cbSearchPerson
            // 
            this.cbSearchPerson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearchPerson.FormattingEnabled = true;
            this.cbSearchPerson.Items.AddRange(new object[] {
            "Person ID",
            "National No"});
            this.cbSearchPerson.Location = new System.Drawing.Point(108, 66);
            this.cbSearchPerson.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSearchPerson.Name = "cbSearchPerson";
            this.cbSearchPerson.Size = new System.Drawing.Size(199, 33);
            this.cbSearchPerson.TabIndex = 1;
            this.cbSearchPerson.SelectedIndexChanged += new System.EventHandler(this.cbSearchPerson_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filter By: ";
            // 
            // cntrlPersonDetails1
            // 
            this.cntrlPersonDetails1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cntrlPersonDetails1.Location = new System.Drawing.Point(16, 143);
            this.cntrlPersonDetails1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cntrlPersonDetails1.Name = "cntrlPersonDetails1";
            this.cntrlPersonDetails1.Size = new System.Drawing.Size(1007, 368);
            this.cntrlPersonDetails1.TabIndex = 2;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // CntrlPersonDetailsWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cntrlPersonDetails1);
            this.Controls.Add(this.gpFilterBy);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "CntrlPersonDetailsWithFilter";
            this.Size = new System.Drawing.Size(1048, 522);
            this.Load += new System.EventHandler(this.CntrlPersonDetailsWithFilter_Load);
            this.gpFilterBy.ResumeLayout(false);
            this.gpFilterBy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gpFilterBy;
        private System.Windows.Forms.ComboBox cbSearchPerson;
        private System.Windows.Forms.Label label1;
        private CntrlPersonDetails cntrlPersonDetails1;
        private System.Windows.Forms.Button btnAddNewPerson;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchPerson;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
