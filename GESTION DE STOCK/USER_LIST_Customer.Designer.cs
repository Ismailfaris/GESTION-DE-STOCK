namespace GESTION_DE_STOCK
{
    partial class USER_LIST_Customer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.CMBCUSTOMER = new System.Windows.Forms.ComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.BtnUpdateCu = new System.Windows.Forms.Button();
            this.BtnDeleteCu = new System.Windows.Forms.Button();
            this.BtnAddCu = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.DGVCustomer = new System.Windows.Forms.DataGridView();
            this.chkSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel4.Location = new System.Drawing.Point(36, 132);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1012, 10);
            this.panel4.TabIndex = 10;
            // 
            // txtCustomer
            // 
            this.txtCustomer.BackColor = System.Drawing.SystemColors.Control;
            this.txtCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCustomer.Location = new System.Drawing.Point(436, 187);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(286, 13);
            this.txtCustomer.TabIndex = 11;
            this.txtCustomer.Enter += new System.EventHandler(this.txtCustomer_Enter);
            this.txtCustomer.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCustomer_KeyUp);
            // 
            // CMBCUSTOMER
            // 
            this.CMBCUSTOMER.FormattingEnabled = true;
            this.CMBCUSTOMER.Location = new System.Drawing.Point(95, 187);
            this.CMBCUSTOMER.Name = "CMBCUSTOMER";
            this.CMBCUSTOMER.Size = new System.Drawing.Size(291, 21);
            this.CMBCUSTOMER.TabIndex = 12;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel5.Location = new System.Drawing.Point(436, 201);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(286, 10);
            this.panel5.TabIndex = 14;
            // 
            // BtnUpdateCu
            // 
            this.BtnUpdateCu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnUpdateCu.FlatAppearance.BorderSize = 0;
            this.BtnUpdateCu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdateCu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdateCu.ForeColor = System.Drawing.Color.White;
            this.BtnUpdateCu.Image = global::GESTION_DE_STOCK.Properties.Resources.icons8_update_35;
            this.BtnUpdateCu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUpdateCu.Location = new System.Drawing.Point(399, 35);
            this.BtnUpdateCu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnUpdateCu.Name = "BtnUpdateCu";
            this.BtnUpdateCu.Size = new System.Drawing.Size(291, 60);
            this.BtnUpdateCu.TabIndex = 8;
            this.BtnUpdateCu.Text = "Modifier";
            this.BtnUpdateCu.UseVisualStyleBackColor = false;
            this.BtnUpdateCu.Click += new System.EventHandler(this.BtnUpdateCu_Click);
            // 
            // BtnDeleteCu
            // 
            this.BtnDeleteCu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnDeleteCu.FlatAppearance.BorderSize = 0;
            this.BtnDeleteCu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeleteCu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteCu.ForeColor = System.Drawing.Color.White;
            this.BtnDeleteCu.Image = global::GESTION_DE_STOCK.Properties.Resources.icons8_waste_35;
            this.BtnDeleteCu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDeleteCu.Location = new System.Drawing.Point(757, 35);
            this.BtnDeleteCu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnDeleteCu.Name = "BtnDeleteCu";
            this.BtnDeleteCu.Size = new System.Drawing.Size(291, 60);
            this.BtnDeleteCu.TabIndex = 7;
            this.BtnDeleteCu.Text = "Delete";
            this.BtnDeleteCu.UseVisualStyleBackColor = false;
            this.BtnDeleteCu.Click += new System.EventHandler(this.BtnDeleteCu_Click);
            // 
            // BtnAddCu
            // 
            this.BtnAddCu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnAddCu.FlatAppearance.BorderSize = 0;
            this.BtnAddCu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddCu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddCu.ForeColor = System.Drawing.Color.White;
            this.BtnAddCu.Image = global::GESTION_DE_STOCK.Properties.Resources.icons8_add_35;
            this.BtnAddCu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAddCu.Location = new System.Drawing.Point(36, 35);
            this.BtnAddCu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAddCu.Name = "BtnAddCu";
            this.BtnAddCu.Size = new System.Drawing.Size(291, 60);
            this.BtnAddCu.TabIndex = 6;
            this.BtnAddCu.Text = "Add";
            this.BtnAddCu.UseVisualStyleBackColor = false;
            this.BtnAddCu.Click += new System.EventHandler(this.BtnAddCu_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel6.Location = new System.Drawing.Point(36, 268);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1012, 10);
            this.panel6.TabIndex = 15;
            // 
            // DGVCustomer
            // 
            this.DGVCustomer.AllowUserToAddRows = false;
            this.DGVCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chkSelect});
            this.DGVCustomer.Location = new System.Drawing.Point(36, 300);
            this.DGVCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.DGVCustomer.Name = "DGVCustomer";
            this.DGVCustomer.RowHeadersWidth = 51;
            this.DGVCustomer.RowTemplate.Height = 24;
            this.DGVCustomer.Size = new System.Drawing.Size(1012, 418);
            this.DGVCustomer.TabIndex = 17;
            // 
            // chkSelect
            // 
            this.chkSelect.HeaderText = "Select";
            this.chkSelect.MinimumWidth = 6;
            this.chkSelect.Name = "chkSelect";
            this.chkSelect.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(739, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "Search";
            // 
            // USER_LIST_Customer
            // 
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGVCustomer);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.CMBCUSTOMER);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.BtnUpdateCu);
            this.Controls.Add(this.BtnDeleteCu);
            this.Controls.Add(this.BtnAddCu);
            this.Name = "USER_LIST_Customer";
            this.Size = new System.Drawing.Size(1452, 853);
            this.Load += new System.EventHandler(this.USER_LIST_Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnDeleteC;
        private System.Windows.Forms.Button BtnUpdateC;
        private System.Windows.Forms.Button BtnAddC;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox CMBCLIENT;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BtnUpdateCu;
        private System.Windows.Forms.Button BtnDeleteCu;
        private System.Windows.Forms.Button BtnAddCu;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.ComboBox CMBCUSTOMER;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView DGVCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkSelect;
    }
}
