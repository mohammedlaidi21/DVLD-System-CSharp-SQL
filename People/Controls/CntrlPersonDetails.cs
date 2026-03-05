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
using DVLD_PresentationLayer_PL_.Properties;
using DVLD_PresentationLayer_PL_.User_Controls;

namespace DVLD_PresentationLayer_PL_
{
    public partial class CntrlPersonDetails : UserControl
    {
        private int _PersonID;
        private clsPeople _Person;

        public int PersonID
        {
            get { return _PersonID; }
        }

        public clsPeople SelectedPersonInfo
        {
            get { return _Person; }
        }

        public CntrlPersonDetails()
        {
            InitializeComponent();
        }

        
        private void lbllEditPerson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddUpdatePersonInfo AddUpdatePersonFrm = new AddUpdatePersonInfo(_PersonID);
            AddUpdatePersonFrm.onRefreshDataBack += LoadPersonInfo;
            AddUpdatePersonFrm.ShowDialog();
        }

        public void ResetDefaulPersontInfo()
        {
            _PersonID = -1;
            lblPersID.Text = "[????]";
            lblName.Text = "[????]";
            lblNatioNo.Text = "[????]";
            lblGendr.Text = "[????]";
            lblMail.Text = "[????]";
            lblAddres.Text = "[????]";
            lblBirthDate.Text = "[????]";
            lblPhnes.Text = "[????]";
            lblCountr.Text = "[????]";
            pbPers.Image = Resources.Male_512;
            //lbllEditPerson.Enabled = false;
        }
        public void LoadPersonInfo(int PersonID)
        {
            _Person = clsPeople.Find(PersonID);

            if (_Person == null)
            {
                ResetDefaulPersontInfo();
                MessageBox.Show($"No Person With ID: {PersonID.ToString()}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillPersonCard();
        }

        public void LoadPersonInfo(string NationalNo)
        {
            _Person = clsPeople.Find(NationalNo);

            if (_Person == null)
            {
                ResetDefaulPersontInfo();
                MessageBox.Show($"No Person With NationalNo: {NationalNo}", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillPersonCard();
        }

        private void _LoadPersonImage()
        {
            if (_Person.Gender == 0)
                pbPers.Image = Resources.Male_512;

            else
                pbPers.Image = Resources.Female_512;

            string ImagePath = _Person.ImagePath;
            if (ImagePath != "")
                if (File.Exists(ImagePath))
                    pbPers.ImageLocation = ImagePath;
                else
                    MessageBox.Show("Could Not Find This Image: = " + ImagePath, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void _FillPersonCard()
        {
            lbllEditPerson.Enabled = true;
            _PersonID = _Person.PersonID;
            lblPersID.Text = _Person.PersonID.ToString();
            lblNatioNo.Text = _Person.NationalNo;
            lblName.Text = _Person.FullName;
            lblCountr.Text = _Person.CountryInfo.CountryName;
            lblAddres.Text = _Person.Address.ToString();
            lblBirthDate.Text = _Person.DateOfBirth.ToShortDateString();
            lblPhnes.Text = _Person.Phone.ToString();
            lblMail.Text = _Person.Email.ToString();
            lblGendr.Text = (_Person.Gender == 0) ? "Male" : "Female";

            _LoadPersonImage();
        }

        private void CntrlPersonDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
