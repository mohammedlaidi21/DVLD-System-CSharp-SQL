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
using DVLD_BusinessLogicLayer_BLL_.Users;

namespace DVLD_PresentationLayer_PL_.Users
{
    public partial class AddEditUser : Form
    {
        enum enMode { eAddMode = 0, eUpdateMode = 1 };
        enMode _Mode = enMode.eAddMode;

        private int _UserID = -1;
        clsUsers _User;

        //public delegate void DelegLoadData();
       // public event DelegLoadData _LoadData;

        public AddEditUser()
        {
            InitializeComponent();

            _Mode = enMode.eAddMode;
        }

        public AddEditUser(int UserID)
        {
            InitializeComponent();

            _Mode = enMode.eUpdateMode;
            _UserID = UserID;
        }

        private void _ResetDefaultValues()
        {
            if (_Mode == enMode.eAddMode)
            {
                lblTitle.Text = "Add New User";
                this.Text = lblTitle.Text;
                _User = new clsUsers();

                cntrlPersonDetailsWithFilter1.FilterEnable = true;

                tpLoginInfo.Enabled = false;

                cntrlPersonDetailsWithFilter1.FilterFocus();
            }
            else
            {
                lblTitle.Text = "Update User";
                this.Text = lblTitle.Text;

                btnSave.Enabled = true;
                tpLoginInfo.Enabled = true;
            }

           

            lblUserID.Text = "???";
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            cbIsActive.Checked = true;

        }

        private void _LoadData()
        {
            _User = clsUsers.FindByUserID(_UserID);
            cntrlPersonDetailsWithFilter1.FilterEnable = false;

            if (_User == null)
            {
                MessageBox.Show("No User With ID: " + _UserID, "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();

                return;
            }

            lblUserID.Text = _User.UserID.ToString();
            txtUserName.Text = _User.Username;
            txtPassword.Text = _User.Password;
            txtConfirmPassword.Text = _User.Password;
            cbIsActive.Checked = _User.isActive;
            cntrlPersonDetailsWithFilter1.LoadPersonInfo(_User.PersonID);
        }

        private void AddEditUser_Load(object sender, EventArgs e)
        {

            _ResetDefaultValues();

            if (_Mode == enMode.eUpdateMode)
                _LoadData();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            if (_Mode == enMode.eUpdateMode)
            {
                btnSave.Enabled = true;
                tpLoginInfo.Enabled = true;
                tcUserInfo.SelectedTab = tcUserInfo.TabPages["tpLoginInfo"];
                return;
            }



            if (cntrlPersonDetailsWithFilter1.PersonID != -1)
            {
                if (clsUsers.isPersonAlreadyUser(cntrlPersonDetailsWithFilter1.PersonID))
                {
                    MessageBox.Show("Selected Person Already has a User, Choose Another One", "Already Exist",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cntrlPersonDetailsWithFilter1.FilterFocus();
                }
                else
                {
                    btnSave.Enabled = true;
                    tpLoginInfo.Enabled = true;
                    tcUserInfo.SelectedTab = tcUserInfo.TabPages["tpLoginInfo"];
                }
            }
            else
            {
                MessageBox.Show("Please Select a Perso", "Select a Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cntrlPersonDetailsWithFilter1.FilterFocus();
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some Fileds Invalid!, put the mouse over the red icon(s) to see the error", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _User.PersonID = cntrlPersonDetailsWithFilter1.PersonID;
            _User.Username = txtUserName.Text.Trim();
            _User.Password = txtPassword.Text.Trim();
            _User.isActive = cbIsActive.Checked;



            if (_User.Save())
            {
                lblUserID.Text = _User.UserID.ToString();
                
                lblTitle.Text = "Update User";
                this.Text = lblTitle.Text;
                _Mode = enMode.eUpdateMode;

                MessageBox.Show("Data Saved Successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data Failed To Save", "Faild Saving", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cntrlPersonDetailsWithFilter1_Load(object sender, EventArgs e)
        {
            
        }

        private void cntrlPersonDetailsWithFilter1_OnSendPerson(clsPeople obj)
        {
            
        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text.Trim()))
            {
                e.Cancel = true;
                epValidateUser.SetError(txtUserName, "Usermane Cannot Be Blank!");
                return;
            }
            else
            {
                epValidateUser.SetError(txtUserName, "");
            }

            if (_Mode == enMode.eAddMode)
            {
                if (clsUsers.isUserExist(txtUserName.Text.Trim()))
                {
                    e.Cancel = true;
                    epValidateUser.SetError(txtUserName, "Username is Used By Another User!");
                }
                else
                {
                    epValidateUser.SetError(txtUserName, "");
                }
            }
            else
            {
                if (txtUserName.Text.Trim() != _User.Username)
                {
                    if (clsUsers.isUserExist(txtUserName.Text.Trim()))
                    {
                        e.Cancel = true;
                        epValidateUser.SetError(txtUserName, "Username is Used By Another User!");
                    }
                    else
                    {
                        epValidateUser.SetError(txtUserName, "");
                    }
                }
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text.Trim()))
            {
                e.Cancel = true;
                epValidateUser.SetError(txtPassword, "Password Connot Be Blank!");
            }
            else
            {
                epValidateUser.SetError(txtPassword, "");
            }
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtPassword.Text.Trim() != txtConfirmPassword.Text.Trim())
            {
                e.Cancel = true;
                epValidateUser.SetError(txtConfirmPassword, "Password Confirmation does not match Password!");
            }
            else
            {
                epValidateUser.SetError(txtConfirmPassword, "");
            }
        }
    }
}
