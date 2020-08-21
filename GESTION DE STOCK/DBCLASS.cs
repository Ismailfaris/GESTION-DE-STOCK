using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Threading.Tasks;

namespace GESTION_DE_STOCK
{
    class DBCLASS
    {
        public SqlConnection con = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        public SqlDataReader dr;
        public SqlDataAdapter da;
        public DataSet ds=new DataSet();
        public DataTable dt = new DataTable();

        public void CONNECTER()
        {
            if (con.State == ConnectionState.Closed || con.State == ConnectionState.Broken)
            {
                con.ConnectionString = "Data Source=DESKTOP-1NG7LRA;Initial Catalog=DBSTOCK;Integrated Security=True";
                con.Open();
            }

        }
        public void DECONNECTER()
        {
            if (con.State == ConnectionState.Open)
            {

                con.Close();
            }
        }
    }
}
