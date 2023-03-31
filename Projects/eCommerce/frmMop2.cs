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
    public partial class frmMop2 : Form
    {
        string constring = "Data Source=.;Initial Catalog=TEKNOLOGYDB;Integrated Security=True";
        string vs_SQLCommand = "";
        public frmMop2()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();    
        }

        private void frmMop2_Load(object sender, EventArgs e)
        {
            using(SqlConnection conn = new SqlConnection(constring))
            {
                vs_SQLCommand = " select Price from TBLROBOT ";
                vs_SQLCommand += " Where RobotID= 'RBT01' ";

                using (SqlCommand cmd = new SqlCommand(vs_SQLCommand,conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("Price", textBox1.Text);

                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            textBox1.Text= reader["Price"].ToString();

                        }
                    }

                    conn.Close();
                }
            }
        }
    }
}
