using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GESTION_DE_STOCK
{
    public partial class UpdateCustomer : Form
    {
        private DBCLASS B = new DBCLASS();
        private int clientId;
        
        public UpdateCustomer(int clientId,DataSet data)
        {
            InitializeComponent();
            this.B.ds = data;
            this.clientId = clientId;
        }
        private void clear_fields()
        {
            foreach (Control c in this.Controls)
            {
                if (c.GetType() == txtNom.GetType())
                    c.Text = "";
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void UpdateCustomer_Load(object sender, EventArgs e)
        {
            DataRow[] dr = B.ds.Tables["CLIENT"].Select(string.Format("ID_CLIENT = {0}", clientId));
            txtNom.Text = dr[0]["NOM_CLIENT"].ToString();
            txtPrenom.Text = dr[0]["PRENOM_CLIENT"].ToString();
            txtTel.Text = dr[0]["TELEPHONE_CLIENT"].ToString();
            txtEmail.Text = dr[0]["EMAIL"].ToString();
            txtVille.Text = dr[0]["VILLE_CLIENT"].ToString();
            txtAdress.Text = dr[0]["ADRESSE_CLIENT"].ToString();
            txtPays.Text = dr[0]["PAYS_CLIENT"].ToString();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clear_fields();
        }
    }
}
