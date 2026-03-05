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
using DVLD_BusinessLogicLayer_BLL_.Licenses;
using DVLD_BusinessLogicLayer_BLL_.LocalDrivingLicenseApplication;
using DVLD_PresentationLayer_PL_.Global;
using DVLD_PresentationLayer_PL_.Properties;

namespace DVLD_PresentationLayer_PL_.User_Controls
{
    public partial class CntrlLicenseInfo : UserControl
    {
        private int _LicenseID = -1;
        private clsLicenses _License;


        public CntrlLicenseInfo()
        {
            InitializeComponent();
        }

        public int LicenseID
        {
            get { return _LicenseID; }
        }

        public clsLicenses SelectedLicenseInfo
        {
            get { return _License; }
        }

        public void LoadLincenseInfo(int LicenseID)
        {
            _LicenseID = LicenseID;
            _License = clsLicenses.FindByLicenseID(_LicenseID);

            if (_License == null)
            {
                _ResetDefaultValues();
                MessageBox.Show("No License With ID: " + LicenseID, "Not Found", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                _LicenseID = -1;
                return;
            }

            _FillLicenseInfo();
        }

        private void _LoadPersonImage()
        {
            if (_License.DriverInfo.PersonInfo.Gender == 0)
                pbPerson.Image = Resources.Male_512;
            else
                pbPerson.Image = Resources.Female_512;

            string ImagePath = _License.DriverInfo.PersonInfo.ImagePath;

            if (ImagePath != "")
                if (File.Exists(ImagePath))
                    pbPerson.Load(ImagePath);
                else
                    MessageBox.Show("Cannot Find This Image" + ImagePath, "Not Found",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void _ResetDefaultValues()
        {
            lblClass.Text = "[???]";
            lblName.Text = "[????]";
            lblNationalNo.Text = "[????]";
            lblGendor.Text = "[????]";
            lblDateOfBirth.Text = "[????]";
            lblLicenseID.Text = "[????]";

            lblDriverID.Text = "[????]";
            lblIssueDate.Text = "[????]";
            lblExpirationDate.Text = "[????]";
            lblNotes.Text = "[????]";
            lblIssueReason.Text = "[????]";
            lblisActive.Text = "[????]";
            lblIsDetained.Text = "[????]";

            pbPerson.Image = Resources.Male_512;
        }
        private void _FillLicenseInfo()
        {
            lblClass.Text = _License.LicenseClassInfo.ClassName;
            lblName.Text = _License.DriverInfo.PersonInfo.FullName;
            lblNationalNo.Text = _License.DriverInfo.PersonInfo.NationalNo;
            lblGendor.Text = (_License.DriverInfo.PersonInfo.Gender == 0) ? "Male" : "Female";
            lblDateOfBirth.Text = clsFormat.DateToShort(_License.DriverInfo.PersonInfo.DateOfBirth);
            lblLicenseID.Text = _License.LicenseID.ToString();
           
            lblDriverID.Text = _License.DriverID.ToString();
            lblIssueDate.Text = clsFormat.DateToShort(_License.IssueDate);
            lblExpirationDate.Text = clsFormat.DateToShort(_License.ExpirationDate);
            lblNotes.Text = (_License.Notes == "") ? "No Notes" : _License.Notes;
            lblIssueReason.Text = _License.IssueReasonText;
            lblisActive.Text = _License.IsActive ? "Yes" : "No";
            lblIsDetained.Text = _License.IsDetained ? "Yes" : "No";

            _LoadPersonImage();
        }
    }
}
