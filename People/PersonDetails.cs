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
using DVLD_PresentationLayer_PL_.Properties;

namespace DVLD_PresentationLayer_PL_
{
    public partial class PersonDetails : Form
    {
        private int _PersonID = -1;
        public PersonDetails(int PersonID)
        {
            InitializeComponent();
            //_PersonID = PersonID;
            cntrlPersonDetails1.LoadPersonInfo(PersonID);

        }

        public PersonDetails(string NationalNo)
        {
            InitializeComponent();

            cntrlPersonDetails1.LoadPersonInfo(NationalNo);

        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PersonDetails_Load(object sender, EventArgs e)
        {
            //cntrlPersonDetails1.LoadPersonInfo(_PersonID);
        }
    }
}
