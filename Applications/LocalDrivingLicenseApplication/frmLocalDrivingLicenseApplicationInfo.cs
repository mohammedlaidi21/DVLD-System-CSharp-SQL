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

namespace DVLD_PresentationLayer_PL_.Applications.LocalDrivingLicenseApplication
{
    public partial class frmLocalDrivingLicenseApplicationInfo : Form
    {
        private int _LocalDrivingLicenseApplicationID = -1;
        public frmLocalDrivingLicenseApplicationInfo(int LocalDrivingLicenseAppID)
        {
            InitializeComponent();
            _LocalDrivingLicenseApplicationID = LocalDrivingLicenseAppID;
        }

        private void frmLocalDrivingLicenseApplicationInfo_Load(object sender, EventArgs e)
        {
            cntrlVisionTestAppointments1.LoadLocalDrivingLicenseApplicationByLocalDrivingLicenseApplicationID(_LocalDrivingLicenseApplicationID);
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
