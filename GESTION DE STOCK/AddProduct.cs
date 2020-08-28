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
using System.Xml;
using System.Xml.XPath;

namespace GESTION_DE_STOCK
{
    public partial class AddProduct : Form
    {
        private DBCLASS B = new DBCLASS();
        public AddProduct(DataSet ds, SqlDataAdapter da)
        {
            InitializeComponent();
            this.B.ds = ds;
            this.B.da = da;
        }
        private bool Empty()
        {
            bool empty = false;
            foreach (Control c in this.Controls)
            {
                if(c.GetType() == txtNomProduit.GetType())
                {
                    if(c.Text == "")
                    {
                        empty = true;
                        return empty;
                    }
                }
            }
            return empty;
        }
        private void clearFields()
        {
            foreach (Control c in this.Controls)
            {
                if (c.GetType() == txtNomProduit.GetType())
                {
                    c.Text = "";
                }
            }
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSaveP_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow newRow = B.ds.Tables["PRODUITS"].NewRow();
                SqlCommandBuilder cmdB = new SqlCommandBuilder(B.da);
                if (!Empty())
                {
                    newRow[0] = Convert.ToInt32(B.ds.Tables["PRODUITS"].Rows[B.ds.Tables["PRODUITS"].Rows.Count - 1][0]) + 1;
                    newRow[1] = txtNomProduit.Text;
                    newRow[2] = txtQuantite.Text;
                    newRow[3] = txtPrix.Text;
                    newRow[4] = null;
                    newRow[5] = comboBox1.SelectedValue;
                    B.ds.Tables["PRODUITS"].Rows.Add(newRow);
                    B.da.InsertCommand = cmdB.GetInsertCommand();
                    clearFields();
                    MessageBox.Show(B.da.Update(B.ds.Tables["PRODUITS"]).ToString() + "produit ajouter ");
                }
                else
                    MessageBox.Show("Vous avez laisser des champs vide !");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            DataTable Categories = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT ID_CATEGORIE, NOM_CATEGORIE FROM CATEGORIE", B.cnx);
            da.Fill(Categories);
            comboBox1.DataSource = Categories;
            comboBox1.DisplayMember = "NOM_CATEGORIE";
            comboBox1.ValueMember = "ID_CATEGORIE";
        }

        private void BtnBrowseP_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog()
            {
                Filter = "Images(*.JPG, *.JPEG, *.PNG)| *.JPG; *.JPEG; *.PNG | All files (*.*)|*.*",
                Multiselect = false,
            };
                
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtImage.Text = openFileDialog1.FileName;
            }
        }

        private void BtnRefreshP_Click(object sender, EventArgs e)
        {
            clearFields();
        }
    }
}
