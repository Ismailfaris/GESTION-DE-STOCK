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
        
        public SqlConnection cnx = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        public SqlDataReader dr;
        public SqlDataAdapter da;
        public DataSet ds=new DataSet();
        public DataTable dt = new DataTable();
        public DBCLASS()
        {
            cnx.ConnectionString = "Server=tcp:devm.database.windows.net,1433;Initial Catalog=DBSTOCK;Persist Security Info=False;User ID=su;Password=ism@il123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        }
        public DBCLASS(string cnxString)
        {
            cnx.ConnectionString = cnxString;
        }
        
        public void Open()
        {
            if (cnx.State == ConnectionState.Closed)
            {

                cnx.Open();
            }
        }
        public void Close()
        {
            if (cnx.State == ConnectionState.Open)
            {

                cnx.Close();
            }
        }
        
    }
}
