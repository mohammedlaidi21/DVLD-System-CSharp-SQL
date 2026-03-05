using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_BusinessLogicLayer_BLL_.Users;

namespace DVLD_PresentationLayer_PL_.Users
{
    public partial class ChangePassword : Form
    {
        private int _UserID = -1;
        private clsUsers _User;
        public ChangePassword(int UserID)
        {
            InitializeComponent();

            _UserID = UserID;
        }

        private void _ResetDefaultValues()
        {
            txtCurrentPassword.Text = "";
            txtNewPassword.Text = "";
            txtConfirmPassword.Text = "";
            txtCurrentPassword.Focus();
        }
        private void ChangePassword_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            _User = clsUsers.FindByUserID(_UserID);

            if (_User == null)
            {
                MessageBox.Show("Could Not Find User With ID: " + _UserID, "Not Found",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            cntrlUserInfoCard1.LoadUserInfo(_UserID);
        }

        private void txtCurrentPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCurrentPassword.Text.Trim()))
            {
                e.Cancel = true;
                epChangePassword.SetError(txtCurrentPassword, "Current Password Cannot Be Blank!");
                return;
            }
            else
            {
                e.Cancel = false;
                epChangePassword.SetError(txtCurrentPassword, "");
            }

            if (txtCurrentPassword.Text.Trim() != _User.Password)
            {
                e.Cancel = true;
                epChangePassword.SetError(txtCurrentPassword, "Current Password is Wrong!");
                return;
            }
            else
            {
                epChangePassword.SetError(txtCurrentPassword, "");
            }
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtConfirmPassword.Text.Trim() != txtNewPassword.Text.Trim())
            {
                e.Cancel = true;
                epChangePassword.SetError(txtConfirmPassword, "Password Confirmation Does Not Match With New Password!");
            }
            else
            {
                //e.Cancel = false;
                epChangePassword.SetError(txtConfirmPassword, "");
            }
        }

        private void txtNewPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNewPassword.Text.Trim()))
            {
                e.Cancel = true;
                epChangePassword.SetError(txtNewPassword, "New Password Cannot Be Blank!");
            }
            else
            {
                epChangePassword.SetError(txtNewPassword, "");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some Files are Not Valid!, Put The Mouse Over The Red Icon(s) To see The Error", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _User.Password = txtNewPassword.Text;

            if (_User.Save())
            {
                MessageBox.Show("Password Changed Successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                _ResetDefaultValues();
            }
            else
            {
                MessageBox.Show("Faild To Change Password!", "Faild",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
