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
using DVLD_BusinessLogicLayer_BLL_.Drivers;
using DVLD_BusinessLogicLayer_BLL_.LocalDrivingLicenseApplication;

namespace DVLD_PresentationLayer_PL_.Licenses
{
    public partial class LicensesHistory : Form
    {
        private int _PersonID = -1;

        public LicensesHistory()
        {
            InitializeComponent();
        }

        public LicensesHistory(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
        }

        private void LicensesHistory_Load(object sender, EventArgs e)
        {
            if (_PersonID != -1)
            {
                cntrlPersonDetailsWithFilter1.FilterEnable = false;
                cntrlPersonDetailsWithFilter1.LoadPersonInfo(_PersonID);
                cntrlDriverLicenseHistory1.LoadInfoByPersonID(_PersonID);
            }
            else
            {
                cntrlPersonDetailsWithFilter1.Enabled = true;
                cntrlPersonDetailsWithFilter1.FilterFocus();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cntrlPersonDetailsWithFilter1_OnSendPerson(int obj)
        {
            _PersonID = obj;

            if (_PersonID == -1)
                cntrlDriverLicenseHistory1.Clear();

            else
                cntrlDriverLicenseHistory1.LoadInfoByPersonID(_PersonID);
        }
    }
}
