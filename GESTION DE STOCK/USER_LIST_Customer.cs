using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GESTION_DE_STOCK
{
    public partial class USER_LIST_Customer : UserControl
    {
        private DBCLASS B = new DBCLASS();
        private static USER_LIST_Customer Userclient;
        public static USER_LIST_Customer Instance
        {
            get
            {
                if (Userclient == null)
                {
                    Userclient = new USER_LIST_Customer();
                }
                return Userclient;
            }
        }
        public USER_LIST_Customer()
        {
            InitializeComponent();
        }


        

        private void USER_LIST_Customer_Load(object sender, EventArgs e)
        {
            B.Open();

            if (B.ds.Tables["CLIENT"] != null)
            {
                B.ds.Tables["CLIENT"].Clear();
            }
            B.da = new SqlDataAdapter("SELECT [ID_CLIENT],[NOM_CLIENT],[PRENOM_CLIENT],[ADRESSE_CLIENT],[TELEPHONE_CLIENT],[PAYS_CLIENT],[VILLE_CLIENT],[EMAIL]FROM[CLIENT]", B.cnx);
            B.da.Fill(B.ds, "CLIENT");

            DGVCustomer.DataSource = B.ds.Tables["CLIENT"];
            //Replissage du combo box
            string[] comboText = { "Nom", "Prenom", "Telephon", "Ville", "Pays" };
            //string[] comboValues = { "ID_CLIENT", "NOM_CLIENT", "PRENOM_CLIENT", "ADRESSE_CLIENT", "TELEPHONE_CLIENT", "PAYS_CLIENT", "VILLE_CLIENT", "EMAIL" };
            CMBCUSTOMER.Items.AddRange(comboText);
        }

        private void BtnAddCu_Click(object sender, EventArgs e)
        {
            AddCustomer AC = new AddCustomer(B.ds, B.da);
            AC.ShowDialog();
        }

        private void txtCustomer_KeyUp(object sender, KeyEventArgs e)
        {
            //Rechercher
            DataView dv = B.ds.Tables["CLIENT"].DefaultView;
            switch (CMBCUSTOMER.SelectedIndex)
            {
                case 0:
                    dv.RowFilter = string.Format("NOM_CLIENT LIKE '%{0}%'", txtCustomer.Text);
                    DGVCustomer.DataSource = dv.ToTable();
                    break;

                case 1:
                    dv.RowFilter = string.Format("PRENOM_CLIENT LIKE '%{0}%'", txtCustomer.Text);
                    DGVCustomer.DataSource = dv.ToTable();
                    break;

                case 2:
                    dv.RowFilter = string.Format("TELEPHONE_CLIENT LIKE '%{0}%'", txtCustomer.Text);
                    DGVCustomer.DataSource = dv.ToTable();
                    break;

                case 3:
                    dv.RowFilter = string.Format("VILLE_CLIENT LIKE '%{0}%'", txtCustomer.Text);
                    DGVCustomer.DataSource = dv.ToTable();
                    break;

                case 4:
                    dv.RowFilter = string.Format("PAYS_CLIENT LIKE '%{0}%'", txtCustomer.Text);
                    DGVCustomer.DataSource = dv.ToTable();
                    break;
            }
        }

        private void txtCustomer_Enter(object sender, EventArgs e)
        {
            txtCustomer.Clear();
        }
        int clientId = -1;
        private void BtnUpdateCu_Click(object sender, EventArgs e)
        {
            
            //for (int i = 0; i > DGVCustomer.Rows.Count; i++)
            //{
            //    if (DGVCustomer.Rows[i].Cells["chkSelect"].Selected)
            //    {
            //        clientId = Convert.ToInt32(DGVCustomer.Rows[i].Cells[1]);
            //    }
            //}
            foreach(DataGridViewRow row in DGVCustomer.Rows)
            {
                if (row.Cells[0].Selected)
                {
                    clientId = Convert.ToInt32(row.Cells[1].Value);
                }
            }
            //if (clientId != -1)
            //{
                UpdateCustomer UC = new UpdateCustomer(clientId, B.ds, B.da);
                UC.ShowDialog();
            //}
            //else
            //    MessageBox.Show("Veuillez Cocher une ligne !");
        }

        private void BtnDeleteCu_Click(object sender, EventArgs e)
        {
            //For deleting 1 client at time 
            //Will be updated later for multiple deletes
            int clientId = -1;
            DataRow[] toBeDeleted;
            int row_index = -1;
            SqlCommandBuilder cmdB;
            try
            {
                foreach (DataGridViewRow dataRow in DGVCustomer.Rows)
                {
                    if (dataRow.Cells["chkSelect"].Selected)
                    {
                        clientId = int.Parse(dataRow.Cells[1].Value.ToString());
                    }
                }
                toBeDeleted = B.ds.Tables["CLIENT"].Select(string.Format("ID_CLIENT = {0}", clientId));
                row_index = B.ds.Tables["CLIENT"].Rows.IndexOf(toBeDeleted[0]);
                if (MessageBox.Show("Ete Vou sure ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    B.ds.Tables["CLIENT"].Rows.RemoveAt(row_index);
                    B.ds.AcceptChanges();
                    cmdB = new SqlCommandBuilder(B.da);
                    B.da.UpdateCommand = cmdB.GetUpdateCommand();
                    B.da.DeleteCommand = cmdB.GetDeleteCommand();
                    Console.WriteLine( B.da.Update(B.ds, "CLIENT") );
                    
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
            
        }
    }
}
