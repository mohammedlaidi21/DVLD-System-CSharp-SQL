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

namespace DVLD_PresentationLayer_PL_.Detain_Release_Licenses
{
    public partial class DetainLicense : Form
    {

        private int _SelectedLicenseID = -1;
        private int _DetainID = -1;

        public delegate void DelegLoadData();
        public event DelegLoadData _LoadData;
        public DetainLicense()
        {
            InitializeComponent();
        }

        private void cntrlLicenseInfoWithFilter1_OnFillLicense(int obj)
        {
            _SelectedLicenseID = obj;

            if (_SelectedLicenseID == -1)
            {   
                btnDetain.Enabled = false;
                return;
            }

            llblShowLicenseHistory.Enabled = (_SelectedLicenseID != -1);
            lblLicenseID.Text = _SelectedLicenseID.ToString();

            if (cntrlLicenseInfoWithFilter1.SelectedLicenseInfo.IsDetained)
            {
                MessageBox.Show("Selected License is Already Detained, Choose Another One", "Not Allowed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnDetain.Enabled = false;
                return;
            }

            nudFineFees.Focus();
            btnDetain.Enabled = true;
            
        }

        private void DetainLicense_Load(object sender, EventArgs e)
        {
            lblDetainDate.Text = clsFormat.DateToShort(DateTime.Now);
            lblCreatedBy.Text = clsGlobal.CurrentUser.Username;
        }

        private void btnDetain_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Detain This License?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            _DetainID = cntrlLicenseInfoWithFilter1.SelectedLicenseInfo.Detain(Convert.ToDecimal(nudFineFees.Value), clsGlobal.CurrentUser.UserID);

            if (_DetainID == -1)
            {
                MessageBox.Show("Faild To Detain License", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            lblDetainID.Text = _DetainID.ToString();
            MessageBox.Show($"License Detained Successfully With ID = {_DetainID}", "Success",
            MessageBoxButtons.OK, MessageBoxIcon.Information);

            llblShowNewLicenseInfo.Enabled = true;
            btnDetain.Enabled = false;
            cntrlLicenseInfoWithFilter1.FilterEnabled = false;
            nudFineFees.Enabled = false;
        }

        private void llblShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
            LicensesHistory frmLicensesHistory = new LicensesHistory(cntrlLicenseInfoWithFilter1.SelectedLicenseInfo.DriverInfo.PersonID);
            frmLicensesHistory.ShowDialog();
        }

        private void llblShowNewLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LicenseInfo frmLicenseInfo = new LicenseInfo(_SelectedLicenseID);
            frmLicenseInfo.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //_LoadData?.Invoke();
            this.Close();
        }

        private void DetainLicense_Activated(object sender, EventArgs e)
        {
            cntrlLicenseInfoWithFilter1.txtLicenseIDFocus();
        }
    }
}
