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
using DVLD_PresentationLayer_PL_.Global;

namespace DVLD_PresentationLayer_PL_.ApplicationTypes
{
    public partial class EditApplicationTypes : Form
    {
        private int _AppTypeID = -1;
        private clsApplicationTypes _ApplicationType;
        public EditApplicationTypes(int AppTypeID)
        {
            InitializeComponent();
            _AppTypeID = AppTypeID;

        }

        public delegate void DelegLoadData();
        public event DelegLoadData _LoadData;
        private void EditApplicationTypes_Load(object sender, EventArgs e)
        {
            lblApplicationTypeID.Text = _AppTypeID.ToString();

            _ApplicationType = clsApplicationTypes.Find(_AppTypeID);
            
            if (_ApplicationType != null)
            {
                txtTitle.Text = _ApplicationType.Title;
                txtFees.Text = _ApplicationType.Fees.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some Fields Are Not Valid!, put the mouse over the red Icon(s) to see the error", "Invalid", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _ApplicationType.Title = txtTitle.Text.Trim();
            _ApplicationType.Fees = Convert.ToDecimal(txtFees.Text.Trim());

            if (_ApplicationType.Save())
            {
                MessageBox.Show("Data Saved Successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
            else
            {
                MessageBox.Show("Wrong To Save Data!", "Wrong",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //_LoadData?.Invoke();
            this.Close();
        }

        private void txtFees_KeyPress(object sender, KeyPressEventArgs e)
        {
                //e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtTitle_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtTitle.Text.Trim()))
            {
                e.Cancel = true;
                epValidate.SetError(txtTitle, "Title Cannot Be Empty!");
            }
            else
                epValidate.SetError(txtTitle, "");
        }

        private void txtFees_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFees.Text.Trim()))
            {
                e.Cancel = true;
                epValidate.SetError(txtFees, "Fees Cannot Be Empty!");
                return;
            }
            else
                epValidate.SetError(txtFees, "");


            if (!clsValidation.IsNumber(txtFees.Text.Trim()))
            {
                e.Cancel = true;
                epValidate.SetError(txtFees, "Invalid Number!");
            }
            else
                epValidate.SetError(txtFees, "");
        }
    }
}
