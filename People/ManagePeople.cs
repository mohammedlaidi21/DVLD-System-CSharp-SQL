using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_BusinessLogicLayer_BLL_;

namespace DVLD_PresentationLayer_PL_
{
    public partial class ManagePeople : Form
    {
        private static DataTable _dtPeople = clsPeople.GetAllPeople();
       
        private DataTable _dtPeopleView = _dtPeople.DefaultView.ToTable(false, "PersonID", "NationalNo",
            "FirstName", "SecondName", "ThirdName", "LastName", "Gender", "DateOfBirth", 
            "CountryName", "Phone", "Email");
        public ManagePeople()
        {
            InitializeComponent();
        }

        

        private void _RefreshPeopleData()
        {
            _dtPeople = clsPeople.GetAllPeople();
            _dtPeopleView = _dtPeople.DefaultView.ToTable(false, "PersonID", "NationalNo",
            "FirstName", "SecondName", "ThirdName", "LastName", "Gender", "DateOfBirth",
            "CountryName", "Phone", "Email");

            dgvPeople.DataSource = _dtPeopleView;
            lblCountPeople.Text = dgvPeople.Rows.Count.ToString();
        }

        
        private void ManagePeople_Load(object sender, EventArgs e)
        {
            dgvPeople.DataSource = _dtPeopleView;
            cbPeopleInfo.SelectedIndex = 0;

            lblCountPeople.Text = dgvPeople.Rows.Count.ToString();

            if (dgvPeople.Rows.Count > 0)
            {
                dgvPeople.Columns[0].HeaderText = "Person ID";
                dgvPeople.Columns[0].Width = 110;

                dgvPeople.Columns[1].HeaderText = "National No.";
                dgvPeople.Columns[1].Width = 120;

                dgvPeople.Columns[2].HeaderText = "First Name";
                dgvPeople.Columns[2].Width = 120;

                dgvPeople.Columns[3].HeaderText = "Second Name";
                dgvPeople.Columns[3].Width = 140;

                dgvPeople.Columns[4].HeaderText = "Third Name";
                dgvPeople.Columns[4].Width = 120;

                dgvPeople.Columns[5].HeaderText = "Last Name";
                dgvPeople.Columns[5].Width = 120;

                dgvPeople.Columns[6].HeaderText = "Gender";
                dgvPeople.Columns[6].Width = 120;

                dgvPeople.Columns[7].HeaderText = "Date Of Birth";
                dgvPeople.Columns[7].Width = 140;

                dgvPeople.Columns[8].HeaderText = "Nationality";
                dgvPeople.Columns[8].Width = 120;

                dgvPeople.Columns[9].HeaderText = "Phone";
                dgvPeople.Columns[9].Width = 120;

                dgvPeople.Columns[10].HeaderText = "Email";
                dgvPeople.Columns[10].Width = 170;
            }
        }

        private void txtFiltring_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";

            switch (cbPeopleInfo.Text)
            {
                case "Person ID":
                    FilterColumn = "PersonID";
                    break;

                case "National No.":
                    FilterColumn = "NationalNo";
                    break;

                case "First Name":
                    FilterColumn = "FirstName";
                    break;

                case "Second Name":
                    FilterColumn = "SecondName";
                    break;

                case "Third Name":
                    FilterColumn = "ThirdName";
                    break;

                case "Last Name":
                    FilterColumn = "LastName";
                    break;

                case "Nationality":
                    FilterColumn = "CountryName";
                    break;

                case "Gender":
                    FilterColumn = "Gender";
                    break;

                case "Phone":
                    FilterColumn = "Phone";
                    break;

                case "Email":
                    FilterColumn = "Email";
                    break;

                default:
                    FilterColumn = "None";
                    break;
            }


            if (txtFiltring.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtPeopleView.DefaultView.RowFilter = "";
                lblCountPeople.Text = dgvPeople.Rows.Count.ToString();
                return;
            }

            if (FilterColumn == "PersonID")
                _dtPeopleView.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFiltring.Text.Trim());
            else
                _dtPeopleView.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFiltring.Text.Trim());

            lblCountPeople.Text = dgvPeople.Rows.Count.ToString();
        }

        private void cbPeopleInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFiltring.Visible = (cbPeopleInfo.Text != "None");

            if (txtFiltring.Visible)
            {
                txtFiltring.Text = "";
                txtFiltring.Focus();
            }
        }

        private void txtFiltring_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbPeopleInfo.Text == "Person ID" || cbPeopleInfo.Text == "Phone")
                e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            AddUpdatePersonInfo AddUpdatePersonFrm = new AddUpdatePersonInfo();
            //AddUpdatePersonFrm.MdiParent = this;
            //AddUpdatePersonFrm.LoadData += _LoadDataPeople;
            AddUpdatePersonFrm.ShowDialog();

            _RefreshPeopleData();
        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUpdatePersonInfo AddUpdatePersonFrm = new AddUpdatePersonInfo();
            //AddUpdatePersonFrm.MdiParent = this;
            //AddUpdatePersonFrm.LoadData += _LoadDataPeople;
            AddUpdatePersonFrm.ShowDialog();

            _RefreshPeopleData();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUpdatePersonInfo AddUpdatePersonFrm = new AddUpdatePersonInfo((int)dgvPeople.CurrentRow.Cells[0].Value);
            //AddUpdatePersonFrm.MdiParent = this;
            //AddUpdatePersonFrm.LoadData += _LoadDataPeople;
            AddUpdatePersonFrm.ShowDialog();

            _RefreshPeopleData();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonDetails PersonDetailsfrm = new PersonDetails((int)dgvPeople.CurrentRow.Cells[0].Value);
            PersonDetailsfrm.ShowDialog();
        }


        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvPeople.CurrentRow.Cells[0].Value;
            if (MessageBox.Show("Are Sure You Want To Delete Person [" + PersonID + "]", "Confirm", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (clsPeople.DeletePerson(PersonID))
                {
                    MessageBox.Show("Person " + PersonID + " is Deleted Successfully",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshPeopleData();
                }
                else
                {
                    MessageBox.Show("Cannot be Delete This Person Because it is linked to other things!!",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature is Not Available Now", "Warning",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void phoneCallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature is Not Available Now", "Warning",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
