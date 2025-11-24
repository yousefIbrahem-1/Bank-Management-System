namespace Bank
{
    partial class frmClients
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gradientPanel1 = new Bank.CustomPanel();
            this.btn_Add = new Bank.RoundedButton();
            this.btn_Minimized = new Bank.RoundedButton();
            this.btn_Close = new Bank.RoundedButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PnlGrid = new Bank.CustomPanel();
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            this.SuspendLayout();
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gradientPanel1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gradientPanel1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.gradientPanel1.Controls.Add(this.btn_Add);
            this.gradientPanel1.Controls.Add(this.btn_Minimized);
            this.gradientPanel1.Controls.Add(this.btn_Close);
            this.gradientPanel1.Controls.Add(this.pictureBox1);
            this.gradientPanel1.Controls.Add(this.PnlGrid);
            this.gradientPanel1.CornerRadius = 0;
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1537, 1000);
            this.gradientPanel1.TabIndex = 0;
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.Transparent;
            this.btn_Add.BorderRadius = 20;
            this.btn_Add.FlatAppearance.BorderSize = 0;
            this.btn_Add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Plum;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Add.Image = global::Bank.Properties.Resources.add_user__1_;
            this.btn_Add.Location = new System.Drawing.Point(1369, 291);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(160, 97);
            this.btn_Add.TabIndex = 3;
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Minimized
            // 
            this.btn_Minimized.BorderRadius = 10;
            this.btn_Minimized.FlatAppearance.BorderSize = 0;
            this.btn_Minimized.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Plum;
            this.btn_Minimized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Minimized.ForeColor = System.Drawing.Color.White;
            this.btn_Minimized.Image = global::Bank.Properties.Resources.cancel;
            this.btn_Minimized.Location = new System.Drawing.Point(1424, 4);
            this.btn_Minimized.Name = "btn_Minimized";
            this.btn_Minimized.Size = new System.Drawing.Size(46, 43);
            this.btn_Minimized.TabIndex = 11;
            this.btn_Minimized.UseVisualStyleBackColor = true;
            this.btn_Minimized.Click += new System.EventHandler(this.btn_Minimized_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.BorderRadius = 10;
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Plum;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.ForeColor = System.Drawing.Color.White;
            this.btn_Close.Image = global::Bank.Properties.Resources.close__1_;
            this.btn_Close.Location = new System.Drawing.Point(1485, 3);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(46, 43);
            this.btn_Close.TabIndex = 10;
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Bank.Properties.Resources.accepted;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1537, 510);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // PnlGrid
            // 
            this.PnlGrid.ColorBottom = System.Drawing.Color.Violet;
            this.PnlGrid.ColorTop = System.Drawing.Color.Violet;
            this.PnlGrid.Controls.Add(this.dgvClients);
            this.PnlGrid.CornerRadius = 20;
            this.PnlGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlGrid.Location = new System.Drawing.Point(0, 510);
            this.PnlGrid.Margin = new System.Windows.Forms.Padding(16);
            this.PnlGrid.Name = "PnlGrid";
            this.PnlGrid.Padding = new System.Windows.Forms.Padding(6);
            this.PnlGrid.Size = new System.Drawing.Size(1537, 490);
            this.PnlGrid.TabIndex = 8;
            // 
            // dgvClients
            // 
            this.dgvClients.AllowUserToAddRows = false;
            this.dgvClients.AllowUserToDeleteRows = false;
            this.dgvClients.AllowUserToResizeColumns = false;
            this.dgvClients.AllowUserToResizeRows = false;
            this.dgvClients.BackgroundColor = System.Drawing.Color.White;
            this.dgvClients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClients.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvClients.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvClients.ColumnHeadersHeight = 54;
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvClients.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dgvClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClients.EnableHeadersVisualStyles = false;
            this.dgvClients.GridColor = System.Drawing.Color.Violet;
            this.dgvClients.Location = new System.Drawing.Point(6, 6);
            this.dgvClients.Margin = new System.Windows.Forms.Padding(10);
            this.dgvClients.MultiSelect = false;
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.ReadOnly = true;
            this.dgvClients.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClients.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvClients.RowHeadersVisible = false;
            this.dgvClients.RowHeadersWidth = 50;
            this.dgvClients.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvClients.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvClients.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Purple;
            this.dgvClients.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvClients.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvClients.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Fuchsia;
            this.dgvClients.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvClients.RowTemplate.DividerHeight = 3;
            this.dgvClients.RowTemplate.Height = 40;
            this.dgvClients.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClients.Size = new System.Drawing.Size(1525, 478);
            this.dgvClients.TabIndex = 2;
            // 
            // frmClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1537, 1000);
            this.Controls.Add(this.gradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "frmClients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Clients";
            this.Load += new System.EventHandler(this.frmClients_Load);
            this.gradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomPanel gradientPanel1;
        private CustomPanel PnlGrid;
        private System.Windows.Forms.PictureBox pictureBox1;
        private RoundedButton btn_Minimized;
        private RoundedButton btn_Close;
        private System.Windows.Forms.DataGridView dgvClients;
        private RoundedButton btn_Add;
    }
}

