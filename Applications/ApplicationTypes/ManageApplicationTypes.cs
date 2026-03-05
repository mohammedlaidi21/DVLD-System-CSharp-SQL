using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_BusinessLogicLayer_BLL_;

namespace DVLD_PresentationLayer_PL_.ApplicationTypes
{
    public partial class ManageApplicationTypes : Form
    {

        private DataTable _dtAllApplicationTypes;
        public ManageApplicationTypes()
        {
            InitializeComponent();
        }

        private void ManageApplicationTypes_Load(object sender, EventArgs e)
        {
            _dtAllApplicationTypes = clsApplicationTypes.GetAllApplicationTypes();
            dgvApplicationTypes.DataSource = _dtAllApplicationTypes;

            lblCountAppTypes.Text = dgvApplicationTypes.Rows.Count.ToString();

            if (dgvApplicationTypes.Rows.Count > 0)
            {
                dgvApplicationTypes.Columns[0].HeaderText = "ID";
                dgvApplicationTypes.Columns[0].Width = 110;
                
                dgvApplicationTypes.Columns[1].HeaderText = "Title";
                dgvApplicationTypes.Columns[1].Width = 400;
                
                dgvApplicationTypes.Columns[2].HeaderText = "Fees";
                dgvApplicationTypes.Columns[2].Width = 100;

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editApplicationTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditApplicationTypes frmEditApplicationType = new EditApplicationTypes((int)dgvApplicationTypes.CurrentRow.Cells[0].Value);
            //frmEditApplicationType._LoadData += _LoadDataInDataGridView;
            frmEditApplicationType.ShowDialog();
            ManageApplicationTypes_Load(null, null);
        }
    }
}
