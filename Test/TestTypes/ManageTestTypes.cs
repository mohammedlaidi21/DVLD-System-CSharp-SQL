using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_BusinessLogicLayer_BLL_.Test_Types;

namespace DVLD_PresentationLayer_PL_.TestTypes
{
    public partial class ManageTestTypes : Form
    {
        private DataTable _dtTestTypesList;
        public ManageTestTypes()
        {
            InitializeComponent();
        }

        private void ManageTestTypes_Load(object sender, EventArgs e)
        {
            _dtTestTypesList = clsTestTypes.GetAllTestTypes();
            dgvTestTypes.DataSource = _dtTestTypesList;

            lblCountTestTypes.Text = dgvTestTypes.Rows.Count.ToString();

            if (dgvTestTypes.Rows.Count > 0)
            {
                dgvTestTypes.Columns[0].HeaderText = "ID";
                dgvTestTypes.Columns[0].Width = 120;
            
                dgvTestTypes.Columns[1].HeaderText = "Title";
                dgvTestTypes.Columns[1].Width = 200;
            
                dgvTestTypes.Columns[2].HeaderText = "Description";
                dgvTestTypes.Columns[2].Width = 400;
            
                dgvTestTypes.Columns[3].HeaderText = "Fees";
                dgvTestTypes.Columns[3].Width = 100;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editTestTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditTestTypes frmEdutTestType = new EditTestTypes((clsTestTypes.enTestType)dgvTestTypes.CurrentRow.Cells[0].Value);
            //frmEdutTestType._OnLoadData += _LoadDataInDataGrid;
            frmEdutTestType.ShowDialog();

            ManageTestTypes_Load(null, null);
        }
    }
}
