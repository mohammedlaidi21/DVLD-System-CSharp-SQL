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
using DVLD_PresentationLayer_PL_.Global;

namespace DVLD_PresentationLayer_PL_.Applications.Controls
{
    public partial class CntrlBaseApplicationInfo : UserControl
    {

        private clsApplications _Application;
        private int _ApplicationID = -1;

        public int ApplicationID
        {
            get { return _ApplicationID; }
        }
        public CntrlBaseApplicationInfo()
        {
            InitializeComponent();
        }

        public void ResetDefaultValues()
        {
            _ApplicationID = -1;

            lblID.Text = "[???]";
            lblStatus.Text = "[???]";
            lblFees.Text = "[$$$]";
            lblType.Text = "[???]";
            lblApplicant.Text = "[????]";
            lblDate.Text = "[??/??/????]";
            lblStatusDate.Text = "[??/??/????]";
            lblUser.Text = "[????]";

            lbllViewPersonInfo.Enabled = false;
        }

        private void _FillBaseApplicationInfo()
        {
            lbllViewPersonInfo.Enabled = true;
            _ApplicationID = _Application.ApplicationID;
            lblID.Text = _Application.ApplicationID.ToString();
            lblStatus.Text = _Application.StatusText.ToString();
            lblFees.Text = _Application.PaidFees.ToString();
            lblType.Text = _Application.ApplicationTypeInfo.Title;
            lblApplicant.Text = _Application.PersonInfo.FullName;
            lblDate.Text = clsFormat.DateToShort(_Application.ApplicationDate);
            lblStatusDate.Text =  clsFormat.DateToShort(_Application.LastStatusDate);
            lblUser.Text = _Application.CreatedByUserInfo.Username;
            
        }

        public void LoadBaseApplicationInfo(int ApplicationID)
        {
            _Application = clsApplications.FindBaseApplication(ApplicationID);

            if (_Application == null)
            {
                ResetDefaultValues();
                MessageBox.Show("No Application With ID: " + ApplicationID, "Not Found",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillBaseApplicationInfo();
        }

        private void lbllViewPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PersonDetails frmPersonDetails = new PersonDetails(_Application.ApplicantPersonID);
            frmPersonDetails.ShowDialog();

            //Refresh
            LoadBaseApplicationInfo(_ApplicationID);
        }
    }
}
