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
    public partial class AddCustomer : Form
    {
        private DBCLASS B = new DBCLASS();
        public AddCustomer(DataSet ds, SqlDataAdapter da)
        {
            InitializeComponent();
            this.B.da = da;
            this.B.ds = ds;

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
                int LastIndex = B.ds.Tables["CLIENT"].Rows.Count - 1;
                DataRow newLign = B.ds.Tables["Client"].NewRow();
                SqlCommandBuilder cmdB;
                if (!empty)
                {
                    newLign["ID_CLIENT"] = (Convert.ToInt32(B.ds.Tables["CLIENT"].Rows[LastIndex][0]) + 1);
                    newLign["NOM_CLIENT"] = txtNom.Text; 
                    newLign["PRENOM_CLIENT"] = txtPrenom.Text;
                    newLign["TELEPHONE_CLIENT"] = txtTele.Text;
                    newLign["EMAIL"] = txtEmail.Text;
                    newLign["VILLE_CLIENT"] = txtVille.Text;
                    newLign["ADRESSE_CLIENT"] = txtAddress.Text;
                    newLign["PAYS_CLIENT"] = txtPays.Text;
                    B.ds.Tables["CLIENT"].Rows.Add(newLign);
                    cmdB = new SqlCommandBuilder(B.da);
                    B.da.InsertCommand = cmdB.GetInsertCommand();
                    B.da.Update(B.ds, "CLIENT");
                    clear_fields();
                    MessageBox.Show("Ajouter avec succee");

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

        private void button1_Click(object sender, EventArgs e)
        {
            clear_fields();
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
