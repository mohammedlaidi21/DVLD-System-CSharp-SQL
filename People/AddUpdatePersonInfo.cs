using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DVLD_BusinessLogicLayer_BLL_;
using DVLD_PresentationLayer_PL_.Properties;
using System.IO;
//using DVLD_PresentationLayer_PL_.Global_Methods;
using DVLD_PresentationLayer_PL_.Global;

namespace DVLD_PresentationLayer_PL_
{
    public partial class AddUpdatePersonInfo : Form
    {
        enum enMode { eAddMode = 0, eUpdateMode = 1};
        enum enGender { Male = 0, Female = 1 };

      
        public  event Action<int> onRefreshDataBack; 

        protected virtual void RefreshDataBack(int PersonID)
        {
            Action<int> Handler = onRefreshDataBack;

            if (Handler != null)
                Handler(PersonID);
        }



        private enMode _Mode;
        private int _PersonID = -1;
        clsPeople _Person;


        public AddUpdatePersonInfo()
        {
            InitializeComponent();
            _Mode = enMode.eAddMode;

        }

        public AddUpdatePersonInfo(int PersonID)
        {
            InitializeComponent();

            _PersonID = PersonID;
            _Mode = enMode.eUpdateMode;
            
        }

        public delegate void MyDelegate(object sender, int PersonID);
        public event MyDelegate _LoadBackData;

        private void _FillCountriesInComboBox()
        {
            DataTable Countries = clsCountries.GetAllCountries();

            foreach (DataRow Row in Countries.Rows)
            {
                cbCountries.Items.Add(Row["CountryName"]);
            }
        }

        private void _ResetDefaultValues()
        {
            _FillCountriesInComboBox();

            if (_Mode == enMode.eAddMode)
            {
                lblTitle.Text = "Add New Person";
                _Person = new clsPeople();
            }
            else
                lblTitle.Text = "Update Person Info";


            if (rbMale.Checked)
                pbPerson.Image = Resources.Male_512;
            else
                pbPerson.Image = Resources.Female_512;


            lbllRemove.Visible = (pbPerson.ImageLocation != null);

            dtpDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);
            dtpDateOfBirth.Value = dtpDateOfBirth.MaxDate;

            dtpDateOfBirth.MinDate = DateTime.Now.AddYears(-100);


            cbCountries.SelectedIndex = cbCountries.FindString("Jordan");

            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtSecondName.Text = "";
            txtThirdName.Text = "";
            rbMale.Checked = true;
            txtEmail.Text = "";
            txtAddress.Text = "";
            txtNationalNo.Text = "";
            txtPhone.Text = "";

        }

