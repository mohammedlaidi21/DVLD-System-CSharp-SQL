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

namespace DVLD_PresentationLayer_PL_.Test_Appointments
{
    public partial class TakeTest : Form
    {
        private int _TestAppointmentID = -1;


        private int _TestID = -1;
        private clsTests _Test;

        public delegate void DelegLoadData();
        public event DelegLoadData OnLoadData;

        clsTestTypes.enTestType _TestTypeID = clsTestTypes.enTestType.VisionTest;
       
            
        public TakeTest(int TestAppointID, clsTestTypes.enTestType TestTypeID)
        {
            InitializeComponent();
            _TestAppointmentID = TestAppointID;
            _TestTypeID = TestTypeID;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are You Sure You Want To Save? After That Cannot Change The Pass/Fail Result After You Save?",
                    "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;

            _Test.TestAppointmentID = _TestAppointmentID;
            _Test.ResultTest = rbPass.Checked;
            _Test.Notes = txtNotes.Text.Trim();
            _Test.CreatedByUserID = clsGlobal.CurrentUser.UserID;

            if (_Test.Save())
            {
                MessageBox.Show("Data Saved Successfully", "Success", MessageBoxButtons.OK,
                     MessageBoxIcon.Information);
                    this.Close();
            }
            else
            {
                MessageBox.Show("Wrong To Save Data", "Faild", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TakeTest_Load(object sender, EventArgs e)
        {
            cntrlScheduledTest1.TestTypeID = _TestTypeID;

            cntrlScheduledTest1.LoadInfo(_TestAppointmentID);

            if (cntrlScheduledTest1.TestAppointmentID == -1)
                btnSave.Enabled = false;
            else
                btnSave.Enabled = true;

                int TestID = cntrlScheduledTest1.TestID;

            if (TestID != -1)
            {
                _Test = clsTests.Find(TestID);

                if (_Test.ResultTest)
                    rbPass.Checked = true;
                else
                    rbFail.Checked = true;

                txtNotes.Text = _Test.Notes;

                lblMessage.Visible = true;
                rbPass.Enabled = false;
                rbFail.Enabled = false;
                btnSave.Enabled = false;
            }
            else
                _Test = new clsTests();

        }
    }
}
