using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GESTION_DE_STOCK
{
    public partial class AddClient : Form
    {
        private DBCLASS db = new DBCLASS();
        public AddClient()
        {
            InitializeComponent();
        }
        private bool chkTextBox_empty()
        {
            bool isEmpty = false;
            if ( txtNom.Text == "" | txtPrenom.Text == "" |txtAddress.Text == "" | txtEmail.Text == "" |
                txtPays.Text == "" | txtTele.Text == "" | txtVille.Text == "")
            {
                isEmpty = true;
            }
                
            return isEmpty;
        }
        private void clear_fields()
        {
            txtNom.Text = txtPrenom.Text = txtAddress.Text = txtEmail.Text = txtPays.Text = txtTele.Text = txtVille.Text = "";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddClient_Load(object sender, EventArgs e)
        {
            clear_fields();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                bool empty = chkTextBox_empty();
                if (!empty)
                {
                    db.cmd = new SqlCommand("insert into " +
                        "CLIENT( NOM_CLIENT, PRENOM_CLIENT, ADRESSE_CLIENT, TELEPHONE_CLIENT, PAYS_CLIENT, VILLE_CLIENT, EMAIL)"
                        + "values(@nom, @prenom, @adresse, @telephone, @pays, @ville, @email)");
                    db.cmd.Connection = db.cnx;
                    db.cmd.Parameters.AddWithValue("@nom", txtNom.Text);
                    db.cmd.Parameters.AddWithValue("@prenom", txtPrenom.Text);
                    db.cmd.Parameters.AddWithValue("@adresse", txtAddress.Text);
                    db.cmd.Parameters.AddWithValue("@telephone", txtTele.Text);
                    db.cmd.Parameters.AddWithValue("@pays", txtPays.Text);
                    db.cmd.Parameters.AddWithValue("@ville", txtVille.Text);
                    db.cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    db.Open();
                    db.cmd.ExecuteNonQuery();
                    db.Close();
                    clear_fields();
                    MessageBox.Show("Ajouter");

                }
                else
                {
                    MessageBox.Show("Tous les champs doit etre remplis !");
                }
            } catch(Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }
    }
}