        private void _LoadData()
        {
            _Person = clsPeople.Find(_PersonID);

            if (_Person == null)
            {
                MessageBox.Show($"No Person With ID: {_PersonID}", 
                    "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            lblPersonID.Text = _PersonID.ToString();
            txtNationalNo.Text = _Person.NationalNo;
            txtFirstName.Text = _Person.FirstName;
            txtSecondName.Text = _Person.SecondNme;
            txtThirdName.Text = _Person.TirthName;
            txtLastName.Text = _Person.LastName;
            dtpDateOfBirth.Value = _Person.DateOfBirth;
            txtEmail.Text = _Person.Email;
            txtPhone.Text = _Person.Phone;
            txtAddress.Text = _Person.Address;

            cbCountries.SelectedIndex = cbCountries.FindString(_Person.CountryInfo.CountryName);

            if (_Person.Gender == 0)
                rbMale.Checked = true;
            else
                rbFemale.Checked = true;
                

            if (_Person.ImagePath != "")
                pbPerson.ImageLocation = _Person.ImagePath;
            

            lbllRemove.Visible = (_Person.ImagePath != "");
        }


        private bool _HandlePersonImage()
        {
            if (_Person.ImagePath != pbPerson.ImageLocation)
            {
                if (_Person.ImagePath != "")
                {
                    try
                    {
                        File.Delete(_Person.ImagePath);
                    }
                    catch
                    {
                        //Generate Exception
                    }

                }

                if (pbPerson.ImageLocation != null)
                {
                    string SourceFilePath = pbPerson.ImageLocation.ToString();

                    if (clsUtil.CopyImageToProjectImagesFolder(ref SourceFilePath))
                    {
                        pbPerson.ImageLocation = SourceFilePath;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Error Copying File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }

            return true;
        }



        private void AddUpdatePersonInfo_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            if (_Mode == enMode.eUpdateMode)
                _LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some Fields Are Not Valid! Put The Mouse Over The Red Icon(s) To See The Error",
                    "Invalid Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (!_HandlePersonImage())
                return;
                
            

            int NationalityCountryID = clsCountries.Find(cbCountries.Text).CountryID;
            
            _Person.NationalNo = txtNationalNo.Text.Trim();
            _Person.FirstName = txtFirstName.Text.Trim();
            _Person.SecondNme = txtSecondName.Text.Trim();
            _Person.TirthName = txtThirdName.Text.Trim();
            _Person.LastName = txtLastName.Text.Trim();
            _Person.Email = txtEmail.Text.Trim();
            _Person.Phone = txtPhone.Text.Trim();
            _Person.Address = txtAddress.Text.Trim();

            if (rbMale.Checked)
                _Person.Gender = (short)enGender.Male;
            else
                _Person.Gender = (short)enGender.Female;

            _Person.NationalityCountryID = NationalityCountryID;


            if (pbPerson.ImageLocation != null)
                _Person.ImagePath = pbPerson.ImageLocation;
            else
                _Person.ImagePath = "";

            
            if (_Person.Save())
            {
                lblPersonID.Text = _Person.PersonID.ToString();

                lblTitle.Text = "Update Person Info";
                _Mode = enMode.eUpdateMode;

                MessageBox.Show("Data Saved Successfully.", "Success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                _LoadBackData?.Invoke(this, _Person.PersonID);

                if (onRefreshDataBack != null)
                    RefreshDataBack(_Person.PersonID);
            }
            else
                MessageBox.Show("Person Faild to Added.", "Faild", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

        }

        private void lbllSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ofd.Filter = "Image File | *.jpg; *.png; *.jpeg; *.gif; *.bmp";
            ofd.FilterIndex = 1;
            ofd.RestoreDirectory = true;

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                string SelectedFilePath = ofd.FileName;
                pbPerson.Load(SelectedFilePath);
                lbllRemove.Visible = true;
            }
        }
        private void lbllRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbPerson.ImageLocation = null;

            if (rbMale.Checked)
                pbPerson.Image = Resources.Male_512;
            else
                pbPerson.Image = Resources.Female_512;


            lbllRemove.Visible = false;
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

        private void txtName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox txtName = (TextBox)sender;

            if (string.IsNullOrEmpty(txtName.Text.Trim()))
            {
                e.Cancel = true;
                epValidate.SetError(txtName, "This Field is Required!");
            }
            else
            {
                e.Cancel = false;
                epValidate.SetError(txtName, "");
            }
        }

        private void txtNationalNo_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNationalNo.Text.Trim()))
            {
                e.Cancel = true;
                epValidate.SetError(txtNationalNo, "This Field is Required!");
                return;
            }
            else
            {
                e.Cancel = false;
                epValidate.SetError(txtNationalNo, "");
            }

            if (txtNationalNo.Text.Trim() != _Person.NationalNo && clsPeople.isPersonExist(txtNationalNo.Text.Trim()))
            {
                e.Cancel = true;
                epValidate.SetError(txtNationalNo, "Person is Aleardy Exist!");
            }
            else
            {
                epValidate.SetError(txtNationalNo, "");
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                epValidate.SetError(txtPhone, "This Required Should Be a Numbers");
                txtPhone.Focus();
                e.Handled = true;
            }
            else
            {
                epValidate.SetError(txtPhone, "");
            }
        }

        private void txtEmail_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtEmail.Text.Trim() == "")
                return;

            if (!clsValidation.ValidateEmail(txtEmail.Text.Trim()))
            {
                e.Cancel = true;
                epValidate.SetError(txtEmail, "Invalid Email Address Format!");
            }
            else
            {
                e.Cancel = false;
                epValidate.SetError(txtEmail, null);
            }


        }
           

        private void rbMale_Click(object sender, EventArgs e)
        {
            if (pbPerson.ImageLocation == null)
                pbPerson.Image = Resources.Male_512;
        }

        private void rbFemale_Click(object sender, EventArgs e)
        {
            if (pbPerson.ImageLocation == null)
                pbPerson.Image = Resources.Female_512;
        }
    }
}
