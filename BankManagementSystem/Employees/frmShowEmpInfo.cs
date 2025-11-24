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
using Bank.Properties;
using Bank_Business;
namespace Bank
{
    public partial class frmShowEmpInfo : Form
    {
        clsEmployee Employee=new clsEmployee();
        clsPerson Person=new clsPerson();
        
        public frmShowEmpInfo()
        {
            InitializeComponent();
            Employee=clsGlobal.CurrentEmployee;
        }

        public frmShowEmpInfo(clsEmployee emp)
        {
            InitializeComponent();
            Employee =emp;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Minimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void frmShowEmpInfo_Load(object sender, EventArgs e)
        {
            lblEmployeeID.Text = Employee.EmployeeID.ToString();
            lblUsername.Text = Employee.UserName;
            cb_IsActive.Checked= Employee.IsActive;
            lblPermissions.Text=Employee.Permissons.ToString();
            ChecKPermissions();
           // lblPassword.Text = Employee.Password;
            Person=clsPerson.Find(Employee.PersonID);

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
        public void ChecKPermissions()
        {

            if (Employee.Permissons == 65535)
            {
               
                cb_ShowEmployees.Checked = true;
                cb_ShowClients.Checked = true;
                cb_AddEmployee.Checked = true;
                cb_AddEmployeesLog.Checked = true;
                cb_UpdateEmployees.Checked = true;
                cb_UpdateEmployeesLog.Checked = true;
                cb_DeleteEmployee.Checked = true;
                cb_DeleteEmployeesLog.Checked = true;
                cb_AddClient.Checked = true;
                cb_AddClientsLog.Checked = true;
                cb_UpdateClient.Checked = true;
                cb_UpdateClientsLog.Checked = true;
                cb_DeleteClient.Checked = true;
                cb_DeleteClientsLog.Checked = true;
                cb_Transfer.Checked = true;
                cb_TransactionsLog.Checked = true;
            }
            else
            {
                if (clsValidatoin.CheckAccessPermission(clsValidatoin.enPermissions.pShowEmployees, Employee))
                    cb_ShowEmployees.Checked = true;
                if (clsValidatoin.CheckAccessPermission(clsValidatoin.enPermissions.pShowClients, Employee))
                    cb_ShowClients.Checked = true;
                if (clsValidatoin.CheckAccessPermission(clsValidatoin.enPermissions.pAddEmployee, Employee))
                    cb_AddEmployee.Checked = true;
                if (clsValidatoin.CheckAccessPermission(clsValidatoin.enPermissions.pAddEmployeesLog, Employee))
                    cb_AddEmployeesLog.Checked = true;
                if (clsValidatoin.CheckAccessPermission(clsValidatoin.enPermissions.pUpdateEmployee, Employee))
                    cb_UpdateEmployees.Checked = true;
                if (clsValidatoin.CheckAccessPermission(clsValidatoin.enPermissions.pUpdateEmployeesLog, Employee))
                    cb_UpdateEmployeesLog.Checked = true;
                if (clsValidatoin.CheckAccessPermission(clsValidatoin.enPermissions.PDeleteEmployee, Employee))
                    cb_DeleteEmployee.Checked = true;
                if (clsValidatoin.CheckAccessPermission(clsValidatoin.enPermissions.PDeleteEmployeesLog, Employee))
                    cb_DeleteEmployeesLog.Checked = true;
                if (clsValidatoin.CheckAccessPermission(clsValidatoin.enPermissions.pAddClient, Employee))
                    cb_AddClient.Checked = true;
                if (clsValidatoin.CheckAccessPermission(clsValidatoin.enPermissions.pAddClientsLog, Employee))
                    cb_AddClientsLog.Checked = true;
                if (clsValidatoin.CheckAccessPermission(clsValidatoin.enPermissions.pUpdateClient, Employee))
                    cb_UpdateClient.Checked = true;
                if (clsValidatoin.CheckAccessPermission(clsValidatoin.enPermissions.pUpdateClientsLog, Employee))
                    cb_UpdateClientsLog.Checked = true;
                if (clsValidatoin.CheckAccessPermission(clsValidatoin.enPermissions.PDeleteClient, Employee))
                    cb_DeleteClient.Checked = true;
                if (clsValidatoin.CheckAccessPermission(clsValidatoin.enPermissions.PDeleteClientsLog, Employee))
                    cb_DeleteClientsLog.Checked = true;
                if (clsValidatoin.CheckAccessPermission(clsValidatoin.enPermissions.PTransfer, Employee))
                    cb_Transfer.Checked = true;
                if (clsValidatoin.CheckAccessPermission(clsValidatoin.enPermissions.pTransactionsLog, Employee))
                    cb_TransactionsLog.Checked = true;
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void cb_DeleteEmployee_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
