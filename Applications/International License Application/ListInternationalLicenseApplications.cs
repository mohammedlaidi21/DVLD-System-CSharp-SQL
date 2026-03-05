using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_BusinessLogicLayer_BLL_.Applications;
using DVLD_BusinessLogicLayer_BLL_.Drivers;
using DVLD_BusinessLogicLayer_BLL_.InternationalLicenses;
using DVLD_BusinessLogicLayer_BLL_.Licenses;
using DVLD_BusinessLogicLayer_BLL_.LocalDrivingLicenseApplication;
using DVLD_PresentationLayer_PL_.Licenses;

namespace DVLD_PresentationLayer_PL_.InternationalLicenses
{
    public partial class ListInternationalLicenseApplications : Form
    {
        private DataTable _dtAllInternationalLicenses;
        public ListInternationalLicenseApplications()
        {
            InitializeComponent();
        }
        private void ListInternationalLicenseApplications_Load(object sender, EventArgs e)
        {
            cbFilterItems.SelectedIndex = 0;
            _dtAllInternationalLicenses = clsInternationalLicenses.GetAllInternationalLicenses();
            dgvInternationalApplications.DataSource = _dtAllInternationalLicenses;

            lblCountApplications.Text = dgvInternationalApplications.Rows.Count.ToString();

            if (dgvInternationalApplications.Rows.Count > 0)
            {
                dgvInternationalApplications.Columns[0].HeaderText = "Int.License ID";
                dgvInternationalApplications.Columns[0].Width = 160;
            
                dgvInternationalApplications.Columns[1].HeaderText = "Application ID";
                dgvInternationalApplications.Columns[1].Width = 150;
            
                dgvInternationalApplications.Columns[2].HeaderText = "Driver ID";
                dgvInternationalApplications.Columns[2].Width = 130;
            
                dgvInternationalApplications.Columns[3].HeaderText = "L.License ID";
                dgvInternationalApplications.Columns[3].Width = 130;
            
                dgvInternationalApplications.Columns[4].HeaderText = "Issue Date";
                dgvInternationalApplications.Columns[4].Width = 180;
            
                dgvInternationalApplications.Columns[5].HeaderText = "Expiration Date";
                dgvInternationalApplications.Columns[5].Width = 180;
            
                dgvInternationalApplications.Columns[6].HeaderText = "Is Active";
                dgvInternationalApplications.Columns[6].Width = 120;
            }
        }

        private void btnAddNewApplication_Click(object sender, EventArgs e)
        {
            NewInternationalLicenseApplication frmNewInternationalLicenseApplication
                = new NewInternationalLicenseApplication();
            //frmNewInternationalLicenseApplication.OnLoadData += _LoadInternationalLicensesInDataView;
            frmNewInternationalLicenseApplication.ShowDialog();

            ListInternationalLicenseApplications_Load(null, null);
        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = clsDrivers.FindByDriverID((int)dgvInternationalApplications.CurrentRow.Cells[2].Value).PersonID;

            PersonDetails frmPersonDetails = new PersonDetails(PersonID);
            frmPersonDetails.ShowDialog();
        }

        private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            International_Driver_Info frmInternationalLicenseInfo =
                new International_Driver_Info((int)dgvInternationalApplications.CurrentRow.Cells[0].Value);
            frmInternationalLicenseInfo.ShowDialog();
        }

        private void showLicensePersonHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = clsDrivers.FindByDriverID((int)dgvInternationalApplications.CurrentRow.Cells[2].Value).PersonID;
            LicensesHistory frmLicensesHistory =
                new LicensesHistory(PersonID);
            frmLicensesHistory.ShowDialog();
        }

        private void cbFilterItems_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbFilterItems.Text == "Is Active")
            {
                txtFilter.Visible = false;
                cbIsActive.Visible = true;

                cbIsActive.SelectedIndex = 0;
                cbIsActive.Focus();
            }
            else
            {
                txtFilter.Visible = (cbFilterItems.Text != "None");
                cbIsActive.Visible = false;
                txtFilter.Focus();
                txtFilter.Text = "";
            }

           
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";

            switch (cbFilterItems.Text)
            {
                case "International License ID":
                        FilterColumn = "InternationalLicenseID";
                        break;

                case "Application ID":
                        FilterColumn = "ApplicationID";
                        break;

                case "Driver ID":
                        FilterColumn = "DriverID";
                        break;

                case "License ID":
                        FilterColumn = "IssuedUsingLicenseID";
                        break;

                default:
                    FilterColumn = "None";
                    break;
            }


            if (txtFilter.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtAllInternationalLicenses.DefaultView.RowFilter = "";
                lblCountApplications.Text = dgvInternationalApplications.Rows.Count.ToString();
                return;
            }

            _dtAllInternationalLicenses.DefaultView.RowFilter =
                string.Format("[{0}] = {1}", FilterColumn, txtFilter.Text.Trim());

            lblCountApplications.Text = dgvInternationalApplications.Rows.Count.ToString();
        }

        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColumn = "IsActive";
            string FilterValue = cbIsActive.Text;

            switch (FilterValue)
            {
                case "All":
                    break;
                case "Yes":
                    FilterValue = "1";
                    break;
                case "No":
                    FilterValue = "2";
                    break;
            }

            if (FilterValue == "All")
                _dtAllInternationalLicenses.DefaultView.RowFilter = "";
            else
                _dtAllInternationalLicenses.DefaultView.RowFilter =
                    string.Format("[{0}] = {1}", FilterColumn, FilterValue);

            lblCountApplications.Text = _dtAllInternationalLicenses.Rows.Count.ToString();

        }
    }
}
