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
using DVLD_BusinessLogicLayer_BLL_.Tests_Appointments;

namespace DVLD_PresentationLayer_PL_.Test_Appointments
{
    public partial class WrittenTestAppoinrment : Form
    {
        int _LDLAppID = -1, _TestType = -1;
        bool _isRetakeTest = false;
        clsTestAppointments _TestAppointment;

        public delegate void DelegLoadData();
        public event DelegLoadData OnLoadData;
        public WrittenTestAppoinrment(int LDLAppID, int TestType)
        {
            InitializeComponent();
            _LDLAppID = LDLAppID;
            _TestType = TestType;
        }

        void _ShowScheduleTest(int TestAppointID, bool isRetakeTest)
        {
            //ScheduleTest frmScheduleTest = new ScheduleTest(_LDLAppID, TestAppointID, _TestType, isRetakeTest);
            //frmScheduleTest.OnLoadData += _LoadDataGridView;
            //frmScheduleTest.ShowDialog();
        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            //int TestAppointmentID = clsTestAppointments.HasAppointmentExist(_LDLAppID, _TestType);
            int TestAppointmentID = 0;
           
            if (TestAppointmentID != -1)
            {
                 _TestAppointment = clsTestAppointments.Find(TestAppointmentID);
                if (!_TestAppointment.IsLocked)
                {
                    MessageBox.Show("Person Already Has an Active Appointment For This Test, " +
                  "You Cannot Add New Appointment", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    clsTests Test = clsTests.Find(TestAppointmentID);
                    if (Test != null)
                    {
                        if (Test.ResultTest)
                        {
                            MessageBox.Show("This Person Already Passed This Test Before, You Can Only Retake Faild Test",
                              "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            _isRetakeTest = true;
                            _ShowScheduleTest(-1, _isRetakeTest);
                        }
                    }
                   

                }
            }
            else
            {
                _isRetakeTest = false;
                _ShowScheduleTest(-1, _isRetakeTest);
                //clsTestAppointments.Trial = 0;
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _isRetakeTest = false;
            _ShowScheduleTest((int)dgvAppointments.CurrentRow.Cells[0].Value, _isRetakeTest);
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TakeTest frmTakeTest = new TakeTest(_LDLAppID, (int)dgvAppointments.CurrentRow.Cells[0].Value);
            //frmTakeTest.OnLoadData += _LoadDataGridView;
            //frmTakeTest.ShowDialog();
        }

        void _LoadDataGridView()
        {
            //dgvAppointments.DataSource = clsTestAppointments.GetApplicationTestAppointmentPerTestType(_LDLAppID, _TestType);
            lblCountAppointments.Text = dgvAppointments.RowCount.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            OnLoadData?.Invoke();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dgvAppointments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblCountAppointments_Click(object sender, EventArgs e)
        {

        }

        private void WrittenTestAppoinrment_Load(object sender, EventArgs e)
        {
            int ApplicationID = clsLocalDrivingLicenseApp.FindByLocalDrivingLicenseAppID(_LDLAppID).ApplicationID;
            cntrlVisionTestAppointments1.LoadLocalDrivingLicenseApplicationByLocalDrivingLicenseApplicationID(_LDLAppID);
            _LoadDataGridView();
        }
    }
}
