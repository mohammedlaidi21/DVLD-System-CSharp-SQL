using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_BusinessLogicLayer_BLL_.Users;
using DVLD_PresentationLayer_PL_.Properties;
using DVLD_PresentationLayer_PL_.Global;

namespace DVLD_PresentationLayer_PL_
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            clsUsers User = clsUsers.FindUserByUserNameAndPassword(txtUserName.Text.Trim(), txtPassword.Text.Trim());


            if (User != null)
            {
                if (cbRememberMe.Checked)
                {
                    clsGlobal.RememberUsernameAndPassword(txtUserName.Text.Trim(), txtPassword.Text.Trim());
                }
                else
                {
                    clsGlobal.RememberUsernameAndPassword("", "");
                }

                if (!User.isActive)
                {
                    MessageBox.Show("Your Account is Not Active Call Your Admin!", "Faild Login",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                clsGlobal.CurrentUser = User;
                this.Hide();

                frmMain HomeFrm = new frmMain(this);
                HomeFrm.ShowDialog();
                this.Show();
            }
            else
            {
                txtUserName.Focus();
                MessageBox.Show("Invalid Username/Password.", "Wrong Credintials",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void Login_Load(object sender, EventArgs e)
        {
            string UserName = "", Password = "";

            if (clsGlobal.GetStoredCredential(ref UserName, ref Password))
            {
                txtUserName.Text = UserName;
                txtPassword.Text = Password;
                cbRememberMe.Checked = true;
            }
            else
                cbRememberMe.Checked = false;
            

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
