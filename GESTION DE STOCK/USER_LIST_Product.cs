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
    public partial class USER_LIST_Product : UserControl
    {
        private static USER_LIST_Product UserProduct;
        public static USER_LIST_Product Instance
        {
            get
            {
                if (UserProduct == null)
                {
                    UserProduct = new USER_LIST_Product();
                }
                return UserProduct;
            }
        }
        public USER_LIST_Product()
        {
            InitializeComponent();
        }

        private void USER_LIST_Product_Load(object sender, EventArgs e)
        {

        }

        private void BtnAddC_Click(object sender, EventArgs e)
        {
            AddProduct AP = new AddProduct();
            AP.ShowDialog();
        }

        private void BtnUpdateP_Click(object sender, EventArgs e)
        {
            UpdateProduct UP = new UpdateProduct();
            UP.ShowDialog();
        }
    }
}
