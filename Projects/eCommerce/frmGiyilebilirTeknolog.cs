using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting.Contexts;
using System.Reflection.Emit;

namespace eCommerce
{
    public partial class frmGiyilebilirTeknolog : Form
    {
        const string constring = @"Data Source =LAPTOP-0DLJBOEE\SQLEXPRESS;Initial Catalog=teknoDB;Integrated Security=True";
        SqlConnection connection = new SqlConnection(constring);
        string sqlQuery = "";
        public frmGiyilebilirTeknolog()
        {
            InitializeComponent();
        }


        private void FiyatCekme(string Type)
        {
            connection.Open();
            sqlQuery = $"SELECT BileklikFiyat FROM TBLable1AKILLIBILEKLIK where GTType='{Type}'";
           
            SqlCommand cmd = new SqlCommand(sqlQuery,connection);
            
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
               
                lbl01.Text = dr["BileklikFiyat"].ToString();

            }
           

            connection.Close();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            label3.Visible = true;
            lbl01.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            label7.Visible = false;
            label8.Visible= false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            label3.Visible = false;
            lbl01.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
        }
        private void button3_Click(object sender, EventArgs e)
        {

            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            label3.Visible = false;
            lbl01.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;

        }

        private void frmGiyilebilirTeknolog_Load(object sender, EventArgs e)
        {
            FiyatCekme("B");
        }
    }
}
