﻿using System;
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
        }

        private void BtnAddC_Click(object sender, EventArgs e)
        {
            AddProduct AP = new AddProduct(B.ds, B.da);
            AP.ShowDialog();
        }

        private void BtnUpdateP_Click(object sender, EventArgs e)
        {
            UpdateProduct UP = new UpdateProduct();
            UP.ShowDialog();
        }
    }
}
