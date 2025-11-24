using Bank.Employees;
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
    public partial class frmEmployees : Form
    {
      
        private static DataTable _dtAllEmployees=clsEmployee.GetAllEmployees();

        private DataTable _dtEmployees = _dtAllEmployees.DefaultView.ToTable(false, "EmployeeID",
                                                       "UserName", "FullName","Permissions" ,"PersonID", "IsActive");

        private void _RefreshEmployeesList()
        {
            _dtAllEmployees = clsEmployee.GetAllEmployees();
            _dtEmployees = _dtAllEmployees.DefaultView.ToTable(false, "EmployeeID",
                                                       "UserName", "FullName","Permissions" ,"PersonID", "IsActive");
            dgvEmployees.DataSource = _dtEmployees;
            lblRecordsCount.Text = dgvEmployees.Rows.Count.ToString();
        }
        public frmEmployees()
        {
            InitializeComponent();
        }



        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Minimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void frmEmployees_Load(object sender, EventArgs e)
        {
          
            dgvEmployees.DataSource = _dtEmployees;
            cbFilterBy.SelectedIndex = 0;
            lblRecordsCount.Text = dgvEmployees.Rows.Count.ToString();
            if (dgvEmployees.Rows.Count > 0)
            {
               
                lblRecordsCount.Text = dgvEmployees.Rows.Count.ToString();

                dgvEmployees.Columns[0].HeaderText = "Employee ID";
                dgvEmployees.Columns[0].Width = 100;

                dgvEmployees.Columns[1].HeaderText = "UserName";
                dgvEmployees.Columns[1].Width = 220;

                dgvEmployees.Columns[2].HeaderText = "Full Name";
                dgvEmployees.Columns[2].Width = 400;

                dgvEmployees.Columns[3].HeaderText = "Permissions";
                dgvEmployees.Columns[3].Width = 170;

                dgvEmployees.Columns[4].HeaderText = "Person ID";
                dgvEmployees.Columns[4].Width = 130;

                dgvEmployees.Columns[5].HeaderText = "Is Active";
                dgvEmployees.Columns[5].Width = 130;
            }
        }

      
        private void dgvEmployees_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        { 
            int EmpID = ((int)dgvEmployees.CurrentRow.Cells[0].Value);
            clsEmployee emp = clsEmployee.Find(EmpID);
            frmShowEmpInfo frm = new frmShowEmpInfo(emp);
            frm.ShowDialog();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterBy.Text == "Is Active")
            {
                txtFilterValue.Visible = false;
                cbIsActive.Visible = true;
                cbIsActive.Focus();
                cbIsActive.SelectedIndex = 0;
            }

            else

            {

                txtFilterValue.Visible = (cbFilterBy.Text != "None");
                cbIsActive.Visible = false;

                if (cbFilterBy.Text == "None")
                {
                    txtFilterValue.Enabled = false;
                }
                else
                    txtFilterValue.Enabled = true;

                txtFilterValue.Text = "";
                txtFilterValue.Focus();
            }


        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            //Map Selected Filter to real Column name 
            switch (cbFilterBy.Text)
            {
                case "Person ID":
                    FilterColumn = "PersonID";
                    break;

                case "Employee ID":
                    FilterColumn = "EmployeeID";
                    break;

                case "User Name":
                    FilterColumn = "UserName";
                    break;

                case "Full Name":
                    FilterColumn = "FullName";
                    break;

                default:
                    FilterColumn = "None";
                    break;
            }
             if (txtFilterValue.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtEmployees.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvEmployees.Rows.Count.ToString();
                return;
            }


            if (FilterColumn == "PersonID"||FilterColumn=="EmployeeID")
                //in this case we deal with integer not string.

                _dtEmployees.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());
           
            else
                _dtEmployees.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());

            lblRecordsCount.Text = dgvEmployees.Rows.Count.ToString();
           
        }

        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColumn = "IsActive";
            string FilterValue = cbIsActive.Text;

            switch (FilterValue)
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
                _dtEmployees.DefaultView.RowFilter = "";
            else
                //in this case we deal with numbers not string.
                _dtEmployees.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, FilterValue);

            lblRecordsCount.Text = dgvEmployees.Rows.Count.ToString();

        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int EmpID = ((int)dgvEmployees.CurrentRow.Cells[0].Value);
            clsEmployee emp = clsEmployee.Find(EmpID);
            frmShowEmpInfo frm = new frmShowEmpInfo(emp);
            frm.ShowDialog();
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (clsValidatoin.CheckAccessPermission(clsValidatoin.enPermissions.pAddEmployee))
            {
                frmAddUpdateEmployees frmAddUpdateEmp = new frmAddUpdateEmployees();
                frmAddUpdateEmp.ShowDialog();
                _RefreshEmployeesList();
            }
            else
                MessageBox.Show("Access Denied! Contact your Admin.", "failed", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }
        private void Add_NewEmpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsValidatoin.CheckAccessPermission(clsValidatoin.enPermissions.pAddEmployee))
            {
                frmAddUpdateEmployees frmAddUpdateEmp = new frmAddUpdateEmployees();
                frmAddUpdateEmp.ShowDialog();
                _RefreshEmployeesList();
            }
            else
                MessageBox.Show("Access Denied! Contact your Admin.", "failed", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsValidatoin.CheckAccessPermission(clsValidatoin.enPermissions.pUpdateEmployee))
            {
                frmAddUpdateEmployees frm = new frmAddUpdateEmployees((int)dgvEmployees.CurrentRow.Cells[0].Value);
                frm.ShowDialog();
                _RefreshEmployeesList();
            }
            else
                MessageBox.Show("Access Denied! Contact your Admin.", "failed", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsValidatoin.CheckAccessPermission(clsValidatoin.enPermissions.PDeleteEmployee))
            {
                if (dgvEmployees.CurrentRow.Cells[5].Value.Equals(false))
                    MessageBox.Show("this Employee is already deleted.", "failed", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                else
                {
                    clsEmployee.DeleteEmployee((int)dgvEmployees.CurrentRow.Cells[0].Value, clsGlobal.CurrentEmployee.EmployeeID);
                    _RefreshEmployeesList();
                }
            }
            else
            MessageBox.Show("Access Denied! Contact your Admin.", "failed", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }

        private void ActivateEmptoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (clsValidatoin.CheckAccessPermission(clsValidatoin.enPermissions.pUpdateEmployee))
            {
                if (dgvEmployees.CurrentRow.Cells[5].Value.Equals(true))
                    MessageBox.Show("this Employee is already Active.", "failed", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                else
                {
                    clsEmployee.ActiveEmployee((int)dgvEmployees.CurrentRow.Cells[0].Value, clsGlobal.CurrentEmployee.EmployeeID);
                    _RefreshEmployeesList();
                }
              
            }
            else
                MessageBox.Show("Access Denied! Contact your Admin.", "failed", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }
    }
}
