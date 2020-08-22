namespace GESTION_DE_STOCK
{
    partial class USER_LIST_CLIENT
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(115, 163);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(935, 10);
            this.panel1.TabIndex = 2;
            // 
            // CMBCLIENT
            // 
            this.CMBCLIENT.FormattingEnabled = true;
            this.CMBCLIENT.Items.AddRange(new object[] {
            "ID_CLIENT"});
            this.CMBCLIENT.Location = new System.Drawing.Point(273, 202);
            this.CMBCLIENT.Name = "CMBCLIENT";
            this.CMBCLIENT.Size = new System.Drawing.Size(241, 24);
            this.CMBCLIENT.TabIndex = 3;
            this.CMBCLIENT.SelectedIndexChanged += new System.EventHandler(this.CMBCLIENT_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel2.Location = new System.Drawing.Point(546, 225);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(197, 10);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel3.Location = new System.Drawing.Point(115, 261);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(935, 10);
            this.panel3.TabIndex = 6;
            // 
            this.BtnDeleteC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnDeleteC.FlatAppearance.BorderSize = 0;
            this.BtnDeleteC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeleteC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteC.ForeColor = System.Drawing.Color.White;
            this.BtnDeleteC.Image = global::GESTION_DE_STOCK.Properties.Resources.icons8_waste_35;
            this.BtnDeleteC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDeleteC.Location = new System.Drawing.Point(569, 71);
            this.BtnDeleteC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnDeleteC.Name = "BtnDeleteC";
            this.BtnDeleteC.Size = new System.Drawing.Size(218, 49);
            this.BtnDeleteC.TabIndex = 1;
            this.BtnDeleteC.Text = "Delete";
            this.BtnDeleteC.UseVisualStyleBackColor = false;
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 311);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1137, 362);
            this.dataGridView1.TabIndex = 7;
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
            this.BtnUpdateC.Location = new System.Drawing.Point(331, 71);
            this.BtnUpdateC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnUpdateC.Name = "BtnUpdateC";
            this.BtnUpdateC.Size = new System.Drawing.Size(218, 49);
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
            this.BtnDeleteC.Location = new System.Drawing.Point(759, 87);
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
            this.BtnAddC.Location = new System.Drawing.Point(86, 71);
            this.BtnAddC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnAddC.Name = "BtnAddC";
            this.BtnAddC.Size = new System.Drawing.Size(218, 49);
            this.BtnAddC.TabIndex = 0;
            this.BtnAddC.Text = "Add";
            this.BtnAddC.UseVisualStyleBackColor = false;
            this.BtnAddC.Click += new System.EventHandler(this.BtnAddC_Click);
            // 
            // txtSearch
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(115, 163);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(935, 10);
            this.panel1.TabIndex = 2;
            // 
            // comboBox1
            // 
            
            // 
            // BtnSearchC
            // 
            
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel2.Location = new System.Drawing.Point(546, 225);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(197, 10);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel3.Location = new System.Drawing.Point(115, 261);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(935, 10);
            this.panel3.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(115, 311);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(935, 340);
            this.dataGridView1.TabIndex = 7;
            // 
            // USER_LIST_CLIENT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.CMBCLIENT);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnUpdateC);
            this.Controls.Add(this.BtnDeleteC);
            this.Controls.Add(this.BtnAddC);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "USER_LIST_CLIENT";
            this.Size = new System.Drawing.Size(853, 585);
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
        private System.Windows.Forms.TextBox txtSearch;
    }
}
