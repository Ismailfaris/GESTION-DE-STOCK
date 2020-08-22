namespace GESTION_DE_STOCK
{
    partial class USER_LIST_Category
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
            this.DGVCATEGORY = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CMBCategory = new System.Windows.Forms.ComboBox();
            this.BtnAddCA = new System.Windows.Forms.Button();
            this.BtnExcelCA = new System.Windows.Forms.Button();
            this.BtnPrintAllCA = new System.Windows.Forms.Button();
            this.BtnSearchCA = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCATEGORY)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVCATEGORY
            // 
            this.DGVCATEGORY.AllowUserToAddRows = false;
            this.DGVCATEGORY.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCATEGORY.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Update,
            this.Delete});
            this.DGVCATEGORY.Location = new System.Drawing.Point(398, 277);
            this.DGVCATEGORY.Margin = new System.Windows.Forms.Padding(4);
            this.DGVCATEGORY.Name = "DGVCATEGORY";
            this.DGVCATEGORY.RowHeadersWidth = 51;
            this.DGVCATEGORY.RowTemplate.Height = 24;
            this.DGVCATEGORY.Size = new System.Drawing.Size(645, 418);
            this.DGVCATEGORY.TabIndex = 16;
            this.DGVCATEGORY.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCATEGORY_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel3.Location = new System.Drawing.Point(103, 257);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1247, 12);
            this.panel3.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel2.Location = new System.Drawing.Point(895, 168);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(272, 12);
            this.panel2.TabIndex = 14;
            // 
            // CMBCategory
            // 
            this.CMBCategory.FormattingEnabled = true;
            this.CMBCategory.Location = new System.Drawing.Point(522, 146);
            this.CMBCategory.Margin = new System.Windows.Forms.Padding(4);
            this.CMBCategory.Name = "CMBCategory";
            this.CMBCategory.Size = new System.Drawing.Size(320, 24);
            this.CMBCategory.TabIndex = 13;
            // 
            // BtnAddCA
            // 
            this.BtnAddCA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnAddCA.FlatAppearance.BorderSize = 0;
            this.BtnAddCA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddCA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddCA.ForeColor = System.Drawing.Color.White;
            this.BtnAddCA.Image = global::GESTION_DE_STOCK.Properties.Resources.icons8_add_35;
            this.BtnAddCA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAddCA.Location = new System.Drawing.Point(122, 124);
            this.BtnAddCA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAddCA.Name = "BtnAddCA";
            this.BtnAddCA.Size = new System.Drawing.Size(291, 60);
            this.BtnAddCA.TabIndex = 9;
            this.BtnAddCA.Text = "Add";
            this.BtnAddCA.UseVisualStyleBackColor = false;
            this.BtnAddCA.Click += new System.EventHandler(this.BtnAddCA_Click);
            // 
            // BtnExcelCA
            // 
            this.BtnExcelCA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnExcelCA.FlatAppearance.BorderSize = 0;
            this.BtnExcelCA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExcelCA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcelCA.ForeColor = System.Drawing.Color.White;
            this.BtnExcelCA.Image = global::GESTION_DE_STOCK.Properties.Resources.icons8_microsoft_excel_2019_35;
            this.BtnExcelCA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExcelCA.Location = new System.Drawing.Point(1059, 743);
            this.BtnExcelCA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnExcelCA.Name = "BtnExcelCA";
            this.BtnExcelCA.Size = new System.Drawing.Size(291, 60);
            this.BtnExcelCA.TabIndex = 18;
            this.BtnExcelCA.Text = "Save at Excel";
            this.BtnExcelCA.UseVisualStyleBackColor = false;
            // 
            // BtnPrintAllCA
            // 
            this.BtnPrintAllCA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnPrintAllCA.FlatAppearance.BorderSize = 0;
            this.BtnPrintAllCA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPrintAllCA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrintAllCA.ForeColor = System.Drawing.Color.White;
            this.BtnPrintAllCA.Image = global::GESTION_DE_STOCK.Properties.Resources.icons8_print_351;
            this.BtnPrintAllCA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPrintAllCA.Location = new System.Drawing.Point(103, 743);
            this.BtnPrintAllCA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnPrintAllCA.Name = "BtnPrintAllCA";
            this.BtnPrintAllCA.Size = new System.Drawing.Size(291, 60);
            this.BtnPrintAllCA.TabIndex = 19;
            this.BtnPrintAllCA.Text = "Print all";
            this.BtnPrintAllCA.UseVisualStyleBackColor = false;
            // 
            // BtnSearchCA
            // 
            this.BtnSearchCA.FlatAppearance.BorderSize = 0;
            this.BtnSearchCA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearchCA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearchCA.Location = new System.Drawing.Point(895, 138);
            this.BtnSearchCA.Name = "BtnSearchCA";
            this.BtnSearchCA.Size = new System.Drawing.Size(272, 32);
            this.BtnSearchCA.TabIndex = 20;
            this.BtnSearchCA.Text = "Search";
            this.BtnSearchCA.UseVisualStyleBackColor = true;
            this.BtnSearchCA.Click += new System.EventHandler(this.BtnSearchCA_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.FlatAppearance.BorderSize = 0;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Location = new System.Drawing.Point(1205, 138);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(192, 34);
            this.BtnCancel.TabIndex = 21;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(1205, 170);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 10);
            this.panel1.TabIndex = 15;
            // 
            // Update
            // 
            this.Update.HeaderText = "Update";
            this.Update.MinimumWidth = 6;
            this.Update.Name = "Update";
            this.Update.Text = "Update";
            this.Update.UseColumnTextForButtonValue = true;
            this.Update.Width = 125;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 125;
            // 
            // USER_LIST_Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSearchCA);
            this.Controls.Add(this.BtnPrintAllCA);
            this.Controls.Add(this.BtnExcelCA);
            this.Controls.Add(this.DGVCATEGORY);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.CMBCategory);
            this.Controls.Add(this.BtnAddCA);
            this.Name = "USER_LIST_Category";
            this.Size = new System.Drawing.Size(1452, 853);
            this.Load += new System.EventHandler(this.USER_LIST_Category_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVCATEGORY)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVCATEGORY;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox CMBCategory;
        private System.Windows.Forms.Button BtnAddCA;
        private System.Windows.Forms.Button BtnExcelCA;
        private System.Windows.Forms.Button BtnPrintAllCA;
        private System.Windows.Forms.Button BtnSearchCA;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewButtonColumn Update;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}
