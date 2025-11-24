using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bank_Business;

namespace Bank.Employees
{
   
    public partial class frmAddUpdateEmployees : Form
    {


        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        private Nullable<int> _EmployeeID = null;
        clsEmployee _Employee;

        bool IsFound = false;
        public frmAddUpdateEmployees()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }
        public frmAddUpdateEmployees(Nullable<int> EmpID)
        {
            InitializeComponent();
            _EmployeeID = EmpID;
          _Mode = enMode.Update;
           
        }

        private void _ResetDefualtValues()
        {
            //this will initialize the reset the defaule values

            if (_Mode == enMode.AddNew)
            {
                lbl_header.Text = "Add New Employee";
              
                _Employee = new clsEmployee();

                tpLoginInfo.Enabled = false;

             
            }
            else
            {
                lbl_header.Text = "Update User";
               
                tpLoginInfo.Enabled = true;
                btn_Save.Enabled = true;
                txt_PersonID.Enabled = false;
                btn_AddPerson.Enabled = false;
                btn_search.Enabled = false;
            }

            txtUserName.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            chkIsActive.Checked = true;


        }
        private void _LoadData()
        {
            _Employee = clsEmployee.Find(_EmployeeID);

            if (_Employee == null)
            {
                MessageBox.Show("No User with ID = " + _EmployeeID, "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();

                return;
            }

            //the following code will not be executed if the person was not found
            lblUserID.Text = _Employee.EmployeeID.ToString();
            txtUserName.Text = _Employee.UserName;
            txtPassword.Text = clsEncryptionAndDecrypyion.Decrypt(_Employee.Password);
            txtConfirmPassword.Text = clsEncryptionAndDecrypyion.Decrypt(_Employee.Password);
            chkIsActive.Checked = _Employee.IsActive;
            ctrlPersonCard1.LoadPersonInfo(_Employee.PersonID);
           
        }
        private void frmAddUpdateEmployees_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();

            if (_Mode == enMode.Update)
            {
                _LoadData();

                ChecKPermissions();

            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_PersonID.Text))
            { 
                IsFound = clsPerson.IsPersonExist(int.Parse(txt_PersonID.Text));
                if (IsFound)
                    ctrlPersonCard1.LoadPersonInfo(int.Parse(txt_PersonID.Text));
                else
                    MessageBox.Show("Please Select a Person, this ID doesn`t exist", "Select a Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            
                MessageBox.Show("Please Select a Person", "Select a Person", MessageBoxButtons.OK, MessageBoxIcon.Error);

            
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtConfirmPassword.Text.Trim() != txtPassword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "Password Confirmation does not match Password!");
            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword, null);
            };

        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPassword, "Password cannot be blank");
            }
            else
            {
                errorProvider1.SetError(txtPassword, null);
            };

        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUserName, "Username cannot be blank");
                return;
            }
            else
            {
                errorProvider1.SetError(txtUserName, null);
            };


            if (_Mode == enMode.AddNew)
            {

                if (clsEmployee.IsEmployeeExistByUserName(txtUserName.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtUserName, "username is used by another user");
                }
                else
                {
                    errorProvider1.SetError(txtUserName, null);
                };
            }
            else
            {
                //incase update make sure not to use anothers user name
                if (_Employee.UserName != txtUserName.Text.Trim())
                {
                    if (clsEmployee.IsEmployeeExistByUserName(txtUserName.Text.Trim()))
                    {
                        e.Cancel = true;
                        errorProvider1.SetError(txtUserName, "username is used by another user");
                        return;
                    }
                    else
                    {
                        errorProvider1.SetError(txtUserName, null);
                    };
                }
            }
        }


        private void btn_AddPerson_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm= new frmAddUpdatePerson();
            frm.ShowDialog();
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.Update)
            {
                btn_Save.Enabled = true;
                tpLoginInfo.Enabled = true;
                tcEmployeeInfo.SelectedTab = tcEmployeeInfo.TabPages["tpLoginInfo"];
                return;
            }

            //incase of add new mode.
            if (ctrlPersonCard1.PersonID !=null)
            {

                if (clsEmployee.IsEmployeeExistByPersonID(ctrlPersonCard1.PersonID))
                {

                    MessageBox.Show("Selected Person already has a user, choose another one.", "Select another Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    btn_Save.Enabled = true;
                    tpLoginInfo.Enabled = true;
                    tcEmployeeInfo.SelectedTab = tcEmployeeInfo.TabPages["tpLoginInfo"];
                }
            }

            else

            {
                MessageBox.Show("Please Select a Person", "Select a Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                

            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Minimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            _Employee.PersonID = ctrlPersonCard1.PersonID;
            _Employee.UserName = txtUserName.Text.Trim();
            _Employee.Password = txtPassword.Text.Trim();
            _Employee.IsActive = chkIsActive.Checked;
           

            if (_Employee.Save(clsGlobal.CurrentEmployee.EmployeeID))
            {
                lblUserID.Text = _Employee.EmployeeID.ToString();
                //change form mode to update.
                _Mode = enMode.Update;
                lbl_header.Text = "Update User";
                this.Text = "Update User";

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btn_Cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_PersonID_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is Enter (character code 13)
            if (e.KeyChar == (char)13)
            {

                btn_search.PerformClick();
            }

            //this will allow only digits if person id is selected
          
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }


        public void cb_All_CheckedChanged(object sender, EventArgs e)
        {
            
            cb_ShowClients.Checked=true;
            cb_ShowEmployees.Checked=true;
            cb_AddEmployee.Checked=true;
            cb_AddEmployeesLog.Checked=true;
            cb_UpdateEmployees.Checked = true;
            cb_UpdateEmployeesLog.Checked=true;
            cb_DeleteEmployee.Checked=true;
            cb_DeleteEmployeesLog.Checked=true;
            cb_AddClient.Checked=true;
            cb_AddClientsLog.Checked=true;
            cb_UpdateClient.Checked=true;
            cb_UpdateClientsLog.Checked=true;
            cb_DeleteClient.Checked=true;
            cb_DeleteClientsLog.Checked=true;
            cb_Transfer.Checked=true;
            cb_TransactionsLog.Checked=true;
            _Employee.Permissons = 65535;
           
        }
        public void ChecKPermissions()
        {
          
            if(_Employee.Permissons== 65535)
            {
                cb_All.Checked=true;
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
            else { 
            if (clsValidatoin.CheckAccessPermission(clsValidatoin.enPermissions.pShowEmployees, _Employee))
                cb_ShowEmployees.Checked = true;
            if (clsValidatoin.CheckAccessPermission(clsValidatoin.enPermissions.pShowClients, _Employee))
                cb_ShowClients.Checked = true; 
            if (clsValidatoin.CheckAccessPermission(clsValidatoin.enPermissions.pAddEmployee, _Employee))
                cb_AddEmployee.Checked=true;
            if (clsValidatoin.CheckAccessPermission(clsValidatoin.enPermissions.pAddEmployeesLog, _Employee))
                cb_AddEmployeesLog.Checked=true;
            if (clsValidatoin.CheckAccessPermission(clsValidatoin.enPermissions.pUpdateEmployee, _Employee))
                cb_UpdateEmployees.Checked=true;
            if (clsValidatoin.CheckAccessPermission(clsValidatoin.enPermissions.pUpdateEmployeesLog, _Employee))
                cb_UpdateEmployeesLog.Checked=true;
            if (clsValidatoin.CheckAccessPermission(clsValidatoin.enPermissions.PDeleteEmployee, _Employee))
                cb_DeleteEmployee.Checked=true;
            if (clsValidatoin.CheckAccessPermission(clsValidatoin.enPermissions.PDeleteEmployeesLog, _Employee))
                cb_DeleteEmployeesLog.Checked=true;
            if (clsValidatoin.CheckAccessPermission(clsValidatoin.enPermissions.pAddClient, _Employee))
                cb_AddClient.Checked=true;
            if (clsValidatoin.CheckAccessPermission(clsValidatoin.enPermissions.pAddClientsLog, _Employee))
                cb_AddClientsLog.Checked=true;
            if (clsValidatoin.CheckAccessPermission(clsValidatoin.enPermissions.pUpdateClient, _Employee))
                cb_UpdateClient.Checked=true;
            if (clsValidatoin.CheckAccessPermission(clsValidatoin.enPermissions.pUpdateClientsLog, _Employee))
                cb_UpdateClientsLog.Checked=true;
            if (clsValidatoin.CheckAccessPermission(clsValidatoin.enPermissions.PDeleteClient, _Employee))
                cb_DeleteClient.Checked=true;
            if (clsValidatoin.CheckAccessPermission(clsValidatoin.enPermissions.PDeleteClientsLog, _Employee))
                cb_DeleteClientsLog.Checked=true;
            if (clsValidatoin.CheckAccessPermission(clsValidatoin.enPermissions.PTransfer, _Employee))
                cb_Transfer.Checked=true;
            if (clsValidatoin.CheckAccessPermission(clsValidatoin.enPermissions.pTransactionsLog, _Employee))
                cb_TransactionsLog.Checked=true;
            }
        }

        private void CheckBox_Click(object sender, EventArgs e)
        {

                if (((CheckBox)sender).Checked)
               
                        _Employee.Permissons += int.Parse(((CheckBox)sender).Tag.ToString());
               
                else
                
                    _Employee.Permissons -= int.Parse(((CheckBox)sender).Tag.ToString());
        }
    }
}
