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
    public partial class frmMain_Menu : Form
    {
        frmPeople frmPeople = new frmPeople();
        frmEmployees frmEmployees = new frmEmployees();
        frmClients frmClients = new frmClients();
        frmLogin frmLogin = new frmLogin();
        frmShowEmpInfo frmShowEmpInfo = new frmShowEmpInfo();
        frmChangePassword frmChangePassword = new frmChangePassword();
        public frmMain_Menu()
        {
            InitializeComponent();
        }

       
        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClients.ShowDialog();

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            frmLogin.Show();
            this.Close();
            
        }

        private void btn_Minimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPeople.ShowDialog();

        }

        private void currentsEmployeeInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowEmpInfo.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword.ShowDialog();
        }

        private void logutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin.Show();
            this.Close();
        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(clsValidatoin.CheckAccessPermission(clsValidatoin.enPermissions.pShowEmployees))
            frmEmployees.ShowDialog();
            else
                MessageBox.Show("Access Denied! Contact your Admin.", "failed", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }

       
    }
}
