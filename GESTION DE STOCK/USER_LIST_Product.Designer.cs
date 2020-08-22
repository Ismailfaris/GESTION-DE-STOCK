namespace GESTION_DE_STOCK
{
    partial class USER_LIST_Product
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CMBCLIENT = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chkGrd = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.BtnPrintAllP = new System.Windows.Forms.Button();
            this.BtnExcelP = new System.Windows.Forms.Button();
            this.BtnPrintPR = new System.Windows.Forms.Button();
            this.BtnRefreshP = new System.Windows.Forms.Button();
            this.BtnshowPicP = new System.Windows.Forms.Button();
            this.BtnUpdateP = new System.Windows.Forms.Button();
            this.BtnDeleteP = new System.Windows.Forms.Button();
            this.BtnAddP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(617, 201);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(272, 27);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "Rechercher";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel3.Location = new System.Drawing.Point(105, 278);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1247, 12);
            this.panel3.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel2.Location = new System.Drawing.Point(617, 230);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(272, 12);
            this.panel2.TabIndex = 11;
            // 
            // CMBCLIENT
            // 
            this.CMBCLIENT.FormattingEnabled = true;
            this.CMBCLIENT.Location = new System.Drawing.Point(244, 208);
            this.CMBCLIENT.Margin = new System.Windows.Forms.Padding(4);
            this.CMBCLIENT.Name = "CMBCLIENT";
            this.CMBCLIENT.Size = new System.Drawing.Size(320, 24);
            this.CMBCLIENT.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(105, 158);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1247, 12);
            this.panel1.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chkGrd});
            this.dataGridView1.Location = new System.Drawing.Point(105, 298);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1247, 418);
            this.dataGridView1.TabIndex = 15;
            // 
            // chkGrd
            // 
            this.chkGrd.HeaderText = "Select";
            this.chkGrd.MinimumWidth = 6;
            this.chkGrd.Name = "chkGrd";
            this.chkGrd.ReadOnly = true;
            this.chkGrd.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.chkGrd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.chkGrd.Width = 125;
            // 
            // BtnPrintAllP
            // 
            this.BtnPrintAllP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnPrintAllP.FlatAppearance.BorderSize = 0;
            this.BtnPrintAllP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPrintAllP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrintAllP.ForeColor = System.Drawing.Color.White;
            this.BtnPrintAllP.Image = global::GESTION_DE_STOCK.Properties.Resources.icons8_print_351;
            this.BtnPrintAllP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPrintAllP.Location = new System.Drawing.Point(575, 741);
            this.BtnPrintAllP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnPrintAllP.Name = "BtnPrintAllP";
            this.BtnPrintAllP.Size = new System.Drawing.Size(291, 60);
            this.BtnPrintAllP.TabIndex = 18;
            this.BtnPrintAllP.Text = "Print all";
            this.BtnPrintAllP.UseVisualStyleBackColor = false;
            // 
            // BtnExcelP
            // 
            this.BtnExcelP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnExcelP.FlatAppearance.BorderSize = 0;
            this.BtnExcelP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExcelP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcelP.ForeColor = System.Drawing.Color.White;
            this.BtnExcelP.Image = global::GESTION_DE_STOCK.Properties.Resources.icons8_microsoft_excel_2019_35;
            this.BtnExcelP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExcelP.Location = new System.Drawing.Point(1061, 741);
            this.BtnExcelP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnExcelP.Name = "BtnExcelP";
            this.BtnExcelP.Size = new System.Drawing.Size(291, 60);
            this.BtnExcelP.TabIndex = 17;
            this.BtnExcelP.Text = "Save at Excel";
            this.BtnExcelP.UseVisualStyleBackColor = false;
            // 
            // BtnPrintPR
            // 
            this.BtnPrintPR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnPrintPR.FlatAppearance.BorderSize = 0;
            this.BtnPrintPR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPrintPR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrintPR.ForeColor = System.Drawing.Color.White;
            this.BtnPrintPR.Image = global::GESTION_DE_STOCK.Properties.Resources.icons8_print_35;
            this.BtnPrintPR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPrintPR.Location = new System.Drawing.Point(105, 741);
            this.BtnPrintPR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnPrintPR.Name = "BtnPrintPR";
            this.BtnPrintPR.Size = new System.Drawing.Size(291, 60);
            this.BtnPrintPR.TabIndex = 16;
            this.BtnPrintPR.Text = "Print PR Checked";
            this.BtnPrintPR.UseVisualStyleBackColor = false;
            // 
            // BtnRefreshP
            // 
            this.BtnRefreshP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnRefreshP.FlatAppearance.BorderSize = 0;
            this.BtnRefreshP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRefreshP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRefreshP.ForeColor = System.Drawing.Color.White;
            this.BtnRefreshP.Image = global::GESTION_DE_STOCK.Properties.Resources.icons8_synchronize_351;
            this.BtnRefreshP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRefreshP.Location = new System.Drawing.Point(952, 186);
            this.BtnRefreshP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnRefreshP.Name = "BtnRefreshP";
            this.BtnRefreshP.Size = new System.Drawing.Size(291, 60);
            this.BtnRefreshP.TabIndex = 14;
            this.BtnRefreshP.Text = "Refresh";
            this.BtnRefreshP.UseVisualStyleBackColor = false;
            // 
            // BtnshowPicP
            // 
            this.BtnshowPicP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnshowPicP.FlatAppearance.BorderSize = 0;
            this.BtnshowPicP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnshowPicP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnshowPicP.ForeColor = System.Drawing.Color.White;
            this.BtnshowPicP.Image = global::GESTION_DE_STOCK.Properties.Resources.icons8_photo_gallery_35;
            this.BtnshowPicP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnshowPicP.Location = new System.Drawing.Point(1137, 58);
            this.BtnshowPicP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnshowPicP.Name = "BtnshowPicP";
            this.BtnshowPicP.Size = new System.Drawing.Size(291, 60);
            this.BtnshowPicP.TabIndex = 5;
            this.BtnshowPicP.Text = "Show Photo";
            this.BtnshowPicP.UseVisualStyleBackColor = false;
            // 
            // BtnUpdateP
            // 
            this.BtnUpdateP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnUpdateP.FlatAppearance.BorderSize = 0;
            this.BtnUpdateP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdateP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdateP.ForeColor = System.Drawing.Color.White;
            this.BtnUpdateP.Image = global::GESTION_DE_STOCK.Properties.Resources.icons8_update_35;
            this.BtnUpdateP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUpdateP.Location = new System.Drawing.Point(427, 58);
            this.BtnUpdateP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnUpdateP.Name = "BtnUpdateP";
            this.BtnUpdateP.Size = new System.Drawing.Size(291, 60);
            this.BtnUpdateP.TabIndex = 4;
            this.BtnUpdateP.Text = "Modifier";
            this.BtnUpdateP.UseVisualStyleBackColor = false;
            this.BtnUpdateP.Click += new System.EventHandler(this.BtnUpdateP_Click);
            // 
            // BtnDeleteP
            // 
            this.BtnDeleteP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnDeleteP.FlatAppearance.BorderSize = 0;
            this.BtnDeleteP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeleteP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteP.ForeColor = System.Drawing.Color.White;
            this.BtnDeleteP.Image = global::GESTION_DE_STOCK.Properties.Resources.icons8_waste_35;
            this.BtnDeleteP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDeleteP.Location = new System.Drawing.Point(785, 58);
            this.BtnDeleteP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnDeleteP.Name = "BtnDeleteP";
            this.BtnDeleteP.Size = new System.Drawing.Size(291, 60);
            this.BtnDeleteP.TabIndex = 3;
            this.BtnDeleteP.Text = "Delete";
            this.BtnDeleteP.UseVisualStyleBackColor = false;
            // 
            // BtnAddP
            // 
            this.BtnAddP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnAddP.FlatAppearance.BorderSize = 0;
            this.BtnAddP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddP.ForeColor = System.Drawing.Color.White;
            this.BtnAddP.Image = global::GESTION_DE_STOCK.Properties.Resources.icons8_add_35;
            this.BtnAddP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAddP.Location = new System.Drawing.Point(64, 58);
            this.BtnAddP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAddP.Name = "BtnAddP";
            this.BtnAddP.Size = new System.Drawing.Size(291, 60);
            this.BtnAddP.TabIndex = 2;
            this.BtnAddP.Text = "Add";
            this.BtnAddP.UseVisualStyleBackColor = false;
            this.BtnAddP.Click += new System.EventHandler(this.BtnAddC_Click);
            // 
            // USER_LIST_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnPrintAllP);
            this.Controls.Add(this.BtnExcelP);
            this.Controls.Add(this.BtnPrintPR);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnRefreshP);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.CMBCLIENT);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnshowPicP);
            this.Controls.Add(this.BtnUpdateP);
            this.Controls.Add(this.BtnDeleteP);
            this.Controls.Add(this.BtnAddP);
            this.Name = "USER_LIST_Product";
            this.Size = new System.Drawing.Size(1452, 853);
            this.Load += new System.EventHandler(this.USER_LIST_Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnUpdateP;
        private System.Windows.Forms.Button BtnDeleteP;
        private System.Windows.Forms.Button BtnAddP;
        private System.Windows.Forms.Button BtnshowPicP;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox CMBCLIENT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnRefreshP;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkGrd;
        private System.Windows.Forms.Button BtnPrintPR;
        private System.Windows.Forms.Button BtnExcelP;
        private System.Windows.Forms.Button BtnPrintAllP;
    }
}
