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
using DVLD_BusinessLogicLayer_BLL_.LicenseClasses;
using DVLD_BusinessLogicLayer_BLL_.Licenses;
using DVLD_BusinessLogicLayer_BLL_.LocalDrivingLicenseApplication;
using DVLD_BusinessLogicLayer_BLL_.Test_Types;
using DVLD_PresentationLayer_PL_.Applications.LocalDrivingLicenseApplication;
using DVLD_PresentationLayer_PL_.Licenses;
using DVLD_PresentationLayer_PL_.LocalDrivingLicenseApplication;
using DVLD_PresentationLayer_PL_.Test_Appointments;

namespace DVLD_PresentationLayer_PL_.Applications
{
    public partial class LocalDrivingLicenseApplications : Form
    {
        private DataTable _dtAllLocalDrivingLicenseApplications;
        //internal enum enTestType { eVisionTest = 1, eWrittenTest = 2, eStreetTest = 3 };
        private clsTestTypes.enTestType _TestType = clsTestTypes.enTestType.VisionTest;


        public LocalDrivingLicenseApplications()
        {
            InitializeComponent();
        }

        private void LocalDrivingLicenseApplications_Load(object sender, EventArgs e)
        {
            _dtAllLocalDrivingLicenseApplications = clsLocalDrivingLicenseApp.GetAllLocalDrivingLicenseApplications();
            dgvLocalDrivingLicenseApp.DataSource = _dtAllLocalDrivingLicenseApplications;

            cbFilterBy.SelectedIndex = 0;

            lblCountLDLApp.Text = dgvLocalDrivingLicenseApp.Rows.Count.ToString();

            if (dgvLocalDrivingLicenseApp.Rows.Count > 0)
            {
                dgvLocalDrivingLicenseApp.Columns[0].HeaderText = "L.D.LAppID";
                dgvLocalDrivingLicenseApp.Columns[0].Width = 120;

                dgvLocalDrivingLicenseApp.Columns[1].HeaderText = "Driving Class";
                dgvLocalDrivingLicenseApp.Columns[1].Width = 300;

                dgvLocalDrivingLicenseApp.Columns[2].HeaderText = "National No.";
                dgvLocalDrivingLicenseApp.Columns[2].Width = 150;

                dgvLocalDrivingLicenseApp.Columns[3].HeaderText = "Full Name";
                dgvLocalDrivingLicenseApp.Columns[3].Width = 350;

                dgvLocalDrivingLicenseApp.Columns[4].HeaderText = "Application Date";
                dgvLocalDrivingLicenseApp.Columns[4].Width = 170;

                dgvLocalDrivingLicenseApp.Columns[5].HeaderText = "Passed Test";
                dgvLocalDrivingLicenseApp.Columns[5].Width = 150;

                dgvLocalDrivingLicenseApp.Columns[6].HeaderText = "Status";
                dgvLocalDrivingLicenseApp.Columns[6].Width = 150;
            }

        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilter.Visible = (cbFilterBy.Text != "None");

            if (txtFilter.Visible)
            {
                txtFilter.Text = "";
                txtFilter.Focus();
            }

            _dtAllLocalDrivingLicenseApplications.DefaultView.RowFilter = "";
            lblCountLDLApp.Text = dgvLocalDrivingLicenseApp.Rows.Count.ToString();
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "L.D.L.AppID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            switch (cbFilterBy.Text)
            {
                case "L.D.L.AppID":
                    FilterColumn = "LocalDrivingLicenseApplicationID";
                    break;
                case "National No":
                    FilterColumn = "NationalNo";
                    break;
                case "Full Name":
                    FilterColumn = "FullName";
                    break;
                case "Status":
                    FilterColumn = "Status";
                    break;
                default:
                    FilterColumn = "None";
                    break;
            }

            if (txtFilter.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtAllLocalDrivingLicenseApplications.DefaultView.RowFilter = "";
                lblCountLDLApp.Text = dgvLocalDrivingLicenseApp.Rows.Count.ToString();
                return;
            }

            if (FilterColumn != "LocalDrivingLicenseApplicationID")
                _dtAllLocalDrivingLicenseApplications.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilter.Text.Trim());

