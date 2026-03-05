using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_BusinessLogicLayer_BLL_.LocalDrivingLicenseApplication;
using DVLD_BusinessLogicLayer_BLL_.Test_Types;
using DVLD_BusinessLogicLayer_BLL_.Tests_Appointments;
using DVLD_PresentationLayer_PL_.Properties;
using DVLD_PresentationLayer_PL_.Test_Appointments;

namespace DVLD_PresentationLayer_PL_
{
    public partial class frmListTestAppointment : Form
    {
        private DataTable _dtAllListAppointments;

        private int _LocalDrivingLicenseAppID = -1;
        private clsTestTypes.enTestType _TestTypeID = clsTestTypes.enTestType.VisionTest;
       

        public delegate void DelegLoadData();
        public event DelegLoadData OnLoadData;

        public frmListTestAppointment(int LocalDrivingLicenseAppID, clsTestTypes.enTestType TestTypeID)
        {
            InitializeComponent();
            _LocalDrivingLicenseAppID = LocalDrivingLicenseAppID;
            _TestTypeID = TestTypeID;
        }

        private void _LoadImageAndTitleForm()
        {
            switch(_TestTypeID)
            {
                case clsTestTypes.enTestType.VisionTest:
                    lblTitle.Text = "Vision Test Appointments";
                    this.Text = lblTitle.Text;
                    pbListAppointment.Image = Resources.Vision_512;
                    break;
                case clsTestTypes.enTestType.WrittenTest:
                    lblTitle.Text = "Written Test Appointments";
                    this.Text = lblTitle.Text;
                    pbListAppointment.Image = Resources.Written_Test_512;
                    break;
                case clsTestTypes.enTestType.StreetTest:
                    lblTitle.Text = "Street Test Appointments";
                    this.Text = lblTitle.Text;
                    pbListAppointment.Image = Resources.driving_test_512;
                    break;
            }
        }

        private void VisionTestAppointment_Load(object sender, EventArgs e)
        {
            _LoadImageAndTitleForm();

            cntrlVisionTestAppointments1.LoadLocalDrivingLicenseApplicationByLocalDrivingLicenseApplicationID(_LocalDrivingLicenseAppID);
            
            _dtAllListAppointments = clsTestAppointments.GetApplicationTestAppointmentPerTestType(_LocalDrivingLicenseAppID, _TestTypeID);
            dgvAppointments.DataSource = _dtAllListAppointments;

            lblCountAppointments.Text = dgvAppointments.Rows.Count.ToString();

            if (dgvAppointments.Rows.Count > 0)
            {
                dgvAppointments.Columns[0].HeaderText = "Appointment ID";
                dgvAppointments.Columns[0].Width = 150;

                dgvAppointments.Columns[1].HeaderText = "Appointment Date";
                dgvAppointments.Columns[1].Width = 210;

                dgvAppointments.Columns[2].HeaderText = "Paid Fees";
                dgvAppointments.Columns[2].Width = 150;

                dgvAppointments.Columns[3].HeaderText = "Is Locked";
                dgvAppointments.Columns[3].Width = 100;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //OnLoadData?.Invoke();
            this.Close();
        }

      

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            clsLocalDrivingLicenseApp LocalDrivingLicenseApplication =
                clsLocalDrivingLicenseApp.FindByLocalDrivingLicenseAppID(_LocalDrivingLicenseAppID);

            if (LocalDrivingLicenseApplication.IsThereAnActiveScheduleTest(_TestTypeID))
            {
                MessageBox.Show("Person Already Has An Active Appointment For This Test, You Cannot Add New Appointment",
                    "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            clsTests LastTest = LocalDrivingLicenseApplication.GetLastTestPerTestType(_TestTypeID);

            if (LastTest == null)
            {
                ScheduleTest frmScheduleTest = new ScheduleTest(LocalDrivingLicenseApplication.LocalDrivingLicenseAppID, _TestTypeID);
                frmScheduleTest.ShowDialog();

                VisionTestAppointment_Load(null, null);
                return;
            }

            if (LastTest.ResultTest == true)
            {
                MessageBox.Show("Person Already Pass This Test Before, you Can Only Retake Faild test",
                    "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //LastTest.TestAppointmentInfo.LDLAppID
            ScheduleTest frmScheduleTest2 = new ScheduleTest(LocalDrivingLicenseApplication.LocalDrivingLicenseAppID, _TestTypeID);
            frmScheduleTest2.ShowDialog();

            VisionTestAppointment_Load(null, null);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int TestAppointmentID = (int)dgvAppointments.CurrentRow.Cells[0].Value;

            ScheduleTest frmScheduleTest = new ScheduleTest(_LocalDrivingLicenseAppID, _TestTypeID, TestAppointmentID);
            frmScheduleTest.ShowDialog();

            VisionTestAppointment_Load(null, null);
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //TakeTest frmTakeTest = new TakeTest(_LocalDrivingLicenseAppID, (int)dgvAppointments.CurrentRow.Cells[0].Value);
            //frmTakeTest.OnLoadData += _LoadDataAppointments;
            //frmTakeTest.ShowDialog();
        }
    }
}
