﻿using System;
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
    public partial class frmShopping : Form
    {
        public frmShopping()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin=new frmLogin();
            frmLogin.ShowDialog();  

        }

        private void telefonlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhones frmPhones = new frmPhones();
            frmPhones.ShowDialog();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            frmPhones frmPicturePhonrd= new frmPhones();    
            frmPicturePhonrd.ShowDialog();
        }
    }
}
