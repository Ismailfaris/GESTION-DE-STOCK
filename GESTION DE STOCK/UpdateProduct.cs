using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GESTION_DE_STOCK
{
    public partial class UpdateProduct : Form
    {
        private DBCLASS B = new DBCLASS();
        int productId;
        private DataRow row;
        public UpdateProduct(DataSet ds, SqlDataAdapter da, int id)
        {
            InitializeComponent();
            this.B.ds = ds;
            this.B.da = da;
            this.productId = id;
        }
        
        private bool Empty()
        {
            bool empty = false;
            foreach (Control c in this.Controls)
            {
                if (c.GetType() == txtNomProduit.GetType())
                {
                    if (c.Text == "")
                    {
                        empty = true;
                        return empty;
                    }
                }
            }
            return empty;
        }

        private void BtnSaveP_Click(object sender, EventArgs e)
        {
            int index = -1;
            
            try
            {
                if (!Empty())
                {
                    index = B.ds.Tables["PRODUITS"].Rows.IndexOf(row);
                    B.ds.Tables["PRODUITS"].Rows[index][1] = txtNomProduit.Text;
                    B.ds.Tables["PRODUITS"].Rows[index][2] = txtQuantite.Text;
                    B.ds.Tables["PRODUITS"].Rows[index][3] = txtPrix.Text;
                    B.ds.Tables["PRODUITS"].Rows[index][4] = null;
                    B.ds.Tables["PRODUITS"].Rows[index][5] = comboBox1.SelectedValue;
                    SqlCommandBuilder cmdB = new SqlCommandBuilder(B.da);
                    B.da.UpdateCommand = cmdB.GetUpdateCommand();
                    B.da.Update(B.ds, "PRODUITS");
                    MessageBox.Show("Modifiee");
                }
                else
                {
                    MessageBox.Show("Vous avez laisse des champs vide !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void UpdateProduct_Load(object sender, EventArgs e)
        {
            DataTable Categories = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT ID_CATEGORIE, NOM_CATEGORIE FROM CATEGORIE", B.cnx);
            da.Fill(Categories);
            comboBox1.DataSource = Categories;
            comboBox1.DisplayMember = "NOM_CATEGORIE";
            comboBox1.ValueMember = "ID_CATEGORIE";
            if (productId != -1)
            {
                row = B.ds.Tables["PRODUITS"].Select(string.Format("ID_PRODUIT = {0}", productId))[0];
                txtNomProduit.Text = row[1].ToString();
                txtQuantite.Text = row[2].ToString();
                txtPrix.Text = row[3].ToString();
                txtImage.Text = row[4].ToString();
                comboBox1.SelectedValue = row[5];
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
