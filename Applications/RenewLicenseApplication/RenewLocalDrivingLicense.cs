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
using DVLD_BusinessLogicLayer_BLL_.LicenseClasses;
using DVLD_BusinessLogicLayer_BLL_.Licenses;
using DVLD_BusinessLogicLayer_BLL_.LocalDrivingLicenseApplication;
using DVLD_PresentationLayer_PL_.Global;

namespace DVLD_PresentationLayer_PL_.Licenses
{
    public partial class RenewLocalDrivingLicense : Form
    {
        private int _NewLicenseID = -1;
        public RenewLocalDrivingLicense()
        {
            InitializeComponent();
        }

        private void RenewLocalDrivingLicense_Load(object sender, EventArgs e)
        {
            cntrlLicenseInfoWithFilter1.txtLicenseIDFocus();

            lblAppDate.Text = clsFormat.DateToShort(DateTime.Now);
            lblIssueDate.Text = lblAppDate.Text;

            lblExpDate.Text = "???";
            lblApplicationFees.Text = clsApplicationTypes.Find((int)clsApplications.enApplicationType.RenewDrivingLicense).Fees.ToString("0");
            lblCreatedBy.Text = clsGlobal.CurrentUser.Username.ToString();
        }

        private void llblShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int LDLAppID = clsLocalDrivingLicenseApp.FindByApplicationID(cntrlLicenseInfoWithFilter1.SelectedLicenseInfo.ApplicationID).LocalDrivingLicenseAppID;
            LicensesHistory frmLicensesHistory = new LicensesHistory(cntrlLicenseInfoWithFilter1.SelectedLicenseInfo.DriverInfo.PersonID);
            frmLicensesHistory.ShowDialog();
        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure you Want To Renew The License?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            clsLicenses NewLicense = 
                cntrlLicenseInfoWithFilter1.SelectedLicenseInfo.RenewLicense(clsGlobal.CurrentUser.UserID, txtNotes.Text.Trim());

            if (NewLicense == null)
            {
                MessageBox.Show("Cannot Renewed This License Because It's Not Active", "Not Allowed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _NewLicenseID = NewLicense.LicenseID;
            lblRenewLicID.Text = _NewLicenseID.ToString();
            lblRenewLicAppID.Text = NewLicense.ApplicationID.ToString();
            MessageBox.Show("License Renew Successfully With ID: " + _NewLicenseID, "Renew", MessageBoxButtons.OK, MessageBoxIcon.Information);

            llblShowNewLicenseInfo.Enabled = true;
            cntrlLicenseInfoWithFilter1.FilterEnabled = false;
            btnRenew.Enabled = false;
        }

        private void llblShowNewLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LicenseInfo frmLicenseInfo = new LicenseInfo(_NewLicenseID);
            frmLicenseInfo.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RenewLocalDrivingLicense_Activated(object sender, EventArgs e)
        {
            cntrlLicenseInfoWithFilter1.txtLicenseIDFocus();
        }

        

        private void cntrlLicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {
            int SelectedLicenseID = obj;

            lblOldLicID.Text = SelectedLicenseID.ToString();

            llblShowLicenseHistory.Enabled = (SelectedLicenseID != -1);

            if (SelectedLicenseID == -1)
                return;



            lblLicenseFees.Text = cntrlLicenseInfoWithFilter1.SelectedLicenseInfo.LicenseClassInfo.ClassFees.ToString("0");

            int DefaultValidityLength = cntrlLicenseInfoWithFilter1.SelectedLicenseInfo.LicenseClassInfo.DefaultValidityLength;
            lblExpDate.Text = clsFormat.DateToShort(DateTime.Now.AddYears(DefaultValidityLength));
            lblTotalFees.Text = (Convert.ToDecimal(lblLicenseFees.Text) + Convert.ToDecimal(lblApplicationFees.Text)).ToString("0");
            txtNotes.Text = cntrlLicenseInfoWithFilter1.SelectedLicenseInfo.Notes;

            if (!cntrlLicenseInfoWithFilter1.SelectedLicenseInfo.IsExpiredLicense())
            {
                MessageBox.Show($"Selected License is Not Yet Expiared, it Will Expire On: {clsFormat.DateToShort(cntrlLicenseInfoWithFilter1.SelectedLicenseInfo.ExpirationDate)}",
                       "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnRenew.Enabled = false;
                return;
            }

            if (!cntrlLicenseInfoWithFilter1.SelectedLicenseInfo.IsActive)
            {
                MessageBox.Show($"Selected License is Not Active, Chooce An Active License!",
                       "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnRenew.Enabled = false;
                return;
            }

            btnRenew.Enabled = true;
        }
    }
}
