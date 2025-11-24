using Bank_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class frmShowPersonInfo : Form
    {
        public frmShowPersonInfo(int personID)
        {

            InitializeComponent();
            ctrlPersonCard1.LoadPersonInfo(personID);

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
