using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GESTION_DE_STOCK
{
    public partial class USER_LIST_CLIENT : UserControl
    {
        private static USER_LIST_CLIENT Userclient;
        public static USER_LIST_CLIENT Instance
        {
            get
            {
                if(Userclient==null)
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

        private void btn_addC_Click(object sender, EventArgs e)
        {
            AddClient AC = new AddClient();
            AC.ShowDialog();
        }
    }
}
