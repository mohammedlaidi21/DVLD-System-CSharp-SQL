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

namespace DVLD_PresentationLayer_PL_.Test_Appointments
{
    public partial class ScheduleTest : Form
    {
        private int _LocalDrivingLicenseAppID = -1;
        private clsTestTypes.enTestType _TestTypeID = clsTestTypes.enTestType.VisionTest;
        private int _TestAppointment = -1;
        public ScheduleTest(int LocalDrivingLicenseAppID, clsTestTypes.enTestType TestTypeID, int TestAppointmentID = -1)
        {
            InitializeComponent();

            _LocalDrivingLicenseAppID = LocalDrivingLicenseAppID;
            _TestTypeID = TestTypeID;
            _TestAppointment = TestAppointmentID;
        }

        private void ScheduleTest_Load(object sender, EventArgs e)
        {
            cntrlScheduleTest1.TestTypeID = _TestTypeID;
            cntrlScheduleTest1.LoadInfo(_LocalDrivingLicenseAppID, _TestAppointment);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
