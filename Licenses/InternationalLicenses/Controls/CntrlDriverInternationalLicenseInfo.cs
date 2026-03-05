using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_BusinessLogicLayer_BLL_;
using DVLD_BusinessLogicLayer_BLL_.Applications;
using DVLD_BusinessLogicLayer_BLL_.InternationalLicenses;
using DVLD_PresentationLayer_PL_.Global;
using DVLD_PresentationLayer_PL_.Properties;

namespace DVLD_PresentationLayer_PL_.User_Controls
{
    public partial class CntrlDriverInternationalLicenseInfo : UserControl
    {
        private clsInternationalLicenses _InternationalLicense;
        private int _InternationalLicenseID = -1;
        public CntrlDriverInternationalLicenseInfo()
        {
            InitializeComponent();
        }

        public int InternatioanlLicenseID
        { get { return _InternationalLicenseID; } }
        public void LoadInternationalLicenseInfo(int InternationalLicenseID)
        {
            _InternationalLicenseID = InternationalLicenseID;
            _InternationalLicense = clsInternationalLicenses.Find(_InternationalLicenseID);

            if(_InternationalLicense == null)
            {
                MessageBox.Show("No International License With ID: "+ InternationalLicenseID, "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                _InternationalLicenseID = -1;
                return;
            }

            _FillInternationalLicenseInfo();
        }

        private void _LoadImagePerson()
        {
            if (_InternationalLicense.DriverInfo.PersonInfo.Gender == 0)
                pbPerson.Image = Resources.Male_512;
            else
                pbPerson.Image = Resources.Female_512;

            string ImagePath = _InternationalLicense.DriverInfo.PersonInfo.ImagePath;

            if (ImagePath != "")
                if (File.Exists(ImagePath))
                    pbPerson.ImageLocation = ImagePath;
                else
                    MessageBox.Show($"Could Not Found This Image {ImagePath}", "Not Found",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void _FillInternationalLicenseInfo()
        {
            lblIntLicenseID.Text = _InternationalLicense.InternationalLicenseID.ToString();
            lblLicenseID.Text = _InternationalLicense.IssuedUsingLocalLicenseID.ToString();
            lblIssueDate.Text = clsFormat.DateToShort(_InternationalLicense.IssueDate);
            lblApplicationID.Text = _InternationalLicense.ApplicationID.ToString();
            lblIsActive.Text = (_InternationalLicense.IsActive) ? "Yes" : "No";
            lblDriverID.Text = _InternationalLicense.DriverID.ToString();
            lblExpirationDate.Text = clsFormat.DateToShort(_InternationalLicense.ExpirationDate);


            lblName.Text = _InternationalLicense.DriverInfo.PersonInfo.FullName;
            lblNationalNo.Text = _InternationalLicense.DriverInfo.PersonInfo.NationalNo;
            lblGendor.Text = (_InternationalLicense.DriverInfo.PersonInfo.Gender == 0) ? "Male" : "Female";
            lblDateOfBirth.Text = clsFormat.DateToShort(_InternationalLicense.DriverInfo.PersonInfo.DateOfBirth);

            _LoadImagePerson();

        }
                
    }
}
