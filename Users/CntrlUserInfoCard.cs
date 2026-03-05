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

namespace DVLD_PresentationLayer_PL_.User_Controls
{
    public partial class CntrlUserInfoCard : UserControl
    {
        private clsUsers _User;
        private int _UserID;

        public int UserID
        {
            get { return _UserID; }
        }

        public CntrlUserInfoCard()
        {
            InitializeComponent();
        }

        public void LoadUserInfo(int UserID)
        {
            _UserID = UserID;
            _User = clsUsers.FindByUserID(UserID);

            if (_User == null)
            {
                _ResetDefaultUserInfo();
                MessageBox.Show("No User Found With ID: " + UserID, "Not Found",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillUserCard();
        }

        private void _FillUserCard()
        {
            cntrlPersonDetails1.LoadPersonInfo(_User.PersonID);
            lblUserID.Text = _User.UserID.ToString();
            lblUsername.Text = _User.Username;
            lblIsActive.Text = (_User.isActive)? "Yes" : "No";
        }

        private void _ResetDefaultUserInfo()
        {
            cntrlPersonDetails1.ResetDefaulPersontInfo();
            lblUserID.Text = "???";
            lblUsername.Text = "???";
            lblIsActive.Text = "???";
        }


    }
}
