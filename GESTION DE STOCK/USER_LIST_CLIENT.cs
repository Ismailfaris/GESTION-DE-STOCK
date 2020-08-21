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
            B.CONNECTER();
            comboBox1.Items.Clear();
            B.da = new SqlDataAdapter("SELECT [ID_CLIENT],[NOM_CLIENT]FROM[CLIENT]", B.con);
            B.da.Fill(B.ds, "CL");
            comboBox1.DataSource = B.ds.Tables["CL"];
            comboBox1.DisplayMember = "NOM_CLIENT";
            comboBox1.ValueMember = "ID_CLIENT";

        }

        private void BtnAddC_Click(object sender, EventArgs e)
        {
            AddClient AC = new AddClient();
            AC.ShowDialog();
        }
    }
}
