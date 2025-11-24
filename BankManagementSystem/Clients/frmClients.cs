using Bank.Clients;
using Bank_Business;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;



namespace Bank
{
    public partial class frmClients : Form
    {

        private static DataTable _dtAllClients=clsClient.GetAllClients();

        private DataTable _dtClients = _dtAllClients.DefaultView.ToTable(true, "ClientID","FullName",
                                                       "AccountBalance", "AccountID", "PersonID", "IsActive");

        

        public frmClients()
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

        private void frmClients_Load(object sender, EventArgs e)
        {
            dgvClients.DataSource = _dtClients;
            //cbFilterBy.SelectedIndex = 0;
            //lblRecordsCount.Text = dgvClients.Rows.Count.ToString();
            if (dgvClients.Rows.Count > 0)
            {

                //lblRecordsCount.Text = dgvClients.Rows.Count.ToString();

                dgvClients.Columns[0].HeaderText = "Client ID";
                dgvClients.Columns[0].Width = 100;


                dgvClients.Columns[1].HeaderText = "Full Name";
                dgvClients.Columns[1].Width = 400; 
                
                dgvClients.Columns[2].HeaderText = "Account Balance";
                dgvClients.Columns[2].Width = 220;

                dgvClients.Columns[3].HeaderText = "Account ID";
                dgvClients.Columns[3].Width = 170;

                dgvClients.Columns[4].HeaderText = "Person ID";
                dgvClients.Columns[4].Width = 130;

                dgvClients.Columns[5].HeaderText = "Is Active";
                dgvClients.Columns[5].Width = 130;
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            frmAddClients frm = new frmAddClients();
            frm.ShowDialog();
        }
    }
}
