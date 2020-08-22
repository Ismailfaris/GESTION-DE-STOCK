using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GESTION_DE_STOCK
{
    public partial class FRM_Connection : Form
    {
        public FRM_Connection()
        {
            InitializeComponent();
        }

        private void FRM_Connection_Load(object sender, EventArgs e)
        {
            
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        DBCLASS B = new DBCLASS();
        private void button1_Click(object sender, EventArgs e)
        {
            
            B.cnx.Open();

            B.cmd = new SqlCommand("SELECT [NOMUTILISATEUR],[MOT_DE_PASSE],[TYPE_UTILISATEUR]FROM [dbo].[UTILISATEUR]where NOMUTILISATEUR='" + txtUsername.Text + "' and MOT_DE_PASSE='" + txtPassword.Text + "'", B.cnx);

            B.da = new SqlDataAdapter(B.cmd);
            DataTable dt = new DataTable();
            B.da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                this.Hide();
                FRM_MENU f = new FRM_MENU();
                f.Show();
            }
            else if (txtUsername.Text == "")
            {
                MessageBox.Show("Compte vide !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Motdepass vide !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(" Nom de compte ou mot de passe incorrect", "Error",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            B.cnx.Close();
        }

        private void txtUsername_MouseClick(object sender, MouseEventArgs e)
        {
            txtUsername.Text = "";
        }

        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            txtPassword.Text = "";
        }
    }
}
