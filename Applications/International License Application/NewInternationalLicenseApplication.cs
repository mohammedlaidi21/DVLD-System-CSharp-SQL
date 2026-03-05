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
using DVLD_BusinessLogicLayer_BLL_.Drivers;
using DVLD_BusinessLogicLayer_BLL_.InternationalLicenses;
using DVLD_BusinessLogicLayer_BLL_.Licenses;
using DVLD_BusinessLogicLayer_BLL_.LocalDrivingLicenseApplication;
using DVLD_PresentationLayer_PL_.Global;
using DVLD_PresentationLayer_PL_.Licenses;

namespace DVLD_PresentationLayer_PL_.InternationalLicenses
{
    public partial class NewInternationalLicenseApplication : Form
    {
        private int _InternationalLicenseID = -1;

        public delegate void DelegLoadData();
        public event DelegLoadData OnLoadData;
        public NewInternationalLicenseApplication()
        {
            InitializeComponent();
        }

        private void NewInternationalLicenseApplication_Load(object sender, EventArgs e)
        {
            
            lblAppDate.Text = clsFormat.DateToShort(DateTime.Now);
            lblIssueDate.Text = lblAppDate.Text;
            lblExpirationDate.Text = clsFormat.DateToShort(DateTime.Now.AddYears(1));
            lblFees.Text = clsApplicationTypes.Find((int)clsApplications.enApplicationType.NewInternationalLicense).Fees.ToString("0"); // 6 is New International License Application
            lblCreatedBy.Text = clsGlobal.CurrentUser.Username;
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Issue This License?", "Confirm",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            clsInternationalLicenses InternationalLicenses = new clsInternationalLicenses();

            InternationalLicenses.ApplicantPersonID = cntrlLicenseInfoWithFilter1.SelectedLicenseInfo.DriverInfo.PersonID;
            InternationalLicenses.ApplicationDate = DateTime.Now;
            InternationalLicenses.ApplicationTypeID = (int)clsApplications.enApplicationType.NewInternationalLicense; //6 is interntinal license application ID
            InternationalLicenses.ApplicationStatus = clsApplications.enStatus.Completed;
            InternationalLicenses.LastStatusDate = DateTime.Now;
            InternationalLicenses.PaidFees = clsApplicationTypes.Find(InternationalLicenses.ApplicationTypeID).Fees;
            InternationalLicenses.CreatedByUserID = clsGlobal.CurrentUser.UserID;

            InternationalLicenses.DriverID = cntrlLicenseInfoWithFilter1.SelectedLicenseInfo.DriverID;
            InternationalLicenses.IssuedUsingLocalLicenseID = cntrlLicenseInfoWithFilter1.SelectedLicenseInfo.LicenseID;
            InternationalLicenses.IssueDate = DateTime.Now;
            InternationalLicenses.ExpirationDate = DateTime.Now.AddYears(1);
            InternationalLicenses.IsActive = true;
            InternationalLicenses.CreatedByUserID = clsGlobal.CurrentUser.UserID;



            if (!InternationalLicenses.Save())
            {
                MessageBox.Show("Faild To Issue International License", "Error",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            lblILAppID.Text = InternationalLicenses.ApplicationID.ToString();
            _InternationalLicenseID = InternationalLicenses.InternationalLicenseID;
            lblILicenseID.Text = _InternationalLicenseID.ToString();


            MessageBox.Show($"International License Issued Successfully With ID = {InternationalLicenses.InternationalLicenseID}",
                "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);

            llblShowLicenseInfo.Enabled = true;
            btnIssue.Enabled = false;
            cntrlLicenseInfoWithFilter1.FilterEnabled = false;
        }

        private void cntrlLicenseInfoWithFilter1_OnFillLicense_1(int obj)
        {
            int SelectedLicenseID = obj;

            llblShowLicenseHistory.Enabled = (SelectedLicenseID != -1);

            if (SelectedLicenseID == -1)
                return;

            lblLocalLicenseID.Text = SelectedLicenseID.ToString();

            if (cntrlLicenseInfoWithFilter1.SelectedLicenseInfo.LicenseClassID != 3)
            {
                MessageBox.Show("Selected License Should Be Class 3!, Select Another One", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int ActiveInternationalLicenseID = clsInternationalLicenses.GetActiveInternationalLicenseIDByDriverID(cntrlLicenseInfoWithFilter1.SelectedLicenseInfo.DriverID);

            if (ActiveInternationalLicenseID != -1)
            {
                MessageBox.Show($"Person Already Has an Active International License With ID = {ActiveInternationalLicenseID}",
                    "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                llblShowLicenseInfo.Enabled = true;
                btnIssue.Enabled = false;
                _InternationalLicenseID = ActiveInternationalLicenseID;
                return;
            }

            btnIssue.Enabled = true;
        }

        private void llblShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LicensesHistory frmLicensesHistory = 
                new LicensesHistory(cntrlLicenseInfoWithFilter1.SelectedLicenseInfo.DriverInfo.PersonID);
            frmLicensesHistory.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            OnLoadData?.Invoke();
            this.Close();
        }

        private void llblShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            International_Driver_Info frmInternational_Driver_Info =
                new International_Driver_Info(_InternationalLicenseID);

            frmInternational_Driver_Info.ShowDialog();
        }

        private void NewInternationalLicenseApplication_Activated(object sender, EventArgs e)
        {
            cntrlLicenseInfoWithFilter1.txtLicenseIDFocus();
        }
    }
}
