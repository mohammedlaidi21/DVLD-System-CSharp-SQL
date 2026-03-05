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
using DVLD_PresentationLayer_PL_.Global;
using DVLD_PresentationLayer_PL_.Properties;

namespace DVLD_PresentationLayer_PL_.Test.Controls
{
    public partial class CntrlScheduledTest : UserControl
    {
        private clsTestTypes.enTestType _TestTypeID = clsTestTypes.enTestType.VisionTest;

        private clsTestAppointments _TestAppointment;

        private int _TestID = -1;

        public int TestID
        {
            get { return _TestID; }
        }
        
        public clsTestTypes.enTestType TestTypeID
        {
            get { return _TestTypeID; }
            set
            {
                _TestTypeID = value;

                switch (_TestTypeID)
                {
                    case clsTestTypes.enTestType.VisionTest:
                        gbTypeTest.Text = "Vision Test";
                        pbTakeTest.Image = Resources.Vision_512;
                        break;

                    case clsTestTypes.enTestType.WrittenTest:
                        gbTypeTest.Text = "Written Test";
                        pbTakeTest.Image = Resources.Written_Test_512;
                        break;

                    case clsTestTypes.enTestType.StreetTest:
                        gbTypeTest.Text = "Strret Test";
                        pbTakeTest.Image = Resources.driving_test_512;
                        break;

                }
            }
        }

        private int _TestAppointmentID = -1;

        public int TestAppointmentID
        {
            get { return _TestAppointmentID; }
        }

        private int _LocalDrivingLicenseApplicationID = -1;
        private clsLocalDrivingLicenseApp _LocalDrivingLicenseApp;
        
        public CntrlScheduledTest()
        {
            InitializeComponent();
        }

        public void LoadInfo(int TestAppointmentID)
        {
            _TestAppointmentID = TestAppointmentID;

            _TestAppointment = clsTestAppointments.Find(_TestAppointmentID);

            if (_TestAppointment == null)
            {
                MessageBox.Show("Error: No Test Appointment With ID: " + TestAppointmentID, 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _TestAppointmentID = -1;
                return;
            }

            _LocalDrivingLicenseApplicationID = _TestAppointment.LocalDrivingLicenseApplicationID;
             _LocalDrivingLicenseApp = clsLocalDrivingLicenseApp.FindByLocalDrivingLicenseAppID(_LocalDrivingLicenseApplicationID);

            if (_LocalDrivingLicenseApp == null)
            {
                MessageBox.Show("Error: No Local Driving License Application With ID: " + _LocalDrivingLicenseApplicationID, 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblDLAppID.Text = _LocalDrivingLicenseApp.LocalDrivingLicenseAppID.ToString();
            lblDrivingClass.Text = _LocalDrivingLicenseApp.LicenseClassInfo.ClassName;
            lblName.Text = _LocalDrivingLicenseApp.PersonInfo.FullName;
            lblTrial.Text = _LocalDrivingLicenseApp.TotalTrialPerTest(_TestTypeID).ToString();
            lblDate.Text = clsFormat.DateToShort(_TestAppointment.AppointmentDate);
            lblFees.Text = _TestAppointment.PaidFees.ToString("0");

            _TestID = _TestAppointment.TestID;

            lblTestID.Text = (_TestAppointment.TestID == -1) ? "Not Taken Yet" : _TestAppointment.TestID.ToString();
        }
    }
}
