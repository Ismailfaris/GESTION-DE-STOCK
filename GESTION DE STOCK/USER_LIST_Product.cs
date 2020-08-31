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
using System.IO;
using System.Globalization;

namespace GESTION_DE_STOCK
{
    public partial class USER_LIST_Product : UserControl
    {
        
        private DBCLASS B = new DBCLASS();
        private static USER_LIST_Product UserProduct;
        public static USER_LIST_Product Instance
        {
            get
            {
                if (UserProduct == null)
                {
                    UserProduct = new USER_LIST_Product();
                }
                return UserProduct;
            }
        }
        public USER_LIST_Product()
        {
            InitializeComponent();
        }

        private void USER_LIST_Product_Load(object sender, EventArgs e)
        {
            
            B.da = new SqlDataAdapter("SELECT ID_PRODUIT, NOM_PRODUIT, QUANTITE_PRODUIT, PRIX_PRODUIT,IMAGE_PRODUIT, ID_CATEGORIE FROM PRODUIT ", B.cnx);
            B.da.Fill(B.ds, "PRODUITS");
            dgvProduct.DataSource = B.ds.Tables["PRODUITS"];
            dgvProduct.Columns[5].Visible = false;
            dgvProduct.Columns[1].Visible = false;
            string[] comboValue = { "Nom"};
            cmbSearch.Items.AddRange(comboValue);
        }

        private void BtnAddC_Click(object sender, EventArgs e)
        {
            AddProduct AP = new AddProduct(B.ds, B.da);
            AP.ShowDialog();
        }

        private void BtnUpdateP_Click(object sender, EventArgs e)
        {
            try
            {
                int productId = -1;
                
                foreach (DataGridViewRow row in dgvProduct.Rows)
                {
                    if (Convert.ToBoolean(row.Cells["chkSelect"].Value))
                    {
                        productId = Convert.ToInt32(row.Cells[1].Value);
                    }
                }
                if (productId == -1)
                    MessageBox.Show("Selectionner d'abord un produit !!");
                else
                {
                    UpdateProduct UP = new UpdateProduct(B.ds, B.da, productId);
                    UP.ShowDialog();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show( "Error : " + ex.Message);
            }
        }

        private void BtnDeleteP_Click(object sender, EventArgs e)
        {
            try
            {
                int productId = -1;

                foreach (DataGridViewRow row in dgvProduct.Rows)
                {
                    if (Convert.ToBoolean(row.Cells["chkSelect"].Value))
                    {
                        productId = Convert.ToInt32(row.Cells[1].Value);
                    }
                }
                if (productId == -1)
                    MessageBox.Show("Selectionner d'abord un produit !!");
                else
                {
                    int index = B.ds.Tables["PRODUITS"].Rows.IndexOf( B.ds.Tables["PRODUITS"].Select( "ID_PRODUIT = " + productId.ToString() )[0] );
                    B.ds.Tables["PRODUITS"].Rows[index].Delete();
                    SqlCommandBuilder cmdB = new SqlCommandBuilder(B.da);
                    B.da.Update(B.ds, "PRODUITS");
                    MessageBox.Show("Supprimer avec succee. ");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            DataView dv = B.ds.Tables["PRODUITS"].DefaultView;
            if (dgvProduct.DataSource != null)
                dgvProduct.DataSource = null;
            dv.RowFilter = string.Format("NOM_PRODUIT Like '%{0}%'", textBox1.Text);
            dgvProduct.DataSource = dv.ToTable();
            switch (cmbSearch.SelectedItem)
            {
                case "Nom":
                    dv.RowFilter = string.Format("NOM_PRODUIT Like '%{0}%'", textBox1.Text);
                    dgvProduct.DataSource = dv.ToTable();
                    break;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}
