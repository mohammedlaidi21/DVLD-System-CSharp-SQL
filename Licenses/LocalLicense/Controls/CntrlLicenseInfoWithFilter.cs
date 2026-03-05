using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_BusinessLogicLayer_BLL_.Applications;
using DVLD_BusinessLogicLayer_BLL_.InternationalLicenses;
using DVLD_BusinessLogicLayer_BLL_.Licenses;
using DVLD_BusinessLogicLayer_BLL_.LocalDrivingLicenseApplication;
using DVLD_BusinessLogicLayer_BLL_.Tests_Appointments;

namespace DVLD_PresentationLayer_PL_.User_Controls
{
    public partial class CntrlLicenseInfoWithFilter : UserControl
    {
        public event Action<int> OnLicenseSelected;

        protected virtual void LicenseSelected(int LicenseID)
        {
            Action<int> handler = OnLicenseSelected;

            if (handler != null)
            {
                handler(LicenseID);
            }
        }

        private bool _FilterEnabled = true;
        public bool FilterEnabled
        {
            get { return _FilterEnabled; }

            set
            {
                _FilterEnabled = value;
                gbFilter.Enabled = _FilterEnabled;
            }
        }


        public CntrlLicenseInfoWithFilter()
        {
            InitializeComponent();
        }


        private int _LicenseID = -1;
         public int LicenseID
        {
            get { return cntrlLicenseInfo1.LicenseID; }
        }

        public clsLicenses SelectedLicenseInfo
        {
            get { return cntrlLicenseInfo1.SelectedLicenseInfo; }
        }

       

        public void LoadLicenseInfo(int LicenseID)
        {
            txtLicenseID.Text = LicenseID.ToString();
            cntrlLicenseInfo1.LoadLincenseInfo(LicenseID);

            _LicenseID = cntrlLicenseInfo1.LicenseID;

            if (OnLicenseSelected != null && FilterEnabled)
                OnLicenseSelected(LicenseID);
        }
       

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some Fields Are Not Valid!, Put The Mouse Over Red Icon(s) To See The Error", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLicenseID.Focus();
                return;
            }

            _LicenseID = int.Parse(txtLicenseID.Text);
            LoadLicenseInfo(_LicenseID);
        }

        public void txtLicenseIDFocus()
        {
            txtLicenseID.Focus();
        }
        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);

            if (e.KeyChar == (char)13)
            {
                btnFind.PerformClick();
            }
        }

        private void txtFilter_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtLicenseID.Text.Trim()))
            {
                e.Cancel = true;
                epValidationLicenseID.SetError(txtLicenseID, "This Field is Required!");
            }
            else
                epValidationLicenseID.SetError(txtLicenseID, "");
        }
    }
}
