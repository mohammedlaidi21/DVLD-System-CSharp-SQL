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
using DVLD_BusinessLogicLayer_BLL_.Applications;
using DVLD_BusinessLogicLayer_BLL_.Licenses;
using DVLD_BusinessLogicLayer_BLL_.LocalDrivingLicenseApplication;
using DVLD_PresentationLayer_PL_.Licenses;

namespace DVLD_PresentationLayer_PL_.Detain_Release_Licenses
{
    public partial class ListDetainedLicenses : Form
    {
        private DataTable _dtAllDetainLicenses;
        public ListDetainedLicenses()
        {
            InitializeComponent();
        }

        private void ListDetainedLicenses_Load(object sender, EventArgs e)
        {
            _dtAllDetainLicenses = clsDetainedLicenses.GetAllDetainLicenses();
            dgvListDetainedLicenses.DataSource = _dtAllDetainLicenses;
            cbDetainedLicense.SelectedIndex = 0;

            lblCount.Text = dgvListDetainedLicenses.Rows.Count.ToString();

            if (dgvListDetainedLicenses.Rows.Count > 0)
            {
                dgvListDetainedLicenses.Columns[0].HeaderText = "D.ID";
                dgvListDetainedLicenses.Columns[0].Width = 90;
            
                dgvListDetainedLicenses.Columns[1].HeaderText = "L.ID";
                dgvListDetainedLicenses.Columns[1].Width = 90;
            
                dgvListDetainedLicenses.Columns[2].HeaderText = "D.Date";
                dgvListDetainedLicenses.Columns[2].Width = 160;
            
                dgvListDetainedLicenses.Columns[3].HeaderText = "Is Released";
                dgvListDetainedLicenses.Columns[3].Width = 110;
            
                dgvListDetainedLicenses.Columns[4].HeaderText = "Fine Fees";
                dgvListDetainedLicenses.Columns[4].Width = 110;
            
                dgvListDetainedLicenses.Columns[5].HeaderText = "Reease Date";
                dgvListDetainedLicenses.Columns[5].Width = 160;
            
                dgvListDetainedLicenses.Columns[6].HeaderText = "N.No";
                dgvListDetainedLicenses.Columns[6].Width = 90;
            
                dgvListDetainedLicenses.Columns[7].HeaderText = "Full Name";
                dgvListDetainedLicenses.Columns[7].Width = 330;
           
                dgvListDetainedLicenses.Columns[8].HeaderText = "Rlease App.ID";
                dgvListDetainedLicenses.Columns[8].Width = 150;
            }
        }

        private void btnDetain_Click(object sender, EventArgs e)
        {
            DetainLicense frmDetainLicense = new DetainLicense();
            //frmDetainLicense._LoadData += _LoadDetainedLicensesInDataView;
            frmDetainLicense.ShowDialog();

            ListDetainedLicenses_Load(null, null);
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            ReleaseDetainedLicense frmReleaseDetainedLicense = 
                new ReleaseDetainedLicense();
           // frmReleaseDetainedLicense._LoadData += _LoadDetainedLicensesInDataView;
            frmReleaseDetainedLicense.ShowDialog();

            ListDetainedLicenses_Load(null, null);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbDetainedLicense_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDetainedLicense.Text == "Is Released")
            {
                txtFilter.Visible = false;
                pYesNo.Visible = true;
                pYesNo.Focus();
                rbYes.Checked = true;
            }
            else
            {
                txtFilter.Visible = (cbDetainedLicense.Text != "None");
                pYesNo.Visible = false;

                txtFilter.Focus();
                txtFilter.Text = "";
            }

        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";

            switch (cbDetainedLicense.Text)
            {
                case "Detain ID":
                    FilterColumn = "DetainID";
                    break;
                case "National No":
                    FilterColumn = "NationalNo";
                    break;
                case "Full Name":
                    FilterColumn = "FullName";
                    break;
                case "Release Application ID":
                    FilterColumn = "ReleaseApplicationID";
                    break;
                default:
                    FilterColumn = "None";
                    break;
            }

            if (txtFilter.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtAllDetainLicenses.DefaultView.RowFilter = "";
                lblCount.Text = dgvListDetainedLicenses.Rows.Count.ToString();
                return;
            }

            if (FilterColumn != "DetainID" && FilterColumn != "ReleaseApplicationID")
                _dtAllDetainLicenses.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilter.Text.Trim());

            else
                _dtAllDetainLicenses.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilter.Text.Trim());

            lblCount.Text = dgvListDetainedLicenses.Rows.Count.ToString();
        }

        private void rbYesNo_CheckedChanged(object sender, EventArgs e)
        {
            string FilterCoulumn = "IsReleased";
            string FilterValue = "";

            if (rbYes.Checked)
                FilterValue = "1";
            else
                FilterValue = "0";

            dgvListDetainedLicenses.DataSource = string.Format("[{0}] = {1}", FilterCoulumn, FilterValue);

            lblCount.Text = dgvListDetainedLicenses.Rows.Count.ToString();

        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbDetainedLicense.Text == "Detain ID" || cbDetainedLicense.Text == "Release Application ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsLicenses License = clsLicenses.FindByLicenseID((int)dgvListDetainedLicenses.CurrentRow.Cells[1].Value);
            PersonDetails frmPersonDetails = new PersonDetails(License.DriverInfo.PersonID);
            frmPersonDetails.ShowDialog();
        }

        private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LicenseInfo frmLicenseInfo =
                new LicenseInfo((int)dgvListDetainedLicenses.CurrentRow.Cells[1].Value);
            frmLicenseInfo.ShowDialog();
        }

        private void showPersonHistoryLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsLicenses License = clsLicenses.FindByLicenseID((int)dgvListDetainedLicenses.CurrentRow.Cells[1].Value);
            LicensesHistory frmLicensesHistory =
                new LicensesHistory(License.DriverInfo.PersonID);
            frmLicensesHistory.ShowDialog();
        }

        private void releaseDetainedLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReleaseDetainedLicense frmeleaseDetainedLicense =
                new ReleaseDetainedLicense((int)dgvListDetainedLicenses.CurrentRow.Cells[1].Value);
            //frmeleaseDetainedLicense._LoadData += _LoadDetainedLicensesInDataView;
            frmeleaseDetainedLicense.ShowDialog();

            ListDetainedLicenses_Load(null, null);
        }

        private void cmsOperations_Opening(object sender, CancelEventArgs e)
        {
            releaseDetainedLicensesToolStripMenuItem.Enabled = !(bool)dgvListDetainedLicenses.CurrentRow.Cells[3].Value;
        }
    }
}
