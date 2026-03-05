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
using DVLD_BusinessLogicLayer_BLL_.LocalDrivingLicenseApplication;
using DVLD_BusinessLogicLayer_BLL_.Test_Types;
using DVLD_BusinessLogicLayer_BLL_.Tests_Appointments;

namespace DVLD_PresentationLayer_PL_.Test_Appointments
{
    public partial class StreetTestAppointment : Form
    {
        int _LocalDrivingLicenseAppID = -1, _TestTypeID = -1;
        bool _IsRetakeTest = false;
        clsTestAppointments _TestAppointment;

        public delegate void DelegLoadData();
        public event DelegLoadData OnLoadData;    
        public StreetTestAppointment(int LDLAppID, int TestTypeID)
        {
            InitializeComponent();
            _LocalDrivingLicenseAppID = LDLAppID;
            _TestTypeID = TestTypeID;
        }

        void _ShowScheduleTestForm(int TestAppointmentID, bool isRetakeTest)
        {
            //ScheduleTest frmScheduleTest = new ScheduleTest(_LocalDrivingLicenseAppID, _TestTypeID, TestAppointmentID);
            //frmScheduleTest.OnLoadData += _LoadDataGridViewWithData;
            //frmScheduleTest.ShowDialog();
        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            //int _TestAppointmentID = clsTestAppointments.GetLastTestAppointment(_LocalDrivingLicenseAppID, (clsTestTypes.enTestType)_TestTypeID);
            int _TestAppointmentID = 0;

            if (_TestAppointmentID != -1)
            {
                _TestAppointment = clsTestAppointments.Find(_TestAppointmentID);

                if (!_TestAppointment.IsLocked)
                {
                    MessageBox.Show("Person Already Has an Active Appointment For This Test, " +
                "You Cannot Add New Appointment", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    clsTests _Test = clsTests.Find(_TestAppointmentID);

                    if (_Test != null)
                    {
                        if (_Test.ResultTest)
                        {
                            MessageBox.Show("This Person Already Passed This Test Before, You Can Only Retake Faild Test",
                              "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            _IsRetakeTest = true;
                            _ShowScheduleTestForm(-1, _IsRetakeTest);
                        }
                    }
                }
            }
            else
            {
                _IsRetakeTest = false;
                _ShowScheduleTestForm(-1, _IsRetakeTest);
            }
        }

        void _LoadDataGridViewWithData()
        {
            //dgvAppointments.DataSource = clsTestAppointments.GetApplicationTestAppointmentPerTestType(_LocalDrivingLicenseAppID, _TestTypeID);
            lblCountAppointments.Text = dgvAppointments.RowCount.ToString();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _IsRetakeTest = false;
            _ShowScheduleTestForm((int)dgvAppointments.CurrentRow.Cells[0].Value, _IsRetakeTest);
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TakeTest frmTakeTest = new TakeTest(_LocalDrivingLicenseAppID, (int)dgvAppointments.CurrentRow.Cells[0].Value);
            //frmTakeTest.OnLoadData += _LoadDataGridViewWithData;
            //frmTakeTest.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            OnLoadData?.Invoke();
            this.Close();
        }

        private void StreetTestAppointment_Load(object sender, EventArgs e)
        {
            //clsLocalDrivingLicenseApp _LDLApp = clsLocalDrivingLicenseApp.FindByLDLApp(_LocalDrivingLicenseAppID);
            //cntrlVisionTestAppointments1._FillCntrlVisionTestAppointment(_LocalDrivingLicenseAppID, _LDLApp.Application.ApplicationID);
            _LoadDataGridViewWithData();
        }
    }
}
