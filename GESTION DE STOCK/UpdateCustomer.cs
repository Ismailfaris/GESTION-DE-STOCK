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
    public partial class UpdateCustomer : Form
    {
        private DBCLASS B = new DBCLASS();
        private int clientId;
        private DataRow[] dr;


        public UpdateCustomer(int clientId,DataSet data, SqlDataAdapter da)
        {
            InitializeComponent();
            this.B.ds = data;
            this.clientId = clientId;
            this.B.da = da; 
        }
        private void clear_fields()
        {
            foreach (Control c in this.Controls)
            {
                if (c.GetType() == txtNom.GetType())
                    c.Text = "";
            }
        }
        private bool isEmpty()
        {
            bool empty = true;
            foreach (Control c in this.Controls)
            {
                if (c.GetType() == txtNom.GetType())
                {
                    if(c.Text.Trim() == "")
                    {
                        empty = true;
                        return empty;
                    }
                    else
                        empty = false;
                }
            }
            return empty;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (isEmpty())
                {
                    MessageBox.Show("Tous les champs doit etre  remplis !");
                }
                else
                {
                    int x = B.ds.Tables["CLIENT"].Rows.IndexOf(dr[0]);
                    B.ds.Tables["CLIENT"].Rows[x][0] = clientId;
                    B.ds.Tables["CLIENT"].Rows[x][1] = txtNom.Text;
                    B.ds.Tables["CLIENT"].Rows[x][2] = txtPrenom.Text;
                    B.ds.Tables["CLIENT"].Rows[x][3] = txtAdress.Text;
                    B.ds.Tables["CLIENT"].Rows[x][4] = txtTel.Text;
                    B.ds.Tables["CLIENT"].Rows[x][5] = txtPays.Text;
                    B.ds.Tables["CLIENT"].Rows[x][6] = txtVille.Text;
                    B.ds.Tables["CLIENT"].Rows[x][7] = txtEmail.Text;

                    SqlCommandBuilder cmdB = new SqlCommandBuilder(B.da);
                    B.da.UpdateCommand = cmdB.GetUpdateCommand();
                    B.da.Update(B.ds, "CLIENT");
                    MessageBox.Show("Le client est modifie avec succee ","Modifier Client",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
            }
        }

        private void UpdateCustomer_Load(object sender, EventArgs e)
        {
            dr = B.ds.Tables["CLIENT"].Select(string.Format("ID_CLIENT = {0}", clientId));
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
