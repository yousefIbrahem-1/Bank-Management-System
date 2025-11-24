namespace Bank.Clients
{
    partial class frmAddClients
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
            this.customPanel1 = new Bank.CustomPanel();
            this.btn_Minimized = new Bank.RoundedButton();
            this.btn_Cancle = new Bank.RoundedButton();
            this.btn_Close = new Bank.RoundedButton();
            this.btn_Save = new Bank.RoundedButton();
            this.lbl_header = new System.Windows.Forms.Label();
            this.tcClientInfo = new System.Windows.Forms.TabControl();
            this.tpPersonInfo = new System.Windows.Forms.TabPage();
            this.customPanel2 = new Bank.CustomPanel();
            this.btn_AddPerson = new Bank.RoundedButton();
            this.btn_search = new Bank.RoundedButton();
            this.btn_Next = new Bank.RoundedButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_PersonID = new System.Windows.Forms.TextBox();
            this.ctrlPersonCard1 = new Bank.ctrlPersonCard();
            this.tpClientInfo = new System.Windows.Forms.TabPage();
            this.customPanel3 = new Bank.CustomPanel();
            this.cb_Accounts = new System.Windows.Forms.ComboBox();
            this.lbl_Requirements = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.customPanel4 = new Bank.CustomPanel();
            this.lbl_description = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gradientPanel2 = new Bank.CustomPanel();
            this.txt_AccountBalance = new System.Windows.Forms.TextBox();
            this.lblUserID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.customPanel1.SuspendLayout();
            this.tcClientInfo.SuspendLayout();
            this.tpPersonInfo.SuspendLayout();
            this.customPanel2.SuspendLayout();
            this.tpClientInfo.SuspendLayout();
            this.customPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
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
            this.customPanel1.Controls.Add(this.tcClientInfo);
            this.customPanel1.CornerRadius = 0;
            this.customPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customPanel1.Location = new System.Drawing.Point(0, 0);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(904, 563);
            this.customPanel1.TabIndex = 1;
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
            this.lbl_header.Size = new System.Drawing.Size(214, 46);
            this.lbl_header.TabIndex = 1;
            this.lbl_header.Text = "Add Client";
            // 
            // tcClientInfo
            // 
            this.tcClientInfo.Controls.Add(this.tpPersonInfo);
            this.tcClientInfo.Controls.Add(this.tpClientInfo);
            this.tcClientInfo.Location = new System.Drawing.Point(3, 58);
            this.tcClientInfo.Name = "tcClientInfo";
            this.tcClientInfo.SelectedIndex = 0;
            this.tcClientInfo.Size = new System.Drawing.Size(900, 456);
            this.tcClientInfo.TabIndex = 0;
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
            // tpClientInfo
            // 
            this.tpClientInfo.Controls.Add(this.customPanel3);
            this.tpClientInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tpClientInfo.Location = new System.Drawing.Point(4, 25);
            this.tpClientInfo.Name = "tpClientInfo";
            this.tpClientInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpClientInfo.Size = new System.Drawing.Size(892, 427);
            this.tpClientInfo.TabIndex = 1;
            this.tpClientInfo.Text = "Client Infoemation";
            this.tpClientInfo.UseVisualStyleBackColor = true;
            // 
            // customPanel3
            // 
            this.customPanel3.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.customPanel3.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.customPanel3.Controls.Add(this.cb_Accounts);
            this.customPanel3.Controls.Add(this.lbl_Requirements);
            this.customPanel3.Controls.Add(this.label7);
            this.customPanel3.Controls.Add(this.customPanel4);
            this.customPanel3.Controls.Add(this.lbl_description);
            this.customPanel3.Controls.Add(this.label3);
            this.customPanel3.Controls.Add(this.gradientPanel2);
            this.customPanel3.Controls.Add(this.txt_AccountBalance);
            this.customPanel3.Controls.Add(this.lblUserID);
            this.customPanel3.Controls.Add(this.label4);
            this.customPanel3.Controls.Add(this.label2);
            this.customPanel3.Controls.Add(this.label5);
            this.customPanel3.CornerRadius = 0;
            this.customPanel3.Location = new System.Drawing.Point(-4, 0);
            this.customPanel3.Name = "customPanel3";
            this.customPanel3.Size = new System.Drawing.Size(900, 427);
            this.customPanel3.TabIndex = 0;
            // 
            // cb_Accounts
            // 
            this.cb_Accounts.FormattingEnabled = true;
            this.cb_Accounts.Location = new System.Drawing.Point(179, 195);
            this.cb_Accounts.Name = "cb_Accounts";
            this.cb_Accounts.Size = new System.Drawing.Size(121, 24);
            this.cb_Accounts.TabIndex = 151;
            this.cb_Accounts.SelectedIndexChanged += new System.EventHandler(this.cb_Accounts_SelectedIndexChanged);
            // 
            // lbl_Requirements
            // 
            this.lbl_Requirements.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Requirements.ForeColor = System.Drawing.Color.White;
            this.lbl_Requirements.Location = new System.Drawing.Point(443, 250);
            this.lbl_Requirements.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Requirements.Name = "lbl_Requirements";
            this.lbl_Requirements.Size = new System.Drawing.Size(445, 174);
            this.lbl_Requirements.TabIndex = 150;
            this.lbl_Requirements.Text = "???";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(544, 221);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(257, 20);
            this.label7.TabIndex = 149;
            this.label7.Text = "Requirements Of the Account";
            // 
            // customPanel4
            // 
            this.customPanel4.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customPanel4.ColorTop = System.Drawing.Color.Gray;
            this.customPanel4.CornerRadius = 0;
            this.customPanel4.Location = new System.Drawing.Point(432, 215);
            this.customPanel4.Name = "customPanel4";
            this.customPanel4.Size = new System.Drawing.Size(469, 4);
            this.customPanel4.TabIndex = 147;
            // 
            // lbl_description
            // 
            this.lbl_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_description.ForeColor = System.Drawing.Color.White;
            this.lbl_description.Location = new System.Drawing.Point(441, 41);
            this.lbl_description.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(447, 171);
            this.lbl_description.TabIndex = 148;
            this.lbl_description.Text = "???";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(544, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 20);
            this.label3.TabIndex = 147;
            this.label3.Text = "Description Of the Account";
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
            // txt_AccountBalance
            // 
            this.txt_AccountBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txt_AccountBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_AccountBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AccountBalance.ForeColor = System.Drawing.Color.White;
            this.txt_AccountBalance.Location = new System.Drawing.Point(179, 143);
            this.txt_AccountBalance.Name = "txt_AccountBalance";
            this.txt_AccountBalance.Size = new System.Drawing.Size(247, 30);
            this.txt_AccountBalance.TabIndex = 143;
            this.txt_AccountBalance.Validating += new System.ComponentModel.CancelEventHandler(this.txt_AccountBalance_Validating);
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.ForeColor = System.Drawing.Color.White;
            this.lblUserID.Location = new System.Drawing.Point(191, 106);
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
            this.label4.Location = new System.Drawing.Point(42, 106);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 141;
            this.label4.Text = "ClientID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(5, 144);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 20);
            this.label2.TabIndex = 133;
            this.label2.Text = "Account Balance:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(32, 193);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 20);
            this.label5.TabIndex = 134;
            this.label5.Text = "AccountID:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 563);
            this.Controls.Add(this.customPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddClients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAddClients";
            this.Load += new System.EventHandler(this.frmAddClients_Load);
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            this.tcClientInfo.ResumeLayout(false);
            this.tpPersonInfo.ResumeLayout(false);
            this.customPanel2.ResumeLayout(false);
            this.customPanel2.PerformLayout();
            this.tpClientInfo.ResumeLayout(false);
            this.customPanel3.ResumeLayout(false);
            this.customPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomPanel customPanel1;
        private RoundedButton btn_Minimized;
        private RoundedButton btn_Cancle;
        private RoundedButton btn_Close;
        private RoundedButton btn_Save;
        private System.Windows.Forms.Label lbl_header;
        private System.Windows.Forms.TabControl tcClientInfo;
        private System.Windows.Forms.TabPage tpPersonInfo;
        private CustomPanel customPanel2;
        private RoundedButton btn_AddPerson;
        private RoundedButton btn_search;
        private RoundedButton btn_Next;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_PersonID;
        private ctrlPersonCard ctrlPersonCard1;
        private System.Windows.Forms.TabPage tpClientInfo;
        private CustomPanel customPanel3;
        private CustomPanel gradientPanel2;
        private System.Windows.Forms.TextBox txt_AccountBalance;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private CustomPanel customPanel4;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.Label lbl_Requirements;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_Accounts;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}