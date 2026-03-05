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
using DVLD_BusinessLogicLayer_BLL_.LocalDrivingLicenseApplication;
using DVLD_BusinessLogicLayer_BLL_.Test_Types;
using DVLD_BusinessLogicLayer_BLL_.Tests_Appointments;
using DVLD_PresentationLayer_PL_.Global;
using DVLD_PresentationLayer_PL_.Properties;

namespace DVLD_PresentationLayer_PL_.Test
{
    public partial class CntrlScheduleTest : UserControl
    {
        public enum enMode { AddMode= 0, UpdateMode = 1};
        private enMode _Mode = enMode.AddMode;

        public enum enCreationMode { FirstTimeCreation = 0, RetakeTest = 1};
        private enCreationMode _CreationMode = enCreationMode.FirstTimeCreation;

        private int _LocalDrivingLicenseApplicationID = -1;
        private clsLocalDrivingLicenseApp _LocalDrivingLicenseApplication;

        private int _TestAppointmentID = -1;
        private clsTestAppointments _TestAppointment;

        private clsTestTypes.enTestType _TestTypeID = clsTestTypes.enTestType.VisionTest;
        
        public clsTestTypes.enTestType TestTypeID
        {
            get { return _TestTypeID; }
            set
            {
                _TestTypeID = value;

                switch(_TestTypeID)
                {
                    case clsTestTypes.enTestType.VisionTest:
                        gbTypeTest.Text = "Vision Test";
                        pbTest.Image = Resources.Vision_512;
                        break;

                    case clsTestTypes.enTestType.WrittenTest:
                        gbTypeTest.Text = "Written Test";
                        pbTest.Image = Resources.Written_Test_512;
                        break;

                    case clsTestTypes.enTestType.StreetTest:
                        gbTypeTest.Text = "Street Test";
                        pbTest.Image = Resources.driving_test_512;
                        break;
                }
            }
        }

