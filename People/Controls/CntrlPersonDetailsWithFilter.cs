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
using DVLD_PresentationLayer_PL_.Properties;

namespace DVLD_PresentationLayer_PL_.User_Controls
{
    public partial class CntrlPersonDetailsWithFilter : UserControl
    {
        //I Do This Event For Return PersonID For Send To Main Form For Adding In Users
        public event Action<int> OnSendPerson;
        protected virtual void SendPerson(int PersonID)
        {
            Action<int> Handler = OnSendPerson;

            if (Handler != null)
            {
                Handler(PersonID);
            }
        }

        private bool _ShowAddPerson = true;
        private bool _FilterEnable = true;

        public bool ShowAddPerson
        {
            get { return _ShowAddPerson; }
            set
            {
                _ShowAddPerson = value;
                btnAddNewPerson.Visible = _ShowAddPerson;
            }
        }

        public bool FilterEnable
        {
            get { return _FilterEnable; }
            set
            {
                _FilterEnable = value;
                gpFilterBy.Enabled = _FilterEnable; 
            }
        }


        private int _PersonID = -1;

        public int PersonID
        {
            get { return cntrlPersonDetails1.PersonID; }
        }

        public clsPeople SelectedPersonInfo
        {
            get { return cntrlPersonDetails1.SelectedPersonInfo; }
        }

     
        public CntrlPersonDetailsWithFilter()
        {
            InitializeComponent();
        }
       

        public void LoadPersonInfo(int PersonID)
        {
            cbSearchPerson.SelectedIndex = 0;
            txtSearchPerson.Text = PersonID.ToString();
            FindNow();
            
        }

        private void FindNow()
        {
            switch(cbSearchPerson.Text)
            {
                case "Person ID":
                    cntrlPersonDetails1.LoadPersonInfo(int.Parse(txtSearchPerson.Text));
                    break;

                case "National No":
                    cntrlPersonDetails1.LoadPersonInfo(txtSearchPerson.Text);
                    break;

                default:
                    break;
            }

            if (OnSendPerson != null && FilterEnable)
            {
                SendPerson(cntrlPersonDetails1.PersonID);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Filed is Blank!", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FindNow();
        }

        
        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            AddUpdatePersonInfo frmAddUpdatePerson = new AddUpdatePersonInfo();
            frmAddUpdatePerson._LoadBackData += SendDataBackEvent;
            frmAddUpdatePerson.ShowDialog();
        }

        private void SendDataBackEvent(object sender, int PersonID)
        {
            cbSearchPerson.SelectedIndex = 0;
            txtSearchPerson.Text = PersonID.ToString();
            cntrlPersonDetails1.LoadPersonInfo(PersonID);
        }
        private void CntrlPersonDetailsWithFilter_Load(object sender, EventArgs e)
        {
            cbSearchPerson.SelectedIndex = 1;
            txtSearchPerson.Focus();
        }

        private void txtSearchPerson_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchPerson.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtSearchPerson, "This Field is Blank!");
            }
            else
            {
                errorProvider1.SetError(txtSearchPerson, "");
            }
        }

        public void FilterFocus()
        {
            txtSearchPerson.Focus();
        }

        private void txtSearchPerson_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnSearch.PerformClick();
            }

            if (cbSearchPerson.Text == "Person ID")
                e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void cbSearchPerson_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearchPerson.Text = "";
            txtSearchPerson.Focus();
        }

        private void gpFilterBy_Enter(object sender, EventArgs e)
        {

        }
    }
}
