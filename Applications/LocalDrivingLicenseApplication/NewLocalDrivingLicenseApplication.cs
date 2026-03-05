using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DVLD_BusinessLogicLayer_BLL_;
using DVLD_BusinessLogicLayer_BLL_.Applications;
using DVLD_BusinessLogicLayer_BLL_.LicenseClasses;
using DVLD_BusinessLogicLayer_BLL_.Licenses;
using DVLD_BusinessLogicLayer_BLL_.LocalDrivingLicenseApplication;
using DVLD_BusinessLogicLayer_BLL_.Users;
using DVLD_PresentationLayer_PL_.Global;


namespace DVLD_PresentationLayer_PL_.LocalDrivingLicenseApplication
{
    public partial class NewLocalDrivingLicenseApplication : Form
    {
        enum enMode { eAddMode = 0, eUpdateMode = 1 };
        enMode _Mode = enMode.eAddMode;

        int _LocalDrivingLicenseAppID;
        clsLocalDrivingLicenseApp _LocalDrivingLicenseApplication;

        int SelectedPersonID = -1;
        

        public delegate void DelegLoadData();
        public event DelegLoadData OnLoadData;

        public NewLocalDrivingLicenseApplication()
        {
            InitializeComponent();

            _Mode = enMode.eAddMode;
        }
        public NewLocalDrivingLicenseApplication(int LDLAppID)
        {
            InitializeComponent();

            _LocalDrivingLicenseAppID = LDLAppID;
            _Mode = enMode.eUpdateMode;
        }

        void _FillClassNameComboBox()
        {
            DataTable dtLicenseClasses = clsLicenseClasses.GetAllLicenseClasses();
            foreach (DataRow row in dtLicenseClasses.Rows)
            {
                cbLicenseClass.Items.Add(row["ClassName"]);
            }
        }

        void _ResetDefaultValues()
        {

            _FillClassNameComboBox();

            if (_Mode == enMode.eAddMode)
            {

                lblTitle.Text = "New Local Driving License Application";
                this.Text = "New Local Driving License Application";
                _LocalDrivingLicenseApplication = new clsLocalDrivingLicenseApp();
                tbApplicationInfo.Enabled = false;
                btnSave.Enabled = false;
                cntrlPersonDetailsWithFilter1.FilterFocus();


                lblDLAppID.Text = "???";
                lblAppDate.Text = DateTime.Now.ToShortDateString();
                cbLicenseClass.SelectedIndex = 2;
                lblAppFees.Text = clsApplicationTypes.Find((int)clsApplications.enApplicationType.NewDrivingLicense).Fees.ToString();
                lblCreatedBy.Text = clsGlobal.CurrentUser.Username;
               
            }
            else
            {
                lblTitle.Text = "Update Local Driving License Application";
                this.Text = "Update Local Driving License Application";
                tbApplicationInfo.Enabled = true;
                btnSave.Enabled = true;
            }
        }

