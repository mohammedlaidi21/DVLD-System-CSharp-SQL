using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_BusinessLogicLayer_BLL_.Drivers;
using DVLD_BusinessLogicLayer_BLL_.InternationalLicenses;
using DVLD_BusinessLogicLayer_BLL_.LicenseClasses;
using DVLD_BusinessLogicLayer_BLL_.Licenses;
using DVLD_BusinessLogicLayer_BLL_.LocalDrivingLicenseApplication;
using DVLD_PresentationLayer_PL_.InternationalLicenses;
using DVLD_PresentationLayer_PL_.Licenses;

namespace DVLD_PresentationLayer_PL_.User_Controls
{
    public partial class CntrlDriverLicenseHistory : UserControl
    {
        private DataTable _dtLocalLicensesDriver;
        private DataTable _dtInternationalLicensesDriver;

        private int _DriverID = -1;
        private clsDrivers _Driver;


        public CntrlDriverLicenseHistory()
        {
            InitializeComponent();
        }

        private void _LoadLocalLicensesData()
        {
            _dtLocalLicensesDriver = clsDrivers.GetLicenses(_DriverID);

            dgvLocalLicenses.DataSource = _dtLocalLicensesDriver;
            lblCountLocal.Text = dgvLocalLicenses.Rows.Count.ToString();

            if (dgvLocalLicenses.Rows.Count > 0)
            {
                dgvLocalLicenses.Columns[0].HeaderText = "Lic ID";
                dgvLocalLicenses.Columns[0].Width = 110;
           
                dgvLocalLicenses.Columns[1].HeaderText = "App ID";
                dgvLocalLicenses.Columns[1].Width = 110;
           
                dgvLocalLicenses.Columns[2].HeaderText = "Class Name";
                dgvLocalLicenses.Columns[2].Width = 270;
            
                dgvLocalLicenses.Columns[3].HeaderText = "Issue Date";
                dgvLocalLicenses.Columns[3].Width = 170;
            
                dgvLocalLicenses.Columns[4].HeaderText = "Expiration Date";
                dgvLocalLicenses.Columns[4].Width = 170;
            
                dgvLocalLicenses.Columns[5].HeaderText = "Is Active";
                dgvLocalLicenses.Columns[5].Width = 110;
            }
        }

        private void _LoadInternationalLicensesData()
        {
            //Should DataTable International License Handle it Again When Prepare And Solution DAL & BL it.
            _dtInternationalLicensesDriver = clsInternationalLicenses.GetDriverInternationalLicenses(_DriverID);
            dgvInternationalLicenses.DataSource = _dtInternationalLicensesDriver;
            lblCountInternational.Text = dgvInternationalLicenses.Rows.Count.ToString();

            if (dgvInternationalLicenses.Rows.Count > 0)
            {
                dgvInternationalLicenses.Columns[0].HeaderText = "Int.License ID";
                dgvInternationalLicenses.Columns[0].Width = 160;
            
                dgvInternationalLicenses.Columns[1].HeaderText = "Application ID";
                dgvInternationalLicenses.Columns[1].Width = 130;
            
                dgvInternationalLicenses.Columns[2].HeaderText = "L.License ID";
                dgvInternationalLicenses.Columns[2].Width = 130;
            
                dgvInternationalLicenses.Columns[3].HeaderText = "Issue Date";
                dgvInternationalLicenses.Columns[3].Width = 180;
            
                dgvInternationalLicenses.Columns[4].HeaderText = "Expiration Date";
                dgvInternationalLicenses.Columns[4].Width = 180;
            
                dgvInternationalLicenses.Columns[5].HeaderText = "Is Active";
                dgvInternationalLicenses.Columns[5].Width = 120;
            }
        }

        public void LoadInfo(int DriverID)
        {
            _DriverID = DriverID;
            _Driver = clsDrivers.FindByDriverID(DriverID);

            if (_Driver == null)
            {
                MessageBox.Show("No Driver Found With ID: " + _DriverID, "Not Found",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _LoadLocalLicensesData();
            _LoadInternationalLicensesData();
        }

        public void LoadInfoByPersonID(int PersonID)
        {
            _Driver = clsDrivers.FindByPersonID(PersonID);

            if (_Driver == null)
            {
                MessageBox.Show("No Driver Found Linked With Person ID: " + PersonID, "Not Found",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _DriverID = _Driver.DriverID;

            _LoadLocalLicensesData();
            _LoadInternationalLicensesData();
        }

        public void Clear()
        {
            _dtLocalLicensesDriver.Clear();
            _dtInternationalLicensesDriver.Clear();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LicenseInfo frmLicenseInfo = new LicenseInfo((int)dgvLocalLicenses.CurrentRow.Cells[0].Value);
            frmLicenseInfo.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Sould Pass International License ID In Parameter Not License ID
            International_Driver_Info frmInternational_Driver_Info = new International_Driver_Info((int)dgvInternationalLicenses.CurrentRow.Cells[2].Value);
            frmInternational_Driver_Info.ShowDialog();
        }
    }
}
