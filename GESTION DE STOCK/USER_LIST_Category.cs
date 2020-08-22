using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GESTION_DE_STOCK
{
    public partial class USER_LIST_Category : UserControl
    {
        private static USER_LIST_Category UserCategory;
        public static USER_LIST_Category Instance
        {
            get
            {
                if (UserCategory == null)
                {
                    UserCategory = new USER_LIST_Category();
                }
                return UserCategory;
            }
        }
        public USER_LIST_Category()
        {
            InitializeComponent();
        }
        DBCLASS B = new DBCLASS();
        public void LoadCombo()
        {
            CMBCategory.Items.Clear();          
            B.da = new SqlDataAdapter("SELECT [ID_CATEGORIE],[NOM_CATEGORIE]FROM [dbo].[CATEGORIE]", B.cnx);
            B.da.Fill(B.ds, "CATEGORY");
            CMBCategory.DataSource = B.ds.Tables["CATEGORY"];
            CMBCategory.DisplayMember = "NOM_CATEGORIE";
            CMBCategory.ValueMember = "ID_CATEGORIE";
        }
        private void USER_LIST_Category_Load(object sender, EventArgs e)
        {
            B.da = new SqlDataAdapter("SELECT [ID_CATEGORIE],[NOM_CATEGORIE]FROM [dbo].[CATEGORIE]", B.cnx);
            B.da.Fill(B.dt);
            DGVCATEGORY.DataSource = B.dt;
            while (CMBCategory.Text == "")
            {
                B.da = new SqlDataAdapter("SELECT [ID_CATEGORIE],[NOM_CATEGORIE]FROM [dbo].[CATEGORIE]", B.cnx);
                B.da.Fill(B.ds, "CATEGORY");
                CMBCategory.DataSource = B.ds.Tables["CATEGORY"];
                CMBCategory.DisplayMember = "NOM_CATEGORIE";
                CMBCategory.ValueMember = "ID_CATEGORIE";
                
            }
            
        }

        private void BtnAddCA_Click(object sender, EventArgs e)
        {
            AddCategory ACA = new AddCategory();
            ACA.ShowDialog();
            CMBCategory.SelectedIndex = -1;

            BtnSearchCA.PerformClick();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnSearchCA_Click(object sender, EventArgs e)
        {
            if (B.ds.Tables["MAT"] != null)
            {
                B.ds.Tables["MAT"].Clear();
            }
            if (CMBCategory.SelectedIndex == -1)
            {
                B.da = new SqlDataAdapter("SELECT [ID_CATEGORIE],[NOM_CATEGORIE]FROM [dbo].[CATEGORIE]", B.cnx);
                B.da.Fill(B.ds, "MAT");
                DGVCATEGORY.DataSource = B.ds.Tables["MAT"];
            }
            else
            {
                B.da = new SqlDataAdapter("SELECT [ID_CATEGORIE],[NOM_CATEGORIE]FROM [dbo].[CATEGORIE] where ID_CATEGORIE=" + CMBCategory.SelectedValue + "", B.cnx);
                B.da.Fill(B.ds, "MAT");
                DGVCATEGORY.DataSource = B.ds.Tables["MAT"];
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CMBCategory.SelectedIndex = -1;
        }

        private void DGVCATEGORY_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGVCATEGORY.Columns[e.ColumnIndex].Name== "Delete")
            {
                if (MessageBox.Show("Are you sure want to delete this Category ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    B.Open();
                    B.cmd = new SqlCommand("DELETE FROM [CATEGORIE] WHERE NOM_CATEGORIE='" + DGVCATEGORY.SelectedCells[0].Value.ToString() + "'", B.cnx);
                    B.cmd.ExecuteNonQuery();
                    B.Close();
                    MessageBox.Show("Deleted!", "Suppression", MessageBoxButtons.OK);
                    CMBCategory.SelectedIndex = -1;
                    BtnSearchCA.PerformClick();
                }
            }
        }
    }
}
