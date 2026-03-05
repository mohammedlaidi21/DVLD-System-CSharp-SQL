using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_BusinessLogicLayer_BLL_.Drivers;
using DVLD_PresentationLayer_PL_.InternationalLicenses;
using DVLD_PresentationLayer_PL_.Licenses;

namespace DVLD_PresentationLayer_PL_.Drivers
{
    public partial class ListDrivers : Form
    {
        private DataTable _dtAllDrivers;
        public ListDrivers()
        {
            InitializeComponent();
        }

        private void ListDrivers_Load(object sender, EventArgs e)
        {
            _dtAllDrivers = clsDrivers.GetAllDrivers();
            dgvDrivers.DataSource = _dtAllDrivers;

            lblCountDrivers.Text = dgvDrivers.Rows.Count.ToString();

            if (dgvDrivers.Rows.Count > 0)
            {
                dgvDrivers.Columns[0].HeaderText = "Driver ID";
                dgvDrivers.Columns[0].Width = 120;
            
                dgvDrivers.Columns[1].HeaderText = "Person ID";
                dgvDrivers.Columns[1].Width = 120;
            
                dgvDrivers.Columns[2].HeaderText = "National No.";
                dgvDrivers.Columns[2].Width = 140;
            
                dgvDrivers.Columns[3].HeaderText = "Full Name";
                dgvDrivers.Columns[3].Width = 320;
            
                dgvDrivers.Columns[4].HeaderText = "Date";
                dgvDrivers.Columns[4].Width = 170;
            
                dgvDrivers.Columns[5].HeaderText = "Active Licenses";
                dgvDrivers.Columns[5].Width = 150;
            }

            cbFilter.SelectedIndex = 0;
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilter.Visible = (cbFilter.Text != "None");

            txtFilter.Text = "";
            txtFilter.Focus();
        
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";

            switch (cbFilter.Text)
            {
                case "Driver ID":
                    {
                        FilterColumn = "DriverID";
                        break;
                    }

                case "Person ID":
                    {
                        FilterColumn = "PersonID";
                        break;
                    }


                case "National No":
                    {
                        FilterColumn = "NationalNO";
                        break;
                    }

                case "Full Name":
                    {
                        FilterColumn = "CreatedDate";
                        break;
                    }

                default:
                    FilterColumn = "None";
                    break;
            }

            if (txtFilter.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtAllDrivers.DefaultView.RowFilter = "";
                lblCountDrivers.Text = dgvDrivers.Rows.Count.ToString();
                return;
            }

            if (FilterColumn != "DriverID" && FilterColumn != "PersonID")
                _dtAllDrivers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilter.Text.Trim());

            else
                _dtAllDrivers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilter.Text.Trim());


            lblCountDrivers.Text = dgvDrivers.Rows.Count.ToString();
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.Text == "Driver ID" || cbFilter.Text == "Person ID")
                e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void tsmiShowPersonInfo_Click(object sender, EventArgs e)
        {
            PersonDetails frmPersonDetails =
                new PersonDetails((int)dgvDrivers.CurrentRow.Cells[1].Value);
            frmPersonDetails.ShowDialog();

            ListDrivers_Load(null, null);
        }

        private void tsmiIssueInternationalLicense_Click(object sender, EventArgs e)
        {

        }

        private void ShowPersonLicenseHistory_Click(object sender, EventArgs e)
        {
            LicensesHistory frmLicenseHistory = 
                new LicensesHistory((int)dgvDrivers.CurrentRow.Cells[1].Value);
            frmLicenseHistory.ShowDialog();

            ListDrivers_Load(null, null);
        }
    }
}
