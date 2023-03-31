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
    public partial class frmDelGreen : Form
    {
        string connection = "Data Source=.;Initial Catalog=TEKNOLOGYDB;Integrated Security=True";
        string vs_SQLCommand = "";
        public frmDelGreen()
        {
            InitializeComponent();
        }

        private void frmDelGreen_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connection)) 
            {
                vs_SQLCommand = "SELECT Price FROM TBLESPRESSOMAK ";
                vs_SQLCommand += " WHERE EspID='5' ";

                using(SqlCommand cmd= new SqlCommand(vs_SQLCommand,conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("Price", textBox1.Text);

                    using( SqlDataReader  reader = cmd.ExecuteReader())
                    {
                        if (reader.Read()) 
                        {
                            textBox1.Text = reader["Price"].ToString();
                        }
                    }

                    conn.Close();
                }
            
            
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            //FrmRob frmRob = new FrmRob();
            //frmRob.ShowDialog();
        }
    }
}
