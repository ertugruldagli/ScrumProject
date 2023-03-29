using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eCommerce
{
    public partial class frmPhones : Form
    {
        public frmPhones()
        {
            InitializeComponent();
        }

        private void sefsdgToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShopping frmShop=new frmShopping();
            frmShop.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
