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
using DVLD_BusinessLogicLayer_BLL_.LicenseClasses;
using DVLD_BusinessLogicLayer_BLL_.Licenses;
using DVLD_BusinessLogicLayer_BLL_.LocalDrivingLicenseApplication;
using DVLD_PresentationLayer_PL_.Global;

namespace DVLD_PresentationLayer_PL_.Licenses
{
    public partial class IssueDriverLicenseForTheFirstTime : Form
    {
        private int _LocalDrivingLicenseAppID = -1;
        private clsLocalDrivingLicenseApp _LocalDrivingLicenseApplication;

        public delegate void DelegLoadData();
        public event DelegLoadData OnLoadData;
        public IssueDriverLicenseForTheFirstTime(int LocalDrivingLicenseAppID)
        {
            InitializeComponent();
            _LocalDrivingLicenseAppID = LocalDrivingLicenseAppID;
        }

        private void IssueDriverLicenseForTheFirstTime_Load(object sender, EventArgs e)
        {
            txtNotes.Focus();
            _LocalDrivingLicenseApplication = 
                clsLocalDrivingLicenseApp.FindByLocalDrivingLicenseAppID(_LocalDrivingLicenseAppID);

            if (_LocalDrivingLicenseApplication == null)
            {
                MessageBox.Show("No Local Driving Application With ID: " + _LocalDrivingLicenseAppID,
                    "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            if (!_LocalDrivingLicenseApplication.PassedAllTests())
            {
                MessageBox.Show("You Should Pass All Tests First",
                   "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            int LicenseID = _LocalDrivingLicenseApplication.GetActiveLicenseIDByPersonID();

            if (LicenseID != -1)
            {
                MessageBox.Show("The Perso Already Has An Active License",
                   "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

          

            cntrlVisionTestAppointments1.LoadLocalDrivingLicenseApplicationByLocalDrivingLicenseApplicationID(_LocalDrivingLicenseAppID);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int LicenseID = _LocalDrivingLicenseApplication.IssueLicenseFirstTime(txtNotes.Text.Trim(), clsGlobal.CurrentUser.UserID);

            if (LicenseID != -1)
            {
                MessageBox.Show("License Issued Successfully With License ID: " + LicenseID,
                    "Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong To Issue License",
                    "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
