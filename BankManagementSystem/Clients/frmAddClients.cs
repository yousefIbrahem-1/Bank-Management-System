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

namespace Bank.Clients
{
    public partial class frmAddClients : Form
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        private Nullable<int> _EmployeeID = null;
        clsClient _Client=new clsClient();

        private static DataTable _dtAllAccounts=clsClient.GetAllAccounts().DefaultView.ToTable(false, "ID",
                                                       "Name", "Requirements", "Description", "InterestRate", "Duration");
        bool IsFound = false;
        public frmAddClients()
        {
            InitializeComponent();
            tpClientInfo.Enabled=false;
        }
        private void loadAccounts()
        {
            for (int i = 0; i < _dtAllAccounts.Rows.Count; i++)
            {
                cb_Accounts.Items.Add(_dtAllAccounts.Rows[i][0].ToString());
            }
        }
        private void btn_search_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_PersonID.Text))
            {
                IsFound = clsPerson.IsPersonExist(int.Parse(txt_PersonID.Text));
                if (IsFound)
                {
                    ctrlPersonCard1.LoadPersonInfo(int.Parse(txt_PersonID.Text));
                    tpClientInfo.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Please Select a Person, this ID doesn`t exist", "Select a Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tpClientInfo.Enabled = false;
                }
            }
            else

                MessageBox.Show("Please Select a Person", "Select a Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btn_AddPerson_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson();
            frm.ShowDialog();
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

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Minimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void frmAddClients_Load(object sender, EventArgs e)
        {
            loadAccounts();
        }

        private void cb_Accounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexRow = cb_Accounts.SelectedIndex;
            lbl_description.Text = _dtAllAccounts.Rows[indexRow]["Description"].ToString();
            lbl_Requirements.Text = _dtAllAccounts.Rows[indexRow]["Requirements"].ToString();


        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
              if (ctrlPersonCard1.PersonID !=null)
            {

                if (clsClient.IsClientExistByPersonID(ctrlPersonCard1.PersonID))
                {

                    MessageBox.Show("Selected Person already has a user, choose another one.", "Select another Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    btn_Save.Enabled = true;
                    tpClientInfo.Enabled = true;
                    tcClientInfo.SelectedTab = tcClientInfo.TabPages["tpClientInfo"];
                }
            }

            else

            {
                MessageBox.Show("Please Select a Person", "Select a Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                

            }
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

            _Client.PersonID = ctrlPersonCard1.PersonID;
            _Client.AccountID = int.Parse(cb_Accounts.SelectedItem.ToString());
            _Client.AccountBalance = decimal.Parse(txt_AccountBalance.Text);



            if (_Client.AddNewClient(clsGlobal.CurrentEmployee.EmployeeID))
            {
                lblUserID.Text = _Client.ClientID.ToString();
                //change form mode to update.
                _Mode = enMode.Update;
                lbl_header.Text = "Update User";
                this.Text = "Update User";

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void txt_AccountBalance_Validating(object sender, CancelEventArgs e)
        {
            if (decimal.Parse(txt_AccountBalance.Text)<200)
            {
                e.Cancel = true;
                errorProvider1.SetError(txt_AccountBalance, "Balance should be greater than or equal 200");
                return;
            }
            else
            {
                errorProvider1.SetError(txt_AccountBalance, null);
            }
            ;
        }
    }
}
