using Bank.Properties;
using Bank_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class frmChangePassword : Form
    {
        clsEmployee Employee = new clsEmployee();
        clsPerson Person = new clsPerson();

        public frmChangePassword()
        {
            InitializeComponent();
            Employee=clsGlobal.CurrentEmployee;
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            lblEmployeeID.Text = Employee.EmployeeID.ToString();
            lblUsername.Text = Employee.UserName;
            // lblPassword.Text = Employee.Password;
            Person = clsPerson.Find(Employee.PersonID);

            if (Person.Gender == 0)
                pbPersonImage.Image = Resources.female_student;
            else
                pbPersonImage.Image = Resources.man__1_;

            string ImagePath = Person.ImagePath;
            if (ImagePath != "")
                if (File.Exists(ImagePath))
                    pbPersonImage.ImageLocation = ImagePath;
                else
                    MessageBox.Show("Could not find this image: = " + ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //   llEditPersonInfo.Enabled = true;

            lblPersonID.Text = Person.PersonID.ToString();
            lblHomePhone.Text = Person.HomePhone;
            lblFullName.Text = Person.FullName;
            lblGender.Text = Person.Gender == 1 ? "Male" : "Female";
            lblEmail.Text = Person.Email;
            lblPhone.Text = Person.Phone;
            lblBirthOfDate.Text = Person.BirthOfDate.ToShortDateString();
            lblAddress.Text = Person.Address;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Minimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;  
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txt_CurrentPassword.Text == Employee.Password)
            {
                if (txt_NewPassword.Text == txt_ConfirmPassword.Text)
                {
                    Employee.ChangePassword(Employee.EmployeeID, txt_NewPassword.Text);
                    MessageBox.Show("Change Password Sucssfull", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Employee.Password = txt_NewPassword.Text;
                    txt_ConfirmPassword.Text = txt_CurrentPassword.Text = txt_NewPassword.Text = "";
                }
                else
                {
                    {
                        MessageBox.Show("Confrim password not matching with new password", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        txt_NewPassword.Text = txt_ConfirmPassword.Text = "";
                    }
                }
            }
            else
            {
                MessageBox.Show("Current password is not true", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                txt_CurrentPassword.Text = "";
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
