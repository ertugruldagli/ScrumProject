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
    public partial class Shopping : Form
    {
       
        public Shopping()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Login frmLogin=new Login();
            frmLogin.ShowDialog();  

        }

       

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmRob frmRob = new FrmRob();
            frmRob.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmEsp frmEsp = new frmEsp();
            frmEsp.ShowDialog();
        }
    }
}
