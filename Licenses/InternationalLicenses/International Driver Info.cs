using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_PresentationLayer_PL_.InternationalLicenses
{
    public partial class International_Driver_Info : Form
    {
        private int _InternationalLicenseID = -1;
        public International_Driver_Info(int InternationalLicenseID)
        {
            InitializeComponent();
            _InternationalLicenseID = InternationalLicenseID;
        }

        private void International_Driver_Info_Load(object sender, EventArgs e)
        {
            cntrlDriverInternationalLicenseInfo1.LoadInternationalLicenseInfo(_InternationalLicenseID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