            else
                _dtAllLocalDrivingLicenseApplications.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilter.Text.Trim());

             lblCountLDLApp.Text = dgvLocalDrivingLicenseApp.Rows.Count.ToString();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            NewLocalDrivingLicenseApplication frmNewLocalDrivingLicenseApplication = new NewLocalDrivingLicenseApplication(-1);
            //frmNewLocalDrivingLicenseApplication.OnLoadData += _LoadDataInDataGridView;
            frmNewLocalDrivingLicenseApplication.ShowDialog();

            LocalDrivingLicenseApplications_Load(null, null);
        }

        private void cancToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure To Want Cancel This Application?",
                   "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            int LocalDrivingLicenseApplicationID = (int)dgvLocalDrivingLicenseApp.CurrentRow.Cells[0].Value;

            clsLocalDrivingLicenseApp LocalDrivingLicenseApplication = clsLocalDrivingLicenseApp.FindByLocalDrivingLicenseAppID(LocalDrivingLicenseApplicationID);

            if (LocalDrivingLicenseApplication != null)
            {
                if(LocalDrivingLicenseApplication.Cancel())
                {
                    MessageBox.Show("Application Cancelled Successfully!", "Success",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                    LocalDrivingLicenseApplications_Load(null, null);
                }
            }
            else
            {
                MessageBox.Show("Wrong To Cancelled Application!", "Faild",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cmsApplications_Opening(object sender, CancelEventArgs e)
        {
            clsLocalDrivingLicenseApp LocalDrivingLicenseApplication =
                clsLocalDrivingLicenseApp.FindByLocalDrivingLicenseAppID((int)dgvLocalDrivingLicenseApp.CurrentRow.Cells[0].Value);

            int PassedTestCount = (int)dgvLocalDrivingLicenseApp.CurrentRow.Cells[5].Value;

            bool LicenseExist = LocalDrivingLicenseApplication.IsLicenseIssued();

            tmsiIssueDrivingLicense.Enabled = (PassedTestCount == 3) && !LicenseExist;
            tmsiShowLicense.Enabled = LicenseExist;

            tmsiEditApp.Enabled = !LicenseExist && (LocalDrivingLicenseApplication.ApplicationStatus == clsApplications.enStatus.New);
            tmsiCancelApp.Enabled = (LocalDrivingLicenseApplication.ApplicationStatus == clsApplications.enStatus.New);
            tmsiDeleteApp.Enabled = (LocalDrivingLicenseApplication.ApplicationStatus == clsApplications.enStatus.New);

            tmsiTests.Enabled = !LicenseExist;

            bool PassedVisionTest = LocalDrivingLicenseApplication.DoesPassTest(clsTestTypes.enTestType.VisionTest);
            bool PassedWrittenTest = LocalDrivingLicenseApplication.DoesPassTest(clsTestTypes.enTestType.WrittenTest);
            bool PassedStreetTest = LocalDrivingLicenseApplication.DoesPassTest(clsTestTypes.enTestType.StreetTest);

            tmsiTests.Enabled = (!PassedVisionTest || !PassedWrittenTest || !PassedStreetTest) && (LocalDrivingLicenseApplication.ApplicationStatus == clsApplications.enStatus.New);

            if (tmsiTests.Enabled)
            {
                tmsiVisionTest.Enabled = !PassedVisionTest;
                tmsiWrittenTest.Enabled = PassedVisionTest && !PassedWrittenTest;
                tmsiStreetTest.Enabled = PassedVisionTest && PassedWrittenTest && !PassedStreetTest;
            }
        }

        private void _ScheduleTest(clsTestTypes.enTestType TestType)
        {
            frmListTestAppointment ListTestAppointmentFrm = 
                new frmListTestAppointment((int)dgvLocalDrivingLicenseApp.CurrentRow.Cells[0].Value, TestType);
            //frmVisionTestAppointment.OnLoadData += _LoadDataInDataGridView;
            ListTestAppointmentFrm.ShowDialog();

            LocalDrivingLicenseApplications_Load(null, null);
        }
         private void tmsiVisionTest_Click(object sender, EventArgs e)
         {
            _ScheduleTest(clsTestTypes.enTestType.VisionTest);
            
         }

         private void tmsiWrittenTest_Click(object sender, EventArgs e)
         {
           _ScheduleTest(clsTestTypes.enTestType.WrittenTest);
         }

         private void tmsiStreetTest_Click(object sender, EventArgs e)
         {
            _ScheduleTest(clsTestTypes.enTestType.StreetTest);
         }

        private void tmsiIssueDrivingLicense_Click(object sender, EventArgs e)
        {
            IssueDriverLicenseForTheFirstTime frmIssueDriverLicenseForTheFirstTime = new IssueDriverLicenseForTheFirstTime((int)dgvLocalDrivingLicenseApp.CurrentRow.Cells[0].Value);
            //frmIssueDriverLicenseForTheFirstTime.OnLoadData += _LoadDataInDataGridView;
            frmIssueDriverLicenseForTheFirstTime.ShowDialog();

            LocalDrivingLicenseApplications_Load(null, null);
        }

         private void tmsiShowLicense_Click(object sender, EventArgs e)
         {
            int LicenseID = clsLocalDrivingLicenseApp.FindByLocalDrivingLicenseAppID((int)dgvLocalDrivingLicenseApp.CurrentRow.Cells[0].Value).GetActiveLicenseIDByPersonID();

            if (LicenseID != -1)
            {
                LicenseInfo frmLicenseInfo = new LicenseInfo(LicenseID);
                frmLicenseInfo.ShowDialog();
            }
            else
                MessageBox.Show("No License With ID: " + LicenseID, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
         }

         private void tmsiShowPersonLicenseHistory_Click(object sender, EventArgs e)
         {
            int PersonID = clsLocalDrivingLicenseApp.FindByLocalDrivingLicenseAppID((int)dgvLocalDrivingLicenseApp.CurrentRow.Cells[0].Value).ApplicantPersonID;

            LicensesHistory frmLicensesHistory = new LicensesHistory(PersonID);
             frmLicensesHistory.ShowDialog();
         }

         private void tmsiEditApp_Click(object sender, EventArgs e)
         {
             NewLocalDrivingLicenseApplication frmNewLocalDrivingLicenseApplication =
                 new NewLocalDrivingLicenseApplication((int)dgvLocalDrivingLicenseApp.CurrentRow.Cells[0].Value);
             //frmNewLocalDrivingLicenseApplication.OnLoadData += _LoadDataInDataGridView;
             frmNewLocalDrivingLicenseApplication.ShowDialog();

            LocalDrivingLicenseApplications_Load(null, null);
        }

        private void tmsiDeleteApp_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Delete This Application?", "Confirm",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            clsLocalDrivingLicenseApp LocalDrivingLicenseApplication
                = clsLocalDrivingLicenseApp.FindByLocalDrivingLicenseAppID((int)dgvLocalDrivingLicenseApp.CurrentRow.Cells[0].Value);

            if (LocalDrivingLicenseApplication != null)
            {
                if (LocalDrivingLicenseApplication.Delete())
                {
                    MessageBox.Show("Application Deleted Successfully", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LocalDrivingLicenseApplications_Load(null, null);
                }
                else
                {
                    MessageBox.Show("Cannot Delete Application Because it's Related With Another Proccesses", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           
        }

        private void tmsiShowApplicationDetails_Click(object sender, EventArgs e)
        {
            frmLocalDrivingLicenseApplicationInfo LocalDrivingLicenseApplicationInfo
                = new frmLocalDrivingLicenseApplicationInfo((int)dgvLocalDrivingLicenseApp.CurrentRow.Cells[0].Value);
            LocalDrivingLicenseApplicationInfo.ShowDialog();

            LocalDrivingLicenseApplications_Load(null, null);
        }
    }
}
