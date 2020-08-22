using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GESTION_DE_STOCK
{
    public partial class USER_LIST_CLIENT : UserControl
    {
        private DBCLASS B = new DBCLASS();
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


        private void USER_LIST_CLIENT_Load(object sender, EventArgs e)
        {
            B.Open();

            if (B.ds.Tables["CLIENT"] != null)
            {
                B.ds.Tables["CLIENT"].Clear();
            }
            B.da = new SqlDataAdapter("SELECT [NOM_CLIENT],[PRENOM_CLIENT],[ADRESSE_CLIENT],[TELEPHONE_CLIENT],[PAYS_CLIENT],[VILLE_CLIENT],[EMAIL]FROM[CLIENT]", B.cnx);
            B.da.Fill(B.ds, "CLIENT");

            dataGridView1.DataSource = B.ds.Tables["CLIENT"];
            //Replissage du combo box
            string[] comboText = { "Nom", "Prenom", "Telephon", "Ville", "Pays" };
            //string[] comboValues = { "ID_CLIENT", "NOM_CLIENT", "PRENOM_CLIENT", "ADRESSE_CLIENT", "TELEPHONE_CLIENT", "PAYS_CLIENT", "VILLE_CLIENT", "EMAIL" };
            CMBCLIENT.Items.AddRange(comboText);
        }

        private void BtnAddC_Click(object sender, EventArgs e)
        {
            AddClient AC = new AddClient();
            AC.ShowDialog();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            //Rechercher
            DataView dv = B.ds.Tables["CLIENT"].DefaultView;
            switch (CMBCLIENT.SelectedIndex)
            {
                case 0:
                    dv.RowFilter = string.Format("NOM_CLIENT LIKE '%{0}%'", textBox1.Text);
                    dataGridView1.DataSource = dv.ToTable();
                    break;

                case 1:
                    dv.RowFilter = string.Format("PRENOM_CLIENT LIKE '%{0}%'", textBox1.Text);
                    dataGridView1.DataSource = dv.ToTable();
                    break;

                case 2:
                    dv.RowFilter = string.Format("TELEPHONE_CLIENT LIKE '%{0}%'", textBox1.Text);
                    dataGridView1.DataSource = dv.ToTable();
                    break;

                case 3:
                    dv.RowFilter = string.Format("VILLE_CLIENT LIKE '%{0}%'", textBox1.Text);
                    dataGridView1.DataSource = dv.ToTable();
                    break;

                case 4:
                    dv.RowFilter = string.Format("PAYS_CLIENT LIKE '%{0}%'", textBox1.Text);
                    dataGridView1.DataSource = dv.ToTable();
                    break;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}
