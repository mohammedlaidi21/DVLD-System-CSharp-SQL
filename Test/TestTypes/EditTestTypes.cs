using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_BusinessLogicLayer_BLL_.Test_Types;
using DVLD_PresentationLayer_PL_.Global;

namespace DVLD_PresentationLayer_PL_.TestTypes
{
    public partial class EditTestTypes : Form
    {
        clsTestTypes.enTestType _TestTypeID = clsTestTypes.enTestType.VisionTest;
        clsTestTypes _TestType;

        public EditTestTypes(clsTestTypes.enTestType TestTypeID)
        {
            InitializeComponent();
            _TestTypeID = TestTypeID;
        }

        public delegate void DelegLoadData();
        public event DelegLoadData _OnLoadData;

        private void EditTestTypes_Load(object sender, EventArgs e)
        {
            _TestType = clsTestTypes.Find(_TestTypeID);

            if (_TestType != null)
            {
                lblTestTypeID.Text = ((int)_TestTypeID).ToString();
                txtTitle.Text = _TestType.TestTypeTitle;
                txtDescription.Text = _TestType.TestTypeDescription;
                txtFees.Text = _TestType.TestTypeFees.ToString();
            }
            else
            {
                MessageBox.Show("No Test Type With ID: " + (int)_TestTypeID,
                    "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //clsTestTypes TestTypes = clsTestTypes.Find(_TestTypeID);

            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some Fields Are Invalid!, put the mouse over red icon(s) to see the error",
                    "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            _TestType.TestTypeTitle = txtTitle.Text.Trim();
            _TestType.TestTypeDescription = txtDescription.Text.Trim();
            _TestType.TestTypeFees = Convert.ToDecimal(txtFees.Text.Trim());

            if (_TestType.Save())
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
            //_OnLoadData?.Invoke();
            this.Close();
        }

        private void txtFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void txtTitle_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtTitle.Text.Trim()))
            {
                e.Cancel = true;
                epValidation.SetError(txtTitle, "Title Cannot Be Empty!");
            }
            else
            {
                epValidation.SetError(txtTitle, "");
            }
        }

        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescription.Text.Trim()))
            {
                e.Cancel = true;
                epValidation.SetError(txtDescription, "Description Cannot Be Empty!");
            }
            else
            {
                epValidation.SetError(txtDescription, "");
            }
        }

        private void txtFees_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFees.Text.Trim()))
            {
                e.Cancel = true;
                epValidation.SetError(txtFees, "Fees Cannot Be Empty!");
                return;
            }
            else
            {
                epValidation.SetError(txtFees, "");
            }

            if (!clsValidation.IsNumber(txtFees.Text.Trim()))
            {
                e.Cancel = true;
                epValidation.SetError(txtFees, "Invalid Number!");
            }
            else
            {
                epValidation.SetError(txtFees, "");
            }
        }
    }
}
