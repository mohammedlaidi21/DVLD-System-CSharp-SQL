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
    public partial class UserDetails : Form
    {
        int _UserID = -1;
        public UserDetails(int ID)
        {
            InitializeComponent();
            _UserID = ID;
        }

        private void cntrlUserInfoCard1_Load(object sender, EventArgs e)
        {
            cntrlUserInfoCard1.LoadUserInfo(_UserID);
        }
        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
