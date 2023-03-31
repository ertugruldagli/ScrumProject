using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace eCommerce
{
    public partial class frms10T : Form
    {
        string constring = "Data Source=.;Initial Catalog=TEKNOLOGYDB;Integrated Security=True";
        string vs_SQLCommand = "";
        public frms10T()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    
        private void frms10T_Load(object sender, EventArgs e)
        {
            using(SqlConnection connection = new SqlConnection(constring))
            {
                vs_SQLCommand = " select Price from TBLROBOT ";
                vs_SQLCommand += " Where RobotID= 'RBT03' ";

                using(SqlCommand cmd =new SqlCommand(vs_SQLCommand, connection))
                {
                    connection.Open();
                    cmd.Parameters.AddWithValue("Price", textBox1.Text);

                    using (SqlDataReader reader = cmd.ExecuteReader())
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
