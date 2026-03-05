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
using static DVLD_BusinessLogicLayer_BLL_.Licenses.clsLicenses;
using DVLD_PresentationLayer_PL_.Global;
using DVLD_BusinessLogicLayer_BLL_.Licenses;

namespace DVLD_PresentationLayer_PL_.Licenses
{
    public partial class ReplacementForDamagedLicense : Form
    {
        private int _NewLicenseID = -1;
        public ReplacementForDamagedLicense()
        {
            InitializeComponent();
        }

        private int _GetApplicationTypeID()
        {
            if (rbDamaged.Checked)
                return (int)clsApplications.enApplicationType.ReplacementForDamaged;

            else
                return (int)clsApplications.enApplicationType.ReplacementForLost;
        }

        private enIssueReason _GetIssueReason()
        {
            if (rbDamaged.Checked)
                return enIssueReason.ReplaceForDamaged;
            else
                return enIssueReason.ReplaceForLost;
        }
        private void ReplacementForDamagedLicense_Load(object sender, EventArgs e)
        {
            lblAppDate.Text = clsFormat.DateToShort(DateTime.Now);
            lblCreatedBy.Text = clsGlobal.CurrentUser.Username;

            rbDamaged.Checked = true;
        }

        private void cntrlLicenseInfoWithFilter1_OnFillLicense(int obj)
        {
            int SelectedLicenseID = obj;
            lblOldLicenseID.Text = SelectedLicenseID.ToString();
            llblShowLicenseHistory.Enabled = (SelectedLicenseID != -1);

            if (SelectedLicenseID == -1)
            return;


            if (!cntrlLicenseInfoWithFilter1.SelectedLicenseInfo.IsActive)
            {
                MessageBox.Show("Selected License is Not Active, Choose an Active License.",
                    "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnIssueReplacement.Enabled = false;
                return;
            }

            if (cntrlLicenseInfoWithFilter1.SelectedLicenseInfo.IsDetained)
            {
                MessageBox.Show("Selected License is Detained, Cannot Replaced it, Please Contact Support For Assistance.",
                    "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnIssueReplacement.Enabled = false;
                return;
            }


            btnIssueReplacement.Enabled = true;
        }

        private void btnIssueReplacement_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Issue a Replacement For The License?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;


            clsLicenses NewLicense = 
                cntrlLicenseInfoWithFilter1.SelectedLicenseInfo.ReplaceLicense(_GetIssueReason(), clsGlobal.CurrentUser.UserID);

            if (NewLicense == null)
            {
                MessageBox.Show("Faild To Issue a Replacement For This License", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblLRAppID.Text = NewLicense.ApplicationID.ToString();
            _NewLicenseID = NewLicense.LicenseID;
            lblRepLicenseID.Text = _NewLicenseID.ToString();
            
            MessageBox.Show($"License Replaced Successfully With ID: {_NewLicenseID}",
                          "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
            llblShowNewLicenseInfo.Enabled = true;
            btnIssueReplacement.Enabled = false;
            cntrlLicenseInfoWithFilter1.FilterEnabled = false;
            gbReplacement.Enabled = false;
        }

        private void llblShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LicensesHistory frmLicensesHistory = 
                new LicensesHistory(cntrlLicenseInfoWithFilter1.SelectedLicenseInfo.DriverInfo.PersonID);
            frmLicensesHistory.ShowDialog();
        }

        private void llblShowNewLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
            LicenseInfo frmLicenseInfo = 
                new LicenseInfo(_NewLicenseID);
            frmLicenseInfo.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbDamaged_CheckedChanged(object sender, EventArgs e)
        {
            lblTitle.Text = "Replacement For Damaged License";
            this.Text = lblTitle.Text;
            lblAppFees.Text = clsApplicationTypes.Find(_GetApplicationTypeID()).Fees.ToString("0");
        }

        private void rbLost_CheckedChanged(object sender, EventArgs e)
        {
            lblTitle.Text = "Replacement For Lost License";
            this.Text = lblTitle.Text;
            lblAppFees.Text = clsApplicationTypes.Find(_GetApplicationTypeID()).Fees.ToString("0");
        }

        private void ReplacementForDamagedLicense_Activated(object sender, EventArgs e)
        {
            cntrlLicenseInfoWithFilter1.txtLicenseIDFocus();
        }
    }
}
