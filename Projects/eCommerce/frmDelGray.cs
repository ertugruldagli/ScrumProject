using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eCommerce
{
    public partial class frmDelGray : Form
    {
        string constring = @"Data Source=.;Initial Catalog=TEKNOLOGYDB;Integrated Security=True";
        string vs_SQLCommand = "";
        public frmDelGray()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void frmDelGray_Load(object sender, EventArgs e)
        {
            using(SqlConnection connection = new SqlConnection(constring))
            {
                vs_SQLCommand = " select Price from TBLESPRESSOMAK ";
                vs_SQLCommand += " Where EspID= '2' ";

                using(SqlCommand cmd =  new SqlCommand(vs_SQLCommand, connection))
                {
                    connection.Open();

                    cmd.Parameters.AddWithValue("Price", textBox1.Text);

                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            textBox1.Text = reader["Price"].ToString();
                        }
                    }
                    connection.Close();
                }
            }
        }
    }
}