        public void LoadInfo(int LocalDrivingLicenseApplicationID, int AppointmentID = -1)
        {
            if (AppointmentID == -1)
                _Mode = enMode.AddMode;

            else
                _Mode = enMode.UpdateMode;

            _TestAppointmentID = AppointmentID;
            _LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            _LocalDrivingLicenseApplication = clsLocalDrivingLicenseApp.FindByLocalDrivingLicenseAppID(_LocalDrivingLicenseApplicationID);

            if (_LocalDrivingLicenseApplication == null)
            {
                MessageBox.Show("Error: No Driving License Application With ID: " + LocalDrivingLicenseApplicationID,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = false;
                return;
            }

            if (_LocalDrivingLicenseApplication.DoesAttendTestType(_TestTypeID))
                _CreationMode = enCreationMode.RetakeTest;
            else
                _CreationMode = enCreationMode.FirstTimeCreation;


            if (_CreationMode == enCreationMode.RetakeTest)
            {
                lblTitle.Text = "Schedule Retake Test";
                gpRetakeTestInfo.Enabled = true;
                lblRetakeAppFees.Text = clsApplicationTypes.Find((int)clsApplications.enApplicationType.RetakeTest).Fees.ToString();
                lblRetakeTestAppID.Text = "N/A";
            }
            else
            {
                lblTitle.Text = "Schedule Test";
                gpRetakeTestInfo.Enabled = false;
                lblRetakeAppFees.Text = "0";
                lblRetakeTestAppID.Text = "N/A";
            }

            lblDLAppID.Text = _LocalDrivingLicenseApplication.LocalDrivingLicenseAppID.ToString();
            lblDrivingClass.Text = _LocalDrivingLicenseApplication.LicenseClassInfo.ClassName;
            lblName.Text = _LocalDrivingLicenseApplication.PersonInfo.FullName;
            

            lblTrial.Text = _LocalDrivingLicenseApplication.TotalTrialPerTest(_TestTypeID).ToString();

            if (_Mode == enMode.AddMode)
            {
                dtpDateAppointment.MinDate = DateTime.Now;
                lblFees.Text = clsTestTypes.Find(_TestTypeID).TestTypeFees.ToString();
                lblRetakeTestAppID.Text = "N/A";

                _TestAppointment = new clsTestAppointments();
            }
            else
            {
                if (!_LoadTestAppointmentInfo())
                    return;
            }

            lblTotalFees.Text = (Convert.ToSingle(lblFees.Text) + Convert.ToSingle(lblRetakeAppFees.Text)).ToString();

            if (!_HandleActiveAppointmentConstraint())
                return;

            if (!_HandleIsLockedAppointmentConstraint())
                return;

            if (!_HandlePreviousAppointmentConstraint())
                return;
        }


        bool _LoadTestAppointmentInfo()
        {
            _TestAppointment = clsTestAppointments.Find(_TestAppointmentID);

            if (_TestAppointment == null)
            {
                MessageBox.Show("Error: No Appointment With ID: " + _TestAppointmentID,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = false;
                return false;
            }

            lblDLAppID.Text = _LocalDrivingLicenseApplicationID.ToString();
            lblDrivingClass.Text = _LocalDrivingLicenseApplication.LicenseClassInfo.ClassName;
            lblName.Text = _LocalDrivingLicenseApplication.PersonInfo.FullName;

            if (DateTime.Compare(DateTime.Now, _TestAppointment.AppointmentDate) < 0)
                dtpDateAppointment.MinDate = DateTime.Now;
            else
                dtpDateAppointment.MinDate = _TestAppointment.AppointmentDate;

            dtpDateAppointment.Value = _TestAppointment.AppointmentDate;

            lblFees.Text = _TestAppointment.PaidFees.ToString();

            if (_TestAppointment.RetakeTestApplicationID == -1)
            {
                lblRetakeAppFees.Text = "0";
                lblRetakeTestAppID.Text = "N/B";
            }
            else
            {
                lblRetakeAppFees.Text = _TestAppointment.RetakeTestApplicationInfo.PaidFees.ToString();
                gpRetakeTestInfo.Enabled = true;
                lblTitle.Text = "Schedulr Retake Test";
                lblRetakeTestAppID.Text = _TestAppointment.RetakeTestApplicationID.ToString();
            }

            return true;
        }

        bool _HandleActiveAppointmentConstraint()
        {
            if (_Mode == enMode.AddMode && clsLocalDrivingLicenseApp.IsThereAnActiveSchduleTest(_LocalDrivingLicenseApplicationID, _TestTypeID))
            {
                MessageBox.Show("Person Already Has An Active Appointment For This Test", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = false;
                dtpDateAppointment.Enabled = false;
                return false;
            }

            return true;
        }

        bool _HandleIsLockedAppointmentConstraint()
        {
            if (_TestAppointment.IsLocked)
            {
                lblCannotEdit.Text = "Person Already Sat For The Test, Appointment Locked";
                lblCannotEdit.Visible = true;
                dtpDateAppointment.Enabled = false;
                btnSave.Enabled = false;
                return false;
            }
            else
                lblCannotEdit.Visible = false;

            return true; 
        }

        bool _HandlePreviousAppointmentConstraint()
        {
            switch (_TestTypeID)
            {
                case clsTestTypes.enTestType.VisionTest:
                    lblCannotEdit.Visible = false;
                    return true;
                case clsTestTypes.enTestType.WrittenTest:
                    {
                        if (!_LocalDrivingLicenseApplication.DoesPassTest(clsTestTypes.enTestType.VisionTest))
                        {
                            lblCannotEdit.Text = "Cannot Schedule, Vision Test Should Be Pass First!";
                            lblCannotEdit.Visible = true;
                            dtpDateAppointment.Enabled = false;
                            btnSave.Enabled = false;

                            return false;
                        }
                        else
                        {
                            lblCannotEdit.Visible = false;
                            dtpDateAppointment.Enabled = true;
                            btnSave.Enabled = true;
                        }

                        return true;
                    }

                case clsTestTypes.enTestType.StreetTest:
                    {
                        if (!_LocalDrivingLicenseApplication.DoesPassTest(clsTestTypes.enTestType.WrittenTest))
                        {
                            lblCannotEdit.Text = "Cannot Schedule, Written Test Should Be Pass First!";
                            lblCannotEdit.Visible = true;
                            dtpDateAppointment.Enabled = false;
                            btnSave.Enabled = false;

                            return false;
                        }
                        else
                        {
                            lblCannotEdit.Visible = false;
                            btnSave.Enabled = true;
                            dtpDateAppointment.Enabled = true;
                        }

                        return true;
                    }

            }
            return true;
        }
        public CntrlScheduleTest()
        {
            InitializeComponent();
        }

        bool _HandleRetakeApplication()
        {
           
            if (_Mode == enMode.AddMode && _CreationMode == enCreationMode.RetakeTest)
            {
                clsApplications Application = new clsApplications();

                Application.ApplicantPersonID = _LocalDrivingLicenseApplication.ApplicantPersonID;
                Application.ApplicationTypeID = (int)clsApplications.enApplicationType.RetakeTest;
                Application.ApplicationDate = DateTime.Now;
                Application.ApplicationStatus = clsApplications.enStatus.Completed;
                Application.LastStatusDate = DateTime.Now;
                Application.CreatedByUserID = clsGlobal.CurrentUser.UserID;
                Application.PaidFees = clsApplicationTypes.Find((int)clsApplications.enApplicationType.RetakeTest).Fees;

                if (!Application.Save())
                {
                    MessageBox.Show("Faild To Create Application", "Faild",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _TestAppointment.RetakeTestApplicationID = -1;
                    return false;
                }

                _TestAppointment.RetakeTestApplicationID = Application.ApplicationID;
            }

          
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_HandleRetakeApplication())
                return;

            _TestAppointment.LocalDrivingLicenseApplicationID = _LocalDrivingLicenseApplication.LocalDrivingLicenseAppID;
            _TestAppointment.TestTypeID = _TestTypeID;
            _TestAppointment.AppointmentDate = dtpDateAppointment.Value;
            _TestAppointment.PaidFees = Convert.ToDecimal(lblFees.Text);
            _TestAppointment.CreatedByUserID = clsGlobal.CurrentUser.UserID;

            if (_TestAppointment.Save())
            {
                MessageBox.Show("Data Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _Mode = enMode.UpdateMode;
            }
            else
            {
                MessageBox.Show("Error To Save Data", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
