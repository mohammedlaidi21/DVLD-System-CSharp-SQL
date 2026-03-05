using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_PresentationLayer_PL_.Licenses
{
    public partial class LicenseInfo : Form
    {
        private int _LicenseID = -1;
        public LicenseInfo(int LicenseID)
        {
            InitializeComponent();
            _LicenseID = LicenseID;
        }

        private void LicenseInfo_Load(object sender, EventArgs e)
        {
            cntrlLicenseInfo1.LoadLincenseInfo(_LicenseID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
