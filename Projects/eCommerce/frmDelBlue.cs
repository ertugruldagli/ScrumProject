using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace eCommerce
{
    public partial class frmDelBlue : Form
    {
        string connection = "Data Source=.;Initial Catalog=TEKNOLOGYDB;Integrated Security=True";
        string vs_SQLCommand = "";


        public frmDelBlue()
        {
            InitializeComponent();
        }

        private void frmDelBlue_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connection);

            vs_SQLCommand = " select Price from TBLESPRESSOMAK ";
            vs_SQLCommand += " where EspID = '5' ";

            SqlCommand cmd = new SqlCommand(vs_SQLCommand, conn);
            
            conn.Open();

            cmd.Parameters.AddWithValue("Price", textBox1.Text);

            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                if (dr.Read())
                {
                    textBox1.Text = dr["Price"].ToString();
                } 
                            
            }
           
            conn.Close();

            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
