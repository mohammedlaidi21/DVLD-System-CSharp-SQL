using System;
using System.Windows.Forms;
using DVLD_BusinessLogicLayer_BLL_;
using DVLD_PresentationLayer_PL_.Applications;
using DVLD_PresentationLayer_PL_.ApplicationTypes;
using DVLD_PresentationLayer_PL_.Detain_Release_Licenses;
using DVLD_PresentationLayer_PL_.Drivers;
using DVLD_PresentationLayer_PL_.Global;
using DVLD_PresentationLayer_PL_.InternationalLicenses;
using DVLD_PresentationLayer_PL_.Licenses;
using DVLD_PresentationLayer_PL_.LocalDrivingLicenseApplication;
using DVLD_PresentationLayer_PL_.TestTypes;
using DVLD_PresentationLayer_PL_.Users;

namespace DVLD_PresentationLayer_PL_
{
    public partial class frmMain : Form
    {
        Login _frmLogin;
        public frmMain(Login frmLogin)
        {
            InitializeComponent();

            _frmLogin = frmLogin;
        }

        ManagePeople frmManagePeople = new ManagePeople();
        private void tsmiPeople_Click_1(object sender, EventArgs e)
        {
            if (frmManagePeople.IsDisposed)
            {
                frmManagePeople = new ManagePeople();
            }
            frmManagePeople.MdiParent = this;
            frmManagePeople.Show();
        }

        ManageUsers frmManageUsers = new ManageUsers();
        private void tsmiUsers_Click(object sender, EventArgs e)
        {
            if (frmManageUsers.IsDisposed)
            {
                frmManageUsers = new ManageUsers();
            }

            frmManageUsers.MdiParent = this;
            frmManageUsers.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void SignOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsGlobal.CurrentUser = null;
            _frmLogin.Show();
            this.Close();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword ChangePasswordFrm = new ChangePassword(clsGlobal.CurrentUser.UserID);
            ChangePasswordFrm.ShowDialog();
        }

        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserDetails UserDetailsFrm = new UserDetails(clsGlobal.CurrentUser.UserID);
            UserDetailsFrm.ShowDialog();
        }

        private void tsmiApplications_Click(object sender, EventArgs e)
        {

        }

        ManageApplicationTypes frmManageApplicationTypes = new ManageApplicationTypes();

        private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmManageApplicationTypes.IsDisposed)
            {
                frmManageApplicationTypes = new ManageApplicationTypes();
            }
            frmManageApplicationTypes.MdiParent = this;
            frmManageApplicationTypes.Show();
        }

        ManageTestTypes frmManageTestTypes = new ManageTestTypes();
        private void manageTypeTestsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmManageTestTypes.IsDisposed)
            {
                frmManageTestTypes = new ManageTestTypes();
            }

            frmManageTestTypes.MdiParent = this;
            frmManageTestTypes.Show();
        }

        NewLocalDrivingLicenseApplication frmNewLocalDrivingLicenseApplication = new NewLocalDrivingLicenseApplication(-1);
        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmNewLocalDrivingLicenseApplication.IsDisposed)
            {
                frmNewLocalDrivingLicenseApplication = new NewLocalDrivingLicenseApplication(-1);
            }

            frmNewLocalDrivingLicenseApplication.MdiParent = this;
            frmNewLocalDrivingLicenseApplication.Show();
        }

        LocalDrivingLicenseApplications frmLoLocalDrivingLicenseApplications = new LocalDrivingLicenseApplications();
        private void localDrivingLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmLoLocalDrivingLicenseApplications.IsDisposed)
            {
                frmLoLocalDrivingLicenseApplications = new LocalDrivingLicenseApplications();
            }

            frmLoLocalDrivingLicenseApplications.MdiParent = this;
            frmLoLocalDrivingLicenseApplications.Show();
        }

        ListDrivers frmListDrivers = new ListDrivers();
        private void tsmiDrivers_Click(object sender, EventArgs e)
        {
            
            if(frmListDrivers.IsDisposed)
            {
                frmListDrivers = new ListDrivers();
            }

            frmListDrivers.MdiParent = this;
            frmListDrivers.Show();
        }

        NewInternationalLicenseApplication frmNewInternationalLicenseApplication
               = new NewInternationalLicenseApplication();
        private void internationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmNewInternationalLicenseApplication.IsDisposed)
            {
                frmNewInternationalLicenseApplication = new NewInternationalLicenseApplication();
            }

            frmNewInternationalLicenseApplication.MdiParent = this;
            frmNewInternationalLicenseApplication.Show();
        }

        ListInternationalLicenseApplications frmListInternationalLicenseApplications
              = new ListInternationalLicenseApplications();
        private void internationalLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmListInternationalLicenseApplications.IsDisposed)
            {
                frmListInternationalLicenseApplications = new ListInternationalLicenseApplications();
            }
            frmListInternationalLicenseApplications.MdiParent = this;
            frmListInternationalLicenseApplications.Show();
        }

        RenewLocalDrivingLicense frmRenewLocalDrivingLicense = new RenewLocalDrivingLicense();
        private void renewDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmRenewLocalDrivingLicense.IsDisposed)
            {
                frmRenewLocalDrivingLicense = new RenewLocalDrivingLicense();
            }

            frmRenewLocalDrivingLicense.MdiParent = this;
            frmRenewLocalDrivingLicense.Show();
        }

        ReplacementForDamagedLicense frmReplacementForDamagedLicense =
               new ReplacementForDamagedLicense();
        private void replacementForDamagedOrLostLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmReplacementForDamagedLicense.IsDisposed)
            {
                frmReplacementForDamagedLicense = new ReplacementForDamagedLicense();
                //frmReplacementForDamagedLicense.Text = frmReplacementForDamagedLicense.Title;
            }
            frmReplacementForDamagedLicense.MdiParent = this;
            frmReplacementForDamagedLicense.Show();
        }

        DetainLicense frmDetainLicense = new DetainLicense();
        private void detainLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmDetainLicense.IsDisposed)
            {
                frmDetainLicense = new DetainLicense();
            }

            frmDetainLicense.MdiParent = this;
            frmDetainLicense.Show();
        }

        LocalDrivingLicenseApplications frmLocalDrivingLicenseApplications
               = new LocalDrivingLicenseApplications();
        private void retakeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmLocalDrivingLicenseApplications.IsDisposed)
            {
                frmLocalDrivingLicenseApplications = new LocalDrivingLicenseApplications();
            }
            frmLocalDrivingLicenseApplications.MdiParent = this;
            frmLocalDrivingLicenseApplications.Show();
        }

        ReleaseDetainedLicense frmReleaseDetainedLicense = new ReleaseDetainedLicense();
        private void releaseDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmReleaseDetainedLicense.IsDisposed)
            {
                frmReleaseDetainedLicense = new ReleaseDetainedLicense();
            }
            frmReleaseDetainedLicense.MdiParent = this;
            frmReleaseDetainedLicense.Show();
        }
        ListDetainedLicenses frmListDetainedLicenses = new ListDetainedLicenses();

        private void manageDetainedLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmListDetainedLicenses.IsDisposed)
            {
                frmListDetainedLicenses = new ListDetainedLicenses();
            }
            frmListDetainedLicenses.MdiParent = this;
            frmListDetainedLicenses.Show();
        }


        private void relaeseDetainedDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmReleaseDetainedLicense.IsDisposed)
            {
                frmReleaseDetainedLicense = new ReleaseDetainedLicense();
            }
            frmReleaseDetainedLicense.MdiParent = this;
            frmReleaseDetainedLicense.Show();
        }
    }
}