        void _LoadData()
        {
            cntrlPersonDetailsWithFilter1.FilterEnable = false;
            _LocalDrivingLicenseApplication = clsLocalDrivingLicenseApp.FindByLocalDrivingLicenseAppID(_LocalDrivingLicenseAppID);

            if (_LocalDrivingLicenseApplication == null)
            {
                MessageBox.Show("No Application With ID: " + _LocalDrivingLicenseApplication, "Not Found", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            cntrlPersonDetailsWithFilter1.LoadPersonInfo(_LocalDrivingLicenseApplication.ApplicantPersonID);
            lblDLAppID.Text = _LocalDrivingLicenseApplication.LocalDrivingLicenseAppID.ToString();
            lblAppDate.Text = _LocalDrivingLicenseApplication.ApplicationDate.ToShortDateString();
            cbLicenseClass.SelectedIndex = cbLicenseClass.FindString(_LocalDrivingLicenseApplication.LicenseClassInfo.ClassName);
            lblAppFees.Text = _LocalDrivingLicenseApplication.PaidFees.ToString();
            //lblCreatedBy.Text = clsUsers.FindByUserID(_LocalDrivingLicenseApplication.CreatedByUserID).Username;
            lblCreatedBy.Text = _LocalDrivingLicenseApplication.CreatedByUserInfo.Username;
        }


        int _ConvertDaysToYears(int Days)
        {
            int Years = Days / 365;

            return Years;
        }
        /*int _GetValidityAgeForThisLicense()
        {
            DateTime AgePerson = clsPeople.Find(_Person.PersonID).DateOfBirth;
            DateTime NowDate = DateTime.Now;
            TimeSpan Validity = NowDate - AgePerson;
            return _ConvertDaysToYears(Validity.Days);
        }*/

       /* bool _NewLocalDrivingLicenseApplication()
        {
            int ExistApplicationID = clsApplications.GetActiveApplicationForLicenseClass(_LocalDrivingLicenseApplication.ApplicantPersonID, _LocalDrivingLicenseApplication.ApplicationTypeID, _LocalDrivingLicenseApplication.LicenseClassID) (_Person.NationalNo, cbLicenseClass.Text);
            clsLicenses Licence = clsLicenses.FindByApplicationID(ExistApplicationID);
            
            if (ExistApplicationID == -1)
            {
                short MinimumAllowedAge = clsLicenseClasses.Find(cbLicenseClass.Text).MinimumAllowedAge;
                int ValidityAgePerson = _GetValidityAgeForThisLicense();
                if (ValidityAgePerson < MinimumAllowedAge)
                {
                    MessageBox.Show("The Age Person is not Allowed For This License", "Validity Age",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                _LocalDrivingLicenseApplication.ApplicantPersonID = _Person.PersonID;
                _LocalDrivingLicenseApplication.ApplicationDate = Convert.ToDateTime(lblAppDate.Text);
                _LocalDrivingLicenseApplication.ApplicationTypeID = 1;
                _LocalDrivingLicenseApplication.ApplicationStatus = clsApplications.enStatus.New;
                _LocalDrivingLicenseApplication.LastStatusDate = DateTime.Now;
                _LocalDrivingLicenseApplication.PaidFees = Convert.ToInt32(lblAppFees.Text);
                _LocalDrivingLicenseApplication.CreatedByUserID = clsGlobal.CurrentUser.UserID;
                _LocalDrivingLicenseApplication.LicenseClassID = _LocalDrivingLicenseApplication.LicenseClassInfo.LicenseClassID;
                return true;

            }
            else
            {
                if (Licence != null)
                {
                    MessageBox.Show("Person Already Has a License With The Same Applied Driving Class, Chooce Different Driving Class",
                        "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Chooce Another License Class, The Seleted Person " +
                   $"Already Has an Active Application For The Selected Class With Id = {ExistApplicationID}", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
                return false;
            }
        }*/

        private void NewLocalDrivingLicenseApplication_Load(object sender, EventArgs e)
        {

            _ResetDefaultValues();

            if (_Mode == enMode.eUpdateMode)
                _LoadData();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(_Mode == enMode.eUpdateMode)
            {
               
                tbApplicationInfo.Enabled = true;
                btnSave.Enabled = true;
                tcLocalDrivingLicenceApplication.SelectedTab = tcLocalDrivingLicenceApplication.TabPages["tbApplicationInfo"];
                return;
            }

            if (cntrlPersonDetailsWithFilter1.PersonID != -1)
            {
                btnSave.Enabled = true;
                tbApplicationInfo.Enabled = true;
                tcLocalDrivingLicenceApplication.SelectedTab = tcLocalDrivingLicenceApplication.TabPages["tbApplicationInfo"];
            }
            else
            {
                MessageBox.Show("Please Select A Person!", "Select a Person",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                cntrlPersonDetailsWithFilter1.FilterFocus();
            }



        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int LicenseClassID = clsLicenseClasses.Find(cbLicenseClass.Text).LicenseClassID;

            int ActiveApplication = clsApplications.GetActiveApplicationForLicenseClass(cntrlPersonDetailsWithFilter1.PersonID, clsApplications.enApplicationType.NewDrivingLicense, LicenseClassID);

                if (ActiveApplication != -1)
                {
                    MessageBox.Show("Choose Another License Class, The Selected Person Already Has An Active Application For The Selecred Class With ID: "+ ActiveApplication, "Exist Application",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (true) //is Exist an Active License by Person ID
                {
                    MessageBox.Show("Person Already Has a License With The Same Applied Drivig Class This License Class", "Exist License",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            int AgePerson = DateTime.Now.Year - (clsPeople.Find(_LocalDrivingLicenseApplication.ApplicantPersonID).DateOfBirth).Year;

            if (DateTime.Now < clsPeople.Find(_LocalDrivingLicenseApplication.ApplicantPersonID).DateOfBirth.AddYears(AgePerson))
                AgePerson--;

            if(AgePerson < clsLicenseClasses.Find(LicenseClassID).MinimumAllowedAge)
            { 
                MessageBox.Show("Person Age is Not Allowed For This License", "Not Allowed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _LocalDrivingLicenseApplication.ApplicantPersonID = cntrlPersonDetailsWithFilter1.PersonID;

            if (_Mode == enMode.eAddMode)
            {
                _LocalDrivingLicenseApplication.ApplicationDate = DateTime.Now;
                _LocalDrivingLicenseApplication.LastStatusDate = DateTime.Now;
            }
           
            _LocalDrivingLicenseApplication.ApplicationTypeID = (int)clsApplications.enApplicationType.NewDrivingLicense;
            _LocalDrivingLicenseApplication.ApplicationStatus = clsApplications.enStatus.New;
            _LocalDrivingLicenseApplication.PaidFees = Convert.ToDecimal(lblAppFees.Text);
            _LocalDrivingLicenseApplication.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            _LocalDrivingLicenseApplication.LicenseClassID = LicenseClassID;


            if (_LocalDrivingLicenseApplication.Save())
            {
                lblDLAppID.Text = _LocalDrivingLicenseApplication.LocalDrivingLicenseAppID.ToString();
                lblTitle.Text = "Update Local Driving License Application";
                _Mode = enMode.eUpdateMode;

                MessageBox.Show("Data Saved Successfully.", "Success", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Wrong To Save Data!", "Wrong", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            OnLoadData?.Invoke();
            this.Close();
        }

        private void cntrlPersonDetailsWithFilter1_OnSendPerson_1(int obj)
        {
            SelectedPersonID = obj;
        }

        private void NewLocalDrivingLicenseApplication_Activated(object sender, EventArgs e)
        {
            cntrlPersonDetailsWithFilter1.FilterFocus();
        }
    }
}
