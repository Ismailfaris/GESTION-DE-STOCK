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
    public partial class FRM_MENU : Form
    {
        public FRM_MENU()
        {
            InitializeComponent();
            panel1.Size = new Size(256, 567);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            if (panel1.Width == 256)
                panel1.Size = new Size(62, 567);
            else
                panel1.Size = new Size(256, 567);
        }

        private void btnclient_Click(object sender, EventArgs e)
        {
            if (!pnlshow.Controls.Contains(USER_LIST_Customer.Instance))
            {
                pnlshow.Controls.Add(USER_LIST_Customer.Instance);
                USER_LIST_Customer.Instance.Dock = DockStyle.Fill;
                USER_LIST_Customer.Instance.BringToFront();
            }
            else
                USER_LIST_Customer.Instance.BringToFront();
            
        }

        private void BtnProduct_Click(object sender, EventArgs e)
        {
            if (!pnlshow.Controls.Contains(USER_LIST_Product.Instance))
            {
                pnlshow.Controls.Add(USER_LIST_Product.Instance);
                USER_LIST_Product.Instance.Dock = DockStyle.Fill;
                USER_LIST_Product.Instance.BringToFront();
            }
            else
                USER_LIST_Product.Instance.BringToFront();
        }

        private void BtnCategory_Click(object sender, EventArgs e)
        {
            if (!pnlshow.Controls.Contains(USER_LIST_Category.Instance))
            {
                pnlshow.Controls.Add(USER_LIST_Category.Instance);
                USER_LIST_Category.Instance.Dock = DockStyle.Fill;
                USER_LIST_Category.Instance.BringToFront();
            }
            else
                USER_LIST_Category.Instance.BringToFront();
        }
    }
}
