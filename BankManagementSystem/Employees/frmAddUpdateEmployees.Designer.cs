namespace Bank.Employees
{
    partial class frmAddUpdateEmployees
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.customPanel1 = new Bank.CustomPanel();
            this.btn_Minimized = new Bank.RoundedButton();
            this.btn_Cancle = new Bank.RoundedButton();
            this.btn_Close = new Bank.RoundedButton();
            this.btn_Save = new Bank.RoundedButton();
            this.lbl_header = new System.Windows.Forms.Label();
            this.tcEmployeeInfo = new System.Windows.Forms.TabControl();
            this.tpPersonInfo = new System.Windows.Forms.TabPage();
            this.customPanel2 = new Bank.CustomPanel();
            this.btn_AddPerson = new Bank.RoundedButton();
            this.btn_search = new Bank.RoundedButton();
            this.btn_Next = new Bank.RoundedButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_PersonID = new System.Windows.Forms.TextBox();
            this.ctrlPersonCard1 = new Bank.ctrlPersonCard();
            this.tpLoginInfo = new System.Windows.Forms.TabPage();
            this.customPanel3 = new Bank.CustomPanel();
            this.cb_UpdateEmployeesLog = new System.Windows.Forms.CheckBox();
            this.cb_UpdateEmployees = new System.Windows.Forms.CheckBox();
            this.cb_DeleteEmployeesLog = new System.Windows.Forms.CheckBox();
            this.cb_AddEmployeesLog = new System.Windows.Forms.CheckBox();
            this.cb_Transfer = new System.Windows.Forms.CheckBox();
            this.cb_TransactionsLog = new System.Windows.Forms.CheckBox();
            this.cb_UpdateClientsLog = new System.Windows.Forms.CheckBox();
            this.cb_ShowClients = new System.Windows.Forms.CheckBox();
            this.cb_DeleteClientsLog = new System.Windows.Forms.CheckBox();
            this.cb_DeleteClient = new System.Windows.Forms.CheckBox();
            this.cb_AddClientsLog = new System.Windows.Forms.CheckBox();
            this.cb_UpdateClient = new System.Windows.Forms.CheckBox();
            this.cb_AddClient = new System.Windows.Forms.CheckBox();
            this.cb_ShowEmployees = new System.Windows.Forms.CheckBox();
            this.cb_DeleteEmployee = new System.Windows.Forms.CheckBox();
            this.cb_AddEmployee = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_All = new System.Windows.Forms.CheckBox();
            this.gradientPanel2 = new Bank.CustomPanel();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUserID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.customPanel1.SuspendLayout();
            this.tcEmployeeInfo.SuspendLayout();
            this.tpPersonInfo.SuspendLayout();
            this.customPanel2.SuspendLayout();
            this.tpLoginInfo.SuspendLayout();
            this.customPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // customPanel1
            // 
            this.customPanel1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.customPanel1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.customPanel1.Controls.Add(this.btn_Minimized);
            this.customPanel1.Controls.Add(this.btn_Cancle);
            this.customPanel1.Controls.Add(this.btn_Close);
            this.customPanel1.Controls.Add(this.btn_Save);
            this.customPanel1.Controls.Add(this.lbl_header);
            this.customPanel1.Controls.Add(this.tcEmployeeInfo);
            this.customPanel1.CornerRadius = 0;
            this.customPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customPanel1.Location = new System.Drawing.Point(0, 0);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(907, 571);
            this.customPanel1.TabIndex = 0;
            // 
            // btn_Minimized
            // 
            this.btn_Minimized.BackColor = System.Drawing.Color.Transparent;
            this.btn_Minimized.BorderRadius = 10;
            this.btn_Minimized.FlatAppearance.BorderSize = 0;
            this.btn_Minimized.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Plum;
            this.btn_Minimized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Minimized.ForeColor = System.Drawing.Color.White;
            this.btn_Minimized.Image = global::Bank.Properties.Resources.cancel;
            this.btn_Minimized.Location = new System.Drawing.Point(806, 4);
            this.btn_Minimized.Name = "btn_Minimized";
            this.btn_Minimized.Size = new System.Drawing.Size(46, 48);
            this.btn_Minimized.TabIndex = 6;
            this.btn_Minimized.UseVisualStyleBackColor = false;
            this.btn_Minimized.Click += new System.EventHandler(this.btn_Minimized_Click);
            // 
            // btn_Cancle
            // 
            this.btn_Cancle.BackColor = System.Drawing.Color.Transparent;
            this.btn_Cancle.BorderRadius = 5;
            this.btn_Cancle.FlatAppearance.BorderSize = 0;
            this.btn_Cancle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Plum;
            this.btn_Cancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancle.ForeColor = System.Drawing.Color.White;
            this.btn_Cancle.Location = new System.Drawing.Point(340, 522);
            this.btn_Cancle.Name = "btn_Cancle";
            this.btn_Cancle.Size = new System.Drawing.Size(102, 39);
            this.btn_Cancle.TabIndex = 4;
            this.btn_Cancle.Text = "Cancle";
            this.btn_Cancle.UseVisualStyleBackColor = false;
            this.btn_Cancle.Click += new System.EventHandler(this.btn_Cancle_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Transparent;
            this.btn_Close.BorderRadius = 10;
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Plum;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.ForeColor = System.Drawing.Color.White;
            this.btn_Close.Image = global::Bank.Properties.Resources.close__1_;
            this.btn_Close.Location = new System.Drawing.Point(858, 4);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(46, 48);
            this.btn_Close.TabIndex = 7;
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.Transparent;
            this.btn_Save.BorderRadius = 5;
            this.btn_Save.FlatAppearance.BorderSize = 0;
            this.btn_Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Plum;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(466, 522);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(102, 39);
            this.btn_Save.TabIndex = 3;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // lbl_header
            // 
            this.lbl_header.AutoSize = true;
            this.lbl_header.BackColor = System.Drawing.Color.Transparent;
            this.lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_header.ForeColor = System.Drawing.Color.White;
            this.lbl_header.Location = new System.Drawing.Point(315, 9);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(292, 46);
            this.lbl_header.TabIndex = 1;
            this.lbl_header.Text = "Add Employee";
            // 
            // tcEmployeeInfo
            // 
            this.tcEmployeeInfo.Controls.Add(this.tpPersonInfo);
            this.tcEmployeeInfo.Controls.Add(this.tpLoginInfo);
            this.tcEmployeeInfo.Location = new System.Drawing.Point(3, 58);
            this.tcEmployeeInfo.Name = "tcEmployeeInfo";
            this.tcEmployeeInfo.SelectedIndex = 0;
            this.tcEmployeeInfo.Size = new System.Drawing.Size(900, 456);
            this.tcEmployeeInfo.TabIndex = 0;
            // 
            // tpPersonInfo
            // 
            this.tpPersonInfo.Controls.Add(this.customPanel2);
            this.tpPersonInfo.Controls.Add(this.ctrlPersonCard1);
            this.tpPersonInfo.Location = new System.Drawing.Point(4, 25);
            this.tpPersonInfo.Name = "tpPersonInfo";
            this.tpPersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpPersonInfo.Size = new System.Drawing.Size(892, 427);
            this.tpPersonInfo.TabIndex = 0;
            this.tpPersonInfo.Text = "Person Information";
            this.tpPersonInfo.UseVisualStyleBackColor = true;
            // 
            // customPanel2
            // 
            this.customPanel2.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.customPanel2.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.customPanel2.Controls.Add(this.btn_AddPerson);
            this.customPanel2.Controls.Add(this.btn_search);
            this.customPanel2.Controls.Add(this.btn_Next);
            this.customPanel2.Controls.Add(this.label1);
            this.customPanel2.Controls.Add(this.txt_PersonID);
            this.customPanel2.CornerRadius = 0;
            this.customPanel2.Location = new System.Drawing.Point(-1, 3);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Size = new System.Drawing.Size(893, 49);
            this.customPanel2.TabIndex = 1;
            // 
            // btn_AddPerson
            // 
            this.btn_AddPerson.BorderRadius = 3;
            this.btn_AddPerson.FlatAppearance.BorderSize = 2;
            this.btn_AddPerson.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Plum;
            this.btn_AddPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddPerson.ForeColor = System.Drawing.Color.White;
            this.btn_AddPerson.Image = global::Bank.Properties.Resources.add_user__4_;
            this.btn_AddPerson.Location = new System.Drawing.Point(578, 5);
            this.btn_AddPerson.Name = "btn_AddPerson";
            this.btn_AddPerson.Size = new System.Drawing.Size(45, 35);
            this.btn_AddPerson.TabIndex = 5;
            this.btn_AddPerson.UseVisualStyleBackColor = true;
            this.btn_AddPerson.Click += new System.EventHandler(this.btn_AddPerson_Click);
            // 
            // btn_search
            // 
            this.btn_search.BorderRadius = 3;
            this.btn_search.FlatAppearance.BorderSize = 2;
            this.btn_search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Plum;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Image = global::Bank.Properties.Resources.search;
            this.btn_search.Location = new System.Drawing.Point(510, 5);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(45, 35);
            this.btn_search.TabIndex = 4;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.BackColor = System.Drawing.Color.Transparent;
            this.btn_Next.BorderRadius = 5;
            this.btn_Next.FlatAppearance.BorderSize = 0;
            this.btn_Next.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Plum;
            this.btn_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Next.ForeColor = System.Drawing.Color.White;
            this.btn_Next.Location = new System.Drawing.Point(779, 8);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(102, 30);
            this.btn_Next.TabIndex = 2;
            this.btn_Next.Text = "Next";
            this.btn_Next.UseVisualStyleBackColor = false;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Person ID :";
            // 
            // txt_PersonID
            // 
            this.txt_PersonID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txt_PersonID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_PersonID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PersonID.ForeColor = System.Drawing.Color.White;
            this.txt_PersonID.Location = new System.Drawing.Point(183, 7);
            this.txt_PersonID.Name = "txt_PersonID";
            this.txt_PersonID.Size = new System.Drawing.Size(294, 30);
            this.txt_PersonID.TabIndex = 1;
            this.txt_PersonID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_PersonID_KeyPress);
            // 
            // ctrlPersonCard1
            // 
            this.ctrlPersonCard1.Location = new System.Drawing.Point(-1, 56);
            this.ctrlPersonCard1.Name = "ctrlPersonCard1";
            this.ctrlPersonCard1.Size = new System.Drawing.Size(893, 374);
            this.ctrlPersonCard1.TabIndex = 0;
            // 
            // tpLoginInfo
            // 
            this.tpLoginInfo.Controls.Add(this.customPanel3);
            this.tpLoginInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tpLoginInfo.Location = new System.Drawing.Point(4, 25);
            this.tpLoginInfo.Name = "tpLoginInfo";
            this.tpLoginInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpLoginInfo.Size = new System.Drawing.Size(892, 427);
            this.tpLoginInfo.TabIndex = 1;
            this.tpLoginInfo.Text = "Employee Infoemation";
            this.tpLoginInfo.UseVisualStyleBackColor = true;
            // 
            // customPanel3
            // 
            this.customPanel3.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.customPanel3.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.customPanel3.Controls.Add(this.cb_UpdateEmployeesLog);
            this.customPanel3.Controls.Add(this.cb_UpdateEmployees);
            this.customPanel3.Controls.Add(this.cb_DeleteEmployeesLog);
            this.customPanel3.Controls.Add(this.cb_AddEmployeesLog);
            this.customPanel3.Controls.Add(this.cb_Transfer);
            this.customPanel3.Controls.Add(this.cb_TransactionsLog);
            this.customPanel3.Controls.Add(this.cb_UpdateClientsLog);
            this.customPanel3.Controls.Add(this.cb_ShowClients);
            this.customPanel3.Controls.Add(this.cb_DeleteClientsLog);
            this.customPanel3.Controls.Add(this.cb_DeleteClient);
            this.customPanel3.Controls.Add(this.cb_AddClientsLog);
            this.customPanel3.Controls.Add(this.cb_UpdateClient);
            this.customPanel3.Controls.Add(this.cb_AddClient);
            this.customPanel3.Controls.Add(this.cb_ShowEmployees);
            this.customPanel3.Controls.Add(this.cb_DeleteEmployee);
            this.customPanel3.Controls.Add(this.cb_AddEmployee);
            this.customPanel3.Controls.Add(this.label6);
            this.customPanel3.Controls.Add(this.cb_All);
            this.customPanel3.Controls.Add(this.gradientPanel2);
            this.customPanel3.Controls.Add(this.txtConfirmPassword);
            this.customPanel3.Controls.Add(this.txtPassword);
            this.customPanel3.Controls.Add(this.txtUserName);
            this.customPanel3.Controls.Add(this.lblUserID);
            this.customPanel3.Controls.Add(this.label4);
            this.customPanel3.Controls.Add(this.chkIsActive);
            this.customPanel3.Controls.Add(this.label2);
            this.customPanel3.Controls.Add(this.label3);
            this.customPanel3.Controls.Add(this.label5);
            this.customPanel3.CornerRadius = 0;
            this.customPanel3.Location = new System.Drawing.Point(-4, 0);
            this.customPanel3.Name = "customPanel3";
            this.customPanel3.Size = new System.Drawing.Size(900, 427);
            this.customPanel3.TabIndex = 0;
            // 
            // cb_UpdateEmployeesLog
            // 
            this.cb_UpdateEmployeesLog.AutoSize = true;
            this.cb_UpdateEmployeesLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_UpdateEmployeesLog.ForeColor = System.Drawing.Color.White;
            this.cb_UpdateEmployeesLog.Location = new System.Drawing.Point(670, 172);
            this.cb_UpdateEmployeesLog.Name = "cb_UpdateEmployeesLog";
            this.cb_UpdateEmployeesLog.Size = new System.Drawing.Size(204, 24);
            this.cb_UpdateEmployeesLog.TabIndex = 164;
            this.cb_UpdateEmployeesLog.Tag = "32";
            this.cb_UpdateEmployeesLog.Text = "Update Employees Log";
            this.cb_UpdateEmployeesLog.UseVisualStyleBackColor = true;
            this.cb_UpdateEmployeesLog.Click += new System.EventHandler(this.CheckBox_Click);
            // 
            // cb_UpdateEmployees
            // 
            this.cb_UpdateEmployees.AutoSize = true;
            this.cb_UpdateEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_UpdateEmployees.ForeColor = System.Drawing.Color.White;
            this.cb_UpdateEmployees.Location = new System.Drawing.Point(459, 170);
            this.cb_UpdateEmployees.Name = "cb_UpdateEmployees";
            this.cb_UpdateEmployees.Size = new System.Drawing.Size(171, 24);
            this.cb_UpdateEmployees.TabIndex = 163;
            this.cb_UpdateEmployees.Tag = "16";
            this.cb_UpdateEmployees.Text = "Update Employees";
            this.cb_UpdateEmployees.UseVisualStyleBackColor = true;
            this.cb_UpdateEmployees.Click += new System.EventHandler(this.CheckBox_Click);
            // 
            // cb_DeleteEmployeesLog
            // 
            this.cb_DeleteEmployeesLog.AutoSize = true;
            this.cb_DeleteEmployeesLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_DeleteEmployeesLog.ForeColor = System.Drawing.Color.White;
            this.cb_DeleteEmployeesLog.Location = new System.Drawing.Point(670, 210);
            this.cb_DeleteEmployeesLog.Name = "cb_DeleteEmployeesLog";
            this.cb_DeleteEmployeesLog.Size = new System.Drawing.Size(200, 24);
            this.cb_DeleteEmployeesLog.TabIndex = 162;
            this.cb_DeleteEmployeesLog.Tag = "128";
            this.cb_DeleteEmployeesLog.Text = "Delete Employees Log";
            this.cb_DeleteEmployeesLog.UseVisualStyleBackColor = true;
            this.cb_DeleteEmployeesLog.Click += new System.EventHandler(this.CheckBox_Click);
            // 
            // cb_AddEmployeesLog
            // 
            this.cb_AddEmployeesLog.AutoSize = true;
            this.cb_AddEmployeesLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_AddEmployeesLog.ForeColor = System.Drawing.Color.White;
            this.cb_AddEmployeesLog.Location = new System.Drawing.Point(670, 134);
            this.cb_AddEmployeesLog.Name = "cb_AddEmployeesLog";
            this.cb_AddEmployeesLog.Size = new System.Drawing.Size(180, 24);
            this.cb_AddEmployeesLog.TabIndex = 161;
            this.cb_AddEmployeesLog.Tag = "8";
            this.cb_AddEmployeesLog.Text = "Add Employees Log";
            this.cb_AddEmployeesLog.UseVisualStyleBackColor = true;
            this.cb_AddEmployeesLog.Click += new System.EventHandler(this.CheckBox_Click);
            // 
            // cb_Transfer
            // 
            this.cb_Transfer.AutoSize = true;
            this.cb_Transfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Transfer.ForeColor = System.Drawing.Color.White;
            this.cb_Transfer.Location = new System.Drawing.Point(459, 355);
            this.cb_Transfer.Name = "cb_Transfer";
            this.cb_Transfer.Size = new System.Drawing.Size(94, 24);
            this.cb_Transfer.TabIndex = 160;
            this.cb_Transfer.Tag = "16384";
            this.cb_Transfer.Text = "Transfer";
            this.cb_Transfer.UseVisualStyleBackColor = true;
            this.cb_Transfer.Click += new System.EventHandler(this.CheckBox_Click);
            // 
            // cb_TransactionsLog
            // 
            this.cb_TransactionsLog.AutoSize = true;
            this.cb_TransactionsLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_TransactionsLog.ForeColor = System.Drawing.Color.White;
            this.cb_TransactionsLog.Location = new System.Drawing.Point(670, 360);
            this.cb_TransactionsLog.Name = "cb_TransactionsLog";
            this.cb_TransactionsLog.Size = new System.Drawing.Size(161, 24);
            this.cb_TransactionsLog.TabIndex = 159;
            this.cb_TransactionsLog.Tag = "32768";
            this.cb_TransactionsLog.Text = "Transactions Log";
            this.cb_TransactionsLog.UseVisualStyleBackColor = true;
            this.cb_TransactionsLog.Click += new System.EventHandler(this.CheckBox_Click);
            // 
            // cb_UpdateClientsLog
            // 
            this.cb_UpdateClientsLog.AutoSize = true;
            this.cb_UpdateClientsLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_UpdateClientsLog.ForeColor = System.Drawing.Color.White;
            this.cb_UpdateClientsLog.Location = new System.Drawing.Point(670, 283);
            this.cb_UpdateClientsLog.Name = "cb_UpdateClientsLog";
            this.cb_UpdateClientsLog.Size = new System.Drawing.Size(174, 24);
            this.cb_UpdateClientsLog.TabIndex = 158;
            this.cb_UpdateClientsLog.Tag = "2048";
            this.cb_UpdateClientsLog.Text = "Update Clients Log";
            this.cb_UpdateClientsLog.UseVisualStyleBackColor = true;
            this.cb_UpdateClientsLog.Click += new System.EventHandler(this.CheckBox_Click);
            // 
            // cb_ShowClients
            // 
            this.cb_ShowClients.AutoSize = true;
            this.cb_ShowClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_ShowClients.ForeColor = System.Drawing.Color.White;
            this.cb_ShowClients.Location = new System.Drawing.Point(670, 96);
            this.cb_ShowClients.Name = "cb_ShowClients";
            this.cb_ShowClients.Size = new System.Drawing.Size(129, 24);
            this.cb_ShowClients.TabIndex = 157;
            this.cb_ShowClients.Tag = "2";
            this.cb_ShowClients.Text = "Show Clients";
            this.cb_ShowClients.UseVisualStyleBackColor = true;
            this.cb_ShowClients.Click += new System.EventHandler(this.CheckBox_Click);
            // 
            // cb_DeleteClientsLog
            // 
            this.cb_DeleteClientsLog.AutoSize = true;
            this.cb_DeleteClientsLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_DeleteClientsLog.ForeColor = System.Drawing.Color.White;
            this.cb_DeleteClientsLog.Location = new System.Drawing.Point(670, 322);
            this.cb_DeleteClientsLog.Name = "cb_DeleteClientsLog";
            this.cb_DeleteClientsLog.Size = new System.Drawing.Size(170, 24);
            this.cb_DeleteClientsLog.TabIndex = 156;
            this.cb_DeleteClientsLog.Tag = "8192";
            this.cb_DeleteClientsLog.Text = "Delete Clients Log";
            this.cb_DeleteClientsLog.UseVisualStyleBackColor = true;
            this.cb_DeleteClientsLog.Click += new System.EventHandler(this.CheckBox_Click);
            // 
            // cb_DeleteClient
            // 
            this.cb_DeleteClient.AutoSize = true;
            this.cb_DeleteClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_DeleteClient.ForeColor = System.Drawing.Color.White;
            this.cb_DeleteClient.Location = new System.Drawing.Point(459, 318);
            this.cb_DeleteClient.Name = "cb_DeleteClient";
            this.cb_DeleteClient.Size = new System.Drawing.Size(128, 24);
            this.cb_DeleteClient.TabIndex = 155;
            this.cb_DeleteClient.Tag = "4096";
            this.cb_DeleteClient.Text = "Delete Client";
            this.cb_DeleteClient.UseVisualStyleBackColor = true;
            this.cb_DeleteClient.Click += new System.EventHandler(this.CheckBox_Click);
            // 
            // cb_AddClientsLog
            // 
            this.cb_AddClientsLog.AutoSize = true;
            this.cb_AddClientsLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_AddClientsLog.ForeColor = System.Drawing.Color.White;
            this.cb_AddClientsLog.Location = new System.Drawing.Point(670, 246);
            this.cb_AddClientsLog.Name = "cb_AddClientsLog";
            this.cb_AddClientsLog.Size = new System.Drawing.Size(150, 24);
            this.cb_AddClientsLog.TabIndex = 154;
            this.cb_AddClientsLog.Tag = "512";
            this.cb_AddClientsLog.Text = "Add Clients Log";
            this.cb_AddClientsLog.UseVisualStyleBackColor = true;
            this.cb_AddClientsLog.Click += new System.EventHandler(this.CheckBox_Click);
            // 
            // cb_UpdateClient
            // 
            this.cb_UpdateClient.AutoSize = true;
            this.cb_UpdateClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_UpdateClient.ForeColor = System.Drawing.Color.White;
            this.cb_UpdateClient.Location = new System.Drawing.Point(459, 281);
            this.cb_UpdateClient.Name = "cb_UpdateClient";
            this.cb_UpdateClient.Size = new System.Drawing.Size(132, 24);
            this.cb_UpdateClient.TabIndex = 153;
            this.cb_UpdateClient.Tag = "1024";
            this.cb_UpdateClient.Text = "Update Client";
            this.cb_UpdateClient.UseVisualStyleBackColor = true;
            this.cb_UpdateClient.Click += new System.EventHandler(this.CheckBox_Click);
            // 
            // cb_AddClient
            // 
            this.cb_AddClient.AutoSize = true;
            this.cb_AddClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_AddClient.ForeColor = System.Drawing.Color.White;
            this.cb_AddClient.Location = new System.Drawing.Point(459, 244);
            this.cb_AddClient.Name = "cb_AddClient";
            this.cb_AddClient.Size = new System.Drawing.Size(108, 24);
            this.cb_AddClient.TabIndex = 152;
            this.cb_AddClient.Tag = "256";
            this.cb_AddClient.Text = "Add Client";
            this.cb_AddClient.UseVisualStyleBackColor = true;
            this.cb_AddClient.Click += new System.EventHandler(this.CheckBox_Click);
            // 
            // cb_ShowEmployees
            // 
            this.cb_ShowEmployees.AutoSize = true;
            this.cb_ShowEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_ShowEmployees.ForeColor = System.Drawing.Color.White;
            this.cb_ShowEmployees.Location = new System.Drawing.Point(459, 96);
            this.cb_ShowEmployees.Name = "cb_ShowEmployees";
            this.cb_ShowEmployees.Size = new System.Drawing.Size(159, 24);
            this.cb_ShowEmployees.TabIndex = 151;
            this.cb_ShowEmployees.Tag = "1";
            this.cb_ShowEmployees.Text = "Show Employees";
            this.cb_ShowEmployees.UseVisualStyleBackColor = true;
            this.cb_ShowEmployees.Click += new System.EventHandler(this.CheckBox_Click);
            // 
            // cb_DeleteEmployee
            // 
            this.cb_DeleteEmployee.AutoSize = true;
            this.cb_DeleteEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_DeleteEmployee.ForeColor = System.Drawing.Color.White;
            this.cb_DeleteEmployee.Location = new System.Drawing.Point(459, 207);
            this.cb_DeleteEmployee.Name = "cb_DeleteEmployee";
            this.cb_DeleteEmployee.Size = new System.Drawing.Size(158, 24);
            this.cb_DeleteEmployee.TabIndex = 150;
            this.cb_DeleteEmployee.Tag = "64";
            this.cb_DeleteEmployee.Text = "Delete Employee";
            this.cb_DeleteEmployee.UseVisualStyleBackColor = true;
            this.cb_DeleteEmployee.Click += new System.EventHandler(this.CheckBox_Click);
            // 
            // cb_AddEmployee
            // 
            this.cb_AddEmployee.AutoSize = true;
            this.cb_AddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_AddEmployee.ForeColor = System.Drawing.Color.White;
            this.cb_AddEmployee.Location = new System.Drawing.Point(459, 133);
            this.cb_AddEmployee.Name = "cb_AddEmployee";
            this.cb_AddEmployee.Size = new System.Drawing.Size(138, 24);
            this.cb_AddEmployee.TabIndex = 149;
            this.cb_AddEmployee.Tag = "4";
            this.cb_AddEmployee.Text = "Add Employee";
            this.cb_AddEmployee.UseVisualStyleBackColor = true;
            this.cb_AddEmployee.Click += new System.EventHandler(this.CheckBox_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(630, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 29);
            this.label6.TabIndex = 148;
            this.label6.Text = "Permissions";
            // 
            // cb_All
            // 
            this.cb_All.AutoSize = true;
            this.cb_All.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_All.ForeColor = System.Drawing.Color.White;
            this.cb_All.Location = new System.Drawing.Point(442, 55);
            this.cb_All.Name = "cb_All";
            this.cb_All.Size = new System.Drawing.Size(154, 26);
            this.cb_All.TabIndex = 147;
            this.cb_All.Text = "All Permissions";
            this.cb_All.UseVisualStyleBackColor = true;
            this.cb_All.CheckedChanged += new System.EventHandler(this.cb_All_CheckedChanged);
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gradientPanel2.ColorTop = System.Drawing.Color.Gray;
            this.gradientPanel2.CornerRadius = 0;
            this.gradientPanel2.Location = new System.Drawing.Point(430, 6);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(4, 428);
            this.gradientPanel2.TabIndex = 146;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.ForeColor = System.Drawing.Color.White;
            this.txtConfirmPassword.Location = new System.Drawing.Point(177, 210);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(247, 30);
            this.txtConfirmPassword.TabIndex = 145;
            this.txtConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtConfirmPassword_Validating);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(177, 161);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(247, 30);
            this.txtPassword.TabIndex = 144;
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.Color.White;
            this.txtUserName.Location = new System.Drawing.Point(177, 112);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(247, 30);
            this.txtUserName.TabIndex = 143;
            this.txtUserName.Validating += new System.ComponentModel.CancelEventHandler(this.txtUserName_Validating);
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.ForeColor = System.Drawing.Color.White;
            this.lblUserID.Location = new System.Drawing.Point(189, 75);
            this.lblUserID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(48, 25);
            this.lblUserID.TabIndex = 142;
            this.lblUserID.Text = "???";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(42, 75);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 141;
            this.label4.Text = "EmployeeID:";
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Checked = true;
            this.chkIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIsActive.ForeColor = System.Drawing.Color.White;
            this.chkIsActive.Location = new System.Drawing.Point(177, 262);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(99, 26);
            this.chkIsActive.TabIndex = 140;
            this.chkIsActive.Text = "Is Active";
            this.chkIsActive.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(40, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 133;
            this.label2.Text = "UserName:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 211);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 20);
            this.label3.TabIndex = 138;
            this.label3.Text = "Confirm Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(47, 162);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 134;
            this.label5.Text = "Password:";
            // 
            // frmAddUpdateEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 571);
            this.Controls.Add(this.customPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddUpdateEmployees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAddUpdateEmployees";
            this.Load += new System.EventHandler(this.frmAddUpdateEmployees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            this.tcEmployeeInfo.ResumeLayout(false);
            this.tpPersonInfo.ResumeLayout(false);
            this.customPanel2.ResumeLayout(false);
            this.customPanel2.PerformLayout();
            this.tpLoginInfo.ResumeLayout(false);
            this.customPanel3.ResumeLayout(false);
            this.customPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomPanel customPanel1;
        private System.Windows.Forms.TabControl tcEmployeeInfo;
        private System.Windows.Forms.TabPage tpPersonInfo;
        private System.Windows.Forms.TabPage tpLoginInfo;
        private ctrlPersonCard ctrlPersonCard1;
        private System.Windows.Forms.Label label1;
        private CustomPanel customPanel2;
        private System.Windows.Forms.TextBox txt_PersonID;
        private RoundedButton btn_search;
        private RoundedButton btn_AddPerson;
        private System.Windows.Forms.Label lbl_header;
        private RoundedButton btn_Cancle;
        private RoundedButton btn_Save;
        private RoundedButton btn_Next;
        private CustomPanel customPanel3;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private RoundedButton btn_Minimized;
        private RoundedButton btn_Close;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cb_All;
        private CustomPanel gradientPanel2;
        private System.Windows.Forms.CheckBox cb_DeleteClientsLog;
        private System.Windows.Forms.CheckBox cb_DeleteClient;
        private System.Windows.Forms.CheckBox cb_AddClientsLog;
        private System.Windows.Forms.CheckBox cb_UpdateClient;
        private System.Windows.Forms.CheckBox cb_AddClient;
        private System.Windows.Forms.CheckBox cb_ShowEmployees;
        private System.Windows.Forms.CheckBox cb_DeleteEmployee;
        private System.Windows.Forms.CheckBox cb_AddEmployee;
        private System.Windows.Forms.CheckBox cb_ShowClients;
        private System.Windows.Forms.CheckBox cb_TransactionsLog;
        private System.Windows.Forms.CheckBox cb_UpdateClientsLog;
        private System.Windows.Forms.CheckBox cb_Transfer;
        private System.Windows.Forms.CheckBox cb_UpdateEmployeesLog;
        private System.Windows.Forms.CheckBox cb_UpdateEmployees;
        private System.Windows.Forms.CheckBox cb_DeleteEmployeesLog;
        private System.Windows.Forms.CheckBox cb_AddEmployeesLog;
    }
}