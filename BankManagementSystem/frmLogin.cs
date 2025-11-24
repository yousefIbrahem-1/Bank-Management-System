using Bank.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bank_Business;

namespace Bank
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
           clsEmployee Employee=clsEmployee.Find(txt_username.Text,txt_password.Text);
            if (chkRememberMe.Checked)
            {
                //store username and password
                clsGlobal.RememberUsernameAndPassword(txt_username.Text.Trim(), txt_password.Text.Trim());

            }
            else
            {
                //store empty username and password
                clsGlobal.RememberUsernameAndPassword("", "");

            }
            if (Employee != null && !Employee.IsActive)
                MessageBox.Show("this Employee is not active in system, Contact Admin.", "failed", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
           else if (Employee != null)
            {
                clsGlobal.CurrentEmployee = Employee;

                frmMain_Menu frm = new frmMain_Menu();
                frm.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Employee doesn`t Exist","failed",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
        
            Application.Exit();
        }

        private void btn_Minimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_eye_Click(object sender, EventArgs e)
        {
            if (btn_eye.Tag.Equals(0))
            {
                btn_eye.Tag = 1;
                btn_eye.Image = Resources.hide__1_;
                txt_password.PasswordChar = '\0';
            }
            else
            {
                btn_eye.Tag = 0;
                btn_eye.Image = Resources.view__1_;
                txt_password.PasswordChar = '*';
            }

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            string UserName = "", Password = "";
           

            if (clsGlobal.GetStoredCredential(ref UserName, ref Password))
            {
                txt_username.Text = UserName;
                txt_password.Text = Password;
                chkRememberMe.Checked = true;
            }
            else
                chkRememberMe.Checked = false;
        }
    }
}
