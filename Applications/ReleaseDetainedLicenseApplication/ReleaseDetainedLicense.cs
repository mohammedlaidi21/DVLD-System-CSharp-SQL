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
using DVLD_PresentationLayer_PL_.Global;
using DVLD_PresentationLayer_PL_.Licenses;

namespace DVLD_PresentationLayer_PL_.Detain_Release_Licenses
{
    public partial class ReleaseDetainedLicense : Form
    {
        private int _SelectedLicenseID = -1;

        public ReleaseDetainedLicense()
        {
            InitializeComponent();
        }

        public ReleaseDetainedLicense(int LicenseID)
        {
            InitializeComponent();

            _SelectedLicenseID = LicenseID;

            cntrlLicenseInfoWithFilter1.LoadLicenseInfo(_SelectedLicenseID);
            cntrlLicenseInfoWithFilter1.FilterEnabled = false;
        }

        private void cntrlLicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {
            _SelectedLicenseID = obj;

            llblShowLicenseHistory.Enabled = (_SelectedLicenseID != -1);

            if (_SelectedLicenseID == -1)
            {
                return;
            }

            lblLicenseID.Text = _SelectedLicenseID.ToString();
            
            if (!cntrlLicenseInfoWithFilter1.SelectedLicenseInfo.IsDetained)
            {
                MessageBox.Show("Selected License Is Not Detain, Chooce a Detained License", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblDetainID.Text = cntrlLicenseInfoWithFilter1.SelectedLicenseInfo.DetainedLicenseInfo.DetainID.ToString();
            lblDetainDate.Text = clsFormat.DateToShort(cntrlLicenseInfoWithFilter1.SelectedLicenseInfo.DetainedLicenseInfo.DetainDate);
            lblAppFees.Text = clsApplicationTypes.Find((int)clsApplications.enApplicationType.ReleaseDetaindDrivingLicense).Fees.ToString("0");
            lblLicenseID.Text = cntrlLicenseInfoWithFilter1.SelectedLicenseInfo.LicenseID.ToString();
            lblCreatedBy.Text = cntrlLicenseInfoWithFilter1.SelectedLicenseInfo.DetainedLicenseInfo.CreatedByUserInfo.Username;
            lblFineFees.Text = cntrlLicenseInfoWithFilter1.SelectedLicenseInfo.DetainedLicenseInfo.FineFees.ToString("0");
            lblTotalFees.Text = (Convert.ToDecimal(lblAppFees.Text) + Convert.ToDecimal(lblFineFees.Text)).ToString("0");
            btnRelease.Enabled = true;
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Release This Detained License?", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.No)
                return;


            int ApplicationID = -1;

            bool IsReleased = cntrlLicenseInfoWithFilter1.SelectedLicenseInfo.ReleaseDetainedLicense(clsGlobal.CurrentUser.UserID, ref ApplicationID);

            if (!IsReleased)
            {
                MessageBox.Show("Faild To Release The Detained License", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblReleaseAppID.Text = ApplicationID.ToString();
            MessageBox.Show("Detained License Released Successfully!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnRelease.Enabled = false;
            cntrlLicenseInfoWithFilter1.FilterEnabled = false;
            llblShowNewLicenseInfo.Enabled = true;
        }

        private void llblShowNewLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LicenseInfo frmLicenseInfo =
                new LicenseInfo(_SelectedLicenseID);
            frmLicenseInfo.ShowDialog();
        }

        private void llblShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LicensesHistory frmLicenseHistory =
                new LicensesHistory(cntrlLicenseInfoWithFilter1.SelectedLicenseInfo.DriverInfo.PersonID);
            frmLicenseHistory.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReleaseDetainedLicense_Activated(object sender, EventArgs e)
        {
            cntrlLicenseInfoWithFilter1.txtLicenseIDFocus();
        }
    }
}
