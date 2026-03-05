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
using DVLD_PresentationLayer_PL_.Users;

namespace DVLD_PresentationLayer_PL_
{
    public partial class ManageUsers : Form
    {
        private static DataTable _dtListUsers;
        public ManageUsers()
        {
            InitializeComponent();
        }
       
        private void ManageUsers_Load(object sender, EventArgs e)
        {
            _dtListUsers = clsUsers.GetAllUsers();
            dgvUsers.DataSource = _dtListUsers;

            cbFilterUsers.SelectedIndex = 0;

            lblCountUsers.Text = dgvUsers.Rows.Count.ToString();

            if (dgvUsers.Rows.Count > 0)
            {
                dgvUsers.Columns[0].HeaderText = "User ID";
                dgvUsers.Columns[0].Width = 120;
            
                dgvUsers.Columns[1].HeaderText = "Person ID";
                dgvUsers.Columns[1].Width = 120;
            
                dgvUsers.Columns[2].HeaderText = "Full Name";
                dgvUsers.Columns[2].Width = 350;
            
                dgvUsers.Columns[3].HeaderText = "UserName";
                dgvUsers.Columns[3].Width = 120;
            
                dgvUsers.Columns[4].HeaderText = "Is Active";
                dgvUsers.Columns[4].Width = 120;
            }

        }

        private void cbFilterUsers_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbFilterUsers.Text == "is Active")
            {
                txtFilterBy.Visible = false;
                cbActiveResult.Visible = true;
                cbActiveResult.SelectedIndex = 0;
                cbActiveResult.Focus();
            }
            else
            {
                txtFilterBy.Visible = (cbFilterUsers.Text != "None");
                cbActiveResult.Visible = false;
                txtFilterBy.Text = "";
                txtFilterBy.Focus();
            }
            
        }

        private void txtFilterBy_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";

            switch (cbFilterUsers.Text)
            {
                case "User ID":
                    FilterColumn = "UserID";
                    break;

                case "Person ID":
                    FilterColumn = "PersonID";
                    break;

                case "User Name":
                    FilterColumn = "Username";
                    break;

                case "Full Name":
                    FilterColumn = "FullName";
                    break;

                default:
                    FilterColumn = "None";
                    break;
            }

            if (txtFilterBy.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtListUsers.DefaultView.RowFilter = "";
                lblCountUsers.Text = dgvUsers.Rows.Count.ToString();
                return;
            }

            if (FilterColumn != "FullName" && FilterColumn != "Username")
                _dtListUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterBy.Text.Trim());

            else
                _dtListUsers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterBy.Text.Trim());

            lblCountUsers.Text = _dtListUsers.Rows.Count.ToString();
        }

        private void txtFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterUsers.Text == "User ID" || cbFilterUsers.Text == "Person ID")
                e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void cbActiveResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColumn = "IsActive";
            string FilterValue = cbActiveResult.Text;


            switch (cbActiveResult.Text)
            {
                case "All":
                    break;

                case "Yes":
                    FilterValue = "1";
                    break;
            
                case "No":
                    FilterValue = "0";
                    break;
            }


            if (FilterValue == "All")
                _dtListUsers.DefaultView.RowFilter = "";

            else
                _dtListUsers.DefaultView.RowFilter = string.Format("{0} = {1}", FilterColumn, FilterValue);

            lblCountUsers.Text = _dtListUsers.Rows.Count.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            AddEditUser frmAddEditUser = new AddEditUser();
            //frmAddEditUser._LoadData += _LoadUsersDataInDataGrid;
            frmAddEditUser.ShowDialog();

            ManageUsers_Load(null, null);
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEditUser frmAddEditUser = new AddEditUser();
            //frmAddEditUser._LoadData += _LoadUsersDataInDataGrid;
            frmAddEditUser.ShowDialog();

            ManageUsers_Load(null, null);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEditUser frmAddEditUser = new AddEditUser((int)dgvUsers.CurrentRow.Cells[0].Value);
            //frmAddEditUser._LoadData += _LoadUsersDataInDataGrid;
            frmAddEditUser.ShowDialog();

            ManageUsers_Load(null, null);
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserDetails UserDetailsFrm = new UserDetails((int)dgvUsers.CurrentRow.Cells[0].Value);
            UserDetailsFrm.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure To Want Delete User?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (clsUsers.DeleteUser((int)dgvUsers.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("User Deleted Successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ManageUsers_Load(null, null);
                }
                else
                {
                    MessageBox.Show("User Has More Related With Another Things!", "Faild",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword ChangePasswordFrm = new ChangePassword((int)dgvUsers.CurrentRow.Cells[0].Value);
            ChangePasswordFrm.ShowDialog();
           
        }

        private void dgvUsers_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AddEditUser frmAddEditUser = new AddEditUser((int)dgvUsers.CurrentRow.Cells[0].Value);
            frmAddEditUser.ShowDialog();
        }
    }
}
