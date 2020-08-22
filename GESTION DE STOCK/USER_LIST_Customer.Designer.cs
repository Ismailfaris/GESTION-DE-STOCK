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
            this.panel1 = new System.Windows.Forms.Panel();
            this.CMBCLIENT = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnUpdateC = new System.Windows.Forms.Button();
            this.BtnDeleteC = new System.Windows.Forms.Button();
            this.BtnAddC = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(153, 201);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1247, 12);
            this.panel1.TabIndex = 2;
            // 
            // CMBCLIENT
            // 
            this.CMBCLIENT.AllowDrop = true;
            this.CMBCLIENT.FormattingEnabled = true;
            this.CMBCLIENT.Location = new System.Drawing.Point(292, 251);
            this.CMBCLIENT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CMBCLIENT.Name = "CMBCLIENT";
            this.CMBCLIENT.Size = new System.Drawing.Size(320, 24);
            this.CMBCLIENT.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel2.Location = new System.Drawing.Point(665, 273);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(289, 10);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel3.Location = new System.Drawing.Point(153, 321);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1247, 12);
            this.panel3.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chkGrd});
            this.dataGridView1.Location = new System.Drawing.Point(115, 311);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1247, 418);
            this.dataGridView1.TabIndex = 7;
            // 
            // chkGrd
            // 
            this.chkGrd.HeaderText = "Select";
            this.chkGrd.Name = "chkGrd";
            this.chkGrd.ReadOnly = true;
            this.chkGrd.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.chkGrd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // BtnUpdateC
            // 
            this.BtnUpdateC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnUpdateC.FlatAppearance.BorderSize = 0;
            this.BtnUpdateC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdateC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdateC.ForeColor = System.Drawing.Color.White;
            this.BtnUpdateC.Image = global::GESTION_DE_STOCK.Properties.Resources.icons8_update_35;
            this.BtnUpdateC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUpdateC.Location = new System.Drawing.Point(633, 87);
            this.BtnUpdateC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnUpdateC.Name = "BtnUpdateC";
            this.BtnUpdateC.Size = new System.Drawing.Size(291, 60);
            this.BtnUpdateC.TabIndex = 1;
            this.BtnUpdateC.Text = "Modifier";
            this.BtnUpdateC.UseVisualStyleBackColor = false;
            // 
            // BtnDeleteC
            // 
            this.BtnDeleteC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnDeleteC.FlatAppearance.BorderSize = 0;
            this.BtnDeleteC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeleteC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteC.ForeColor = System.Drawing.Color.White;
            this.BtnDeleteC.Image = global::GESTION_DE_STOCK.Properties.Resources.icons8_waste_35;
            this.BtnDeleteC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDeleteC.Location = new System.Drawing.Point(1109, 87);
            this.BtnDeleteC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnDeleteC.Name = "BtnDeleteC";
            this.BtnDeleteC.Size = new System.Drawing.Size(291, 60);
            this.BtnDeleteC.TabIndex = 1;
            this.BtnDeleteC.Text = "Delete";
            this.BtnDeleteC.UseVisualStyleBackColor = false;
            // 
            // BtnAddC
            // 
            this.BtnAddC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnAddC.FlatAppearance.BorderSize = 0;
            this.BtnAddC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddC.ForeColor = System.Drawing.Color.White;
            this.BtnAddC.Image = global::GESTION_DE_STOCK.Properties.Resources.icons8_add_35;
            this.BtnAddC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAddC.Location = new System.Drawing.Point(153, 87);
            this.BtnAddC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAddC.Name = "BtnAddC";
            this.BtnAddC.Size = new System.Drawing.Size(291, 60);
            this.BtnAddC.TabIndex = 0;
            this.BtnAddC.Text = "Add";
            this.BtnAddC.UseVisualStyleBackColor = false;
            this.BtnAddC.Click += new System.EventHandler(this.BtnAddC_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(567, 199);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 22);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "Rechercher";
            this.textBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseClick);
            // 
            // USER_LIST_CLIENT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.CMBCLIENT);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnUpdateC);
            this.Controls.Add(this.BtnDeleteC);
            this.Controls.Add(this.BtnAddC);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "USER_LIST_CLIENT";
            this.Size = new System.Drawing.Size(1452, 853);
            this.Load += new System.EventHandler(this.USER_LIST_CLIENT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
    }
}
