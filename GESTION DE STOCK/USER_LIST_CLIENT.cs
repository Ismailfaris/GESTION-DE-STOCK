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
    public partial class USER_LIST_CLIENT : UserControl
    {
        private static USER_LIST_CLIENT Userclient;
        public static USER_LIST_CLIENT Instance
        {
            get
            {
                if (Userclient == null)
                {
                    Userclient = new USER_LIST_CLIENT();
                }
                return Userclient;
            }
        }
        public USER_LIST_CLIENT()
        {
            InitializeComponent();
        }
        DBCLASS B = new DBCLASS();

        private void USER_LIST_CLIENT_Load(object sender, EventArgs e)
        {
            B.Open();
            
            if (B.ds.Tables["CLIENT"] != null)
            {
                B.ds.Tables["CLIENT"].Clear();
            }
            B.da = new SqlDataAdapter("SELECT [ID_CLIENT],[NOM_CLIENT],[PRENOM_CLIENT],[ADRESSE_CLIENT],[TELEPHONE_CLIENT],[PAYS_CLIENT],[VILLE_CLIENT],[EMAIL]FROM[CLIENT]", B.cnx);
            B.da.Fill(B.ds, "CLIENT");
            dataGridView1.DataSource = B.ds.Tables["CLIENT"];

            //Replissage du combo box
            //string[] comboText = { "ID", "Nom", "Prenom", "Telephon", "Email", "Ville", "Pays" };
            string[] comboValues = { "ID_CLIENT", "NOM_CLIENT", "PRENOM_CLIENT", "ADRESSE_CLIENT", "TELEPHONE_CLIENT", "PAYS_CLIENT", "VILLE_CLIENT", "EMAIL" };
            CMBCLIENT.Items.AddRange(comboValues);
            
        }

        private void BtnAddC_Click(object sender, EventArgs e)
        {
            AddClient AC = new AddClient();
            AC.ShowDialog();
        }

        private void BtnSearchC_Click(object sender, EventArgs e)
        {
           
        }

        private void CMBCLIENT_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (B.ds.Tables["CLIENT"] != null)
            {
                B.ds.Tables["CLIENT"].Clear();
            }
            B.da = new SqlDataAdapter("SELECT [ID_CLIENT],[NOM_CLIENT],[PRENOM_CLIENT],[ADRESSE_CLIENT],[TELEPHONE_CLIENT],[PAYS_CLIENT],[VILLE_CLIENT],[EMAIL]FROM[CLIENT] where "+ CMBCLIENT.SelectedText + "=" + textBox1.Text + "", B.cnx);
            B.da.Fill(B.ds, "CLIENT");
            dataGridView1.DataSource = B.ds.Tables["CLIENT"];
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
