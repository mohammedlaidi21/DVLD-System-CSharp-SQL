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
using DVLD_BusinessLogicLayer_BLL_.Licenses;
using DVLD_BusinessLogicLayer_BLL_.LocalDrivingLicenseApplication;
using DVLD_PresentationLayer_PL_.Global;
using DVLD_PresentationLayer_PL_.Licenses;

namespace DVLD_PresentationLayer_PL_.User_Controls
{
    public partial class CntrlVisionTestAppointments : UserControl
    {
        //clsViewLocalDrivingLicenseApplications LDLApp_View;
        private clsLocalDrivingLicenseApp _LocalDrivingLicenseApplication;
        private int _LocalDrivingLicenseApplicationID = -1;

        private int _LicenseID = -1;

        public int LocalDrivingLicenseApplicationID
        {
            get { return _LocalDrivingLicenseApplicationID; }
        }

        public CntrlVisionTestAppointments()
        {
            InitializeComponent();
        }

       

        private void _FillLocalDrivingLicenseApplicationInfo()
        {
            _LicenseID = -1; //For Show License Info LabelLink

            lbllShowLicenseInfo.Enabled = (_LicenseID != -1);

            _LocalDrivingLicenseApplicationID = _LocalDrivingLicenseApplication.LocalDrivingLicenseAppID;
            lblDLAppID.Text = _LocalDrivingLicenseApplication.LocalDrivingLicenseAppID.ToString();
            lblLicenseType.Text = _LocalDrivingLicenseApplication.LicenseClassInfo.ClassName;
            lblPassedTest.Text = "0";
            cntrlBaseApplicationInfo1.LoadBaseApplicationInfo(_LocalDrivingLicenseApplication.ApplicationID);
         
        }


        private void _ResetDefaultValues()
        {
            lblDLAppID.Text = "[???]";
            lblLicenseType.Text = "[???]";
            lblPassedTest.Text = "0";
            lbllShowLicenseInfo.Enabled = false;
            cntrlBaseApplicationInfo1.ResetDefaultValues();
        }

        public void LoadLocalDrivingLicenseApplicationByLocalDrivingLicenseApplicationID(int LocalDrivingLicenseAppID)
        {
            _LocalDrivingLicenseApplication = clsLocalDrivingLicenseApp.FindByLocalDrivingLicenseAppID(LocalDrivingLicenseAppID);

            if (_LocalDrivingLicenseApplication == null)
            {
                _ResetDefaultValues();
                MessageBox.Show("No Application With ID: " + LocalDrivingLicenseAppID, "Not Found",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillLocalDrivingLicenseApplicationInfo();
        }

        public void LoadLocalDrivingLicenseApplicationByApplicationID(int ApplicationID)
        {
            _LocalDrivingLicenseApplication = clsLocalDrivingLicenseApp.FindByApplicationID(ApplicationID);

            if (_LocalDrivingLicenseApplication == null)
            {
                _ResetDefaultValues();
                MessageBox.Show("No Application With ID: " + ApplicationID, "Not Found",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillLocalDrivingLicenseApplicationInfo();
        }


        private void lbllShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LicenseInfo frmLicenseInfo = new LicenseInfo(-1); //Send License ID
            frmLicenseInfo.ShowDialog();
        }
    }
}
