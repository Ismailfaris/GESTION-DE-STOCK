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
    public partial class AddCategory : Form
    {
        public AddCategory()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddCategory_Load(object sender, EventArgs e)
        {

        }
        DBCLASS B = new DBCLASS();
        
        private void BtnSaveCA_Click(object sender, EventArgs e)
        {
            B.Open();
            
            try
            {
                B.Open();
                if (txtNameCA.Text == "")
                {
                    MessageBox.Show("Le champ NOM CATEGORIE et vide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    B.cmd = new SqlCommand("INSERT INTO [dbo].[CATEGORIE]([NOM_CATEGORIE])VALUES('" + txtNameCA.Text + "')", B.cnx);
                    B.cmd.ExecuteNonQuery();
                    MessageBox.Show("Ajouté avec succes", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNameCA.Text = "";
                    
                    
                }
                B.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
