using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_PresentationLayer_PL_.People
{
    public partial class frmFindPerson : Form
    {
        public delegate void SendDataBack(object sender, int PersonID);
        public event SendDataBack DataBack;
        public frmFindPerson()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DataBack?.Invoke(this, cntrlPersonDetailsWithFilter1.PersonID);
            this.Close();
        }
    }
}
