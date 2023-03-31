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
    public partial class frmEsp : Form
    {
        string constring = @"Data Source=.;Initial Catalog=Proje1;Integrated Security=True";
        string vs_SQLCommand = "";
        public frmEsp()
        {
            InitializeComponent();
        }
        private void frmEsp_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(constring))
            {
                vs_SQLCommand = "SELECT Brand, Model, Price FROM TBL_Robot ";
                vs_SQLCommand += " where RobotID = 'RBT00' ";

                using (SqlCommand cmd = new SqlCommand(vs_SQLCommand, con))
                {
                    con.Open();

                    cmd.Parameters.AddWithValue("Brand", textBox1.Text);
                    cmd.Parameters.AddWithValue("Model", textBox1.Text);
                    cmd.Parameters.AddWithValue("Price", textBox2.Text);

                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        if (rd.Read())
                        {
                            textBox1.Text = rd["Brand"].ToString() + rd["Model"].ToString();
                            textBox2.Text = rd["Price"].ToString();
                        }
                        con.Close();
                    }

                }

            }
            using (SqlConnection con = new SqlConnection(constring))
            {
                vs_SQLCommand = "SELECT Brand, Model, Price FROM TBL_Robot ";
                vs_SQLCommand += " where RobotID = 'RBT01' ";

                using (SqlCommand cmd = new SqlCommand(vs_SQLCommand, con))
                {
                    con.Open();

                    cmd.Parameters.AddWithValue("Brand", textBox20.Text);
                    cmd.Parameters.AddWithValue("Model", textBox20.Text);
                    cmd.Parameters.AddWithValue("Price", textBox19.Text);

                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        if (rd.Read())
                        {
                            textBox20.Text = rd["Brand"].ToString() + rd["Model"].ToString();
                            textBox19.Text = rd["Price"].ToString();

                        }
                        con.Close();
                    }

                }

            }
            using (SqlConnection con = new SqlConnection(constring))
            {
                vs_SQLCommand = "SELECT Brand, Model, Price FROM TBL_Robot ";
                vs_SQLCommand += " where RobotID = 'RBT02' ";

                using (SqlCommand cmd = new SqlCommand(vs_SQLCommand, con))
                {
                    con.Open();

                    cmd.Parameters.AddWithValue("Brand", textBox18.Text);
                    cmd.Parameters.AddWithValue("Model", textBox18.Text);
                    cmd.Parameters.AddWithValue("Price", textBox17.Text);


                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        if (rd.Read())
                        {
                            textBox18.Text = rd["Brand"].ToString() + rd["Model"].ToString();
                            textBox17.Text = rd["Price"].ToString();

                        }
                        con.Close();
                    }

                }

            }
            using (SqlConnection con = new SqlConnection(constring))
            {
                vs_SQLCommand = "SELECT Brand, Model, Price FROM TBL_Robot ";
                vs_SQLCommand += " where RobotID = 'RBT03' ";

                using (SqlCommand cmd = new SqlCommand(vs_SQLCommand, con))
                {
                    con.Open();

                    cmd.Parameters.AddWithValue("Brand", textBox16.Text);
                    cmd.Parameters.AddWithValue("Model", textBox16.Text);
                    cmd.Parameters.AddWithValue("Price", textBox15.Text);


                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        if (rd.Read())
                        {
                            textBox16.Text = rd["Brand"].ToString() + rd["Model"].ToString();
                            textBox15.Text = rd["Price"].ToString();

                        }
                        con.Close();
                    }

                }

            }
            using (SqlConnection con = new SqlConnection(constring))
            {
                vs_SQLCommand = "SELECT Brand, Model, Price FROM TBL_Robot ";
                vs_SQLCommand += " where RobotID = 'RBT04' ";

                using (SqlCommand cmd = new SqlCommand(vs_SQLCommand, con))
                {
                    con.Open();

                    cmd.Parameters.AddWithValue("Brand", textBox4.Text);
                    cmd.Parameters.AddWithValue("Model", textBox4.Text);
                    cmd.Parameters.AddWithValue("Price", textBox3.Text);


                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        if (rd.Read())
                        {
                            textBox4.Text = rd["Brand"].ToString() + rd["Model"].ToString();
                            textBox3.Text = rd["Price"].ToString();

                        }
                        con.Close();
                    }

                }

            }
            using (SqlConnection con = new SqlConnection(constring))
            {
                vs_SQLCommand = "SELECT Brand, Model, Price FROM TBL_Robot ";
                vs_SQLCommand += " where RobotID = 'RBT05' ";

                using (SqlCommand cmd = new SqlCommand(vs_SQLCommand, con))
                {
                    con.Open();

                    cmd.Parameters.AddWithValue("Brand", textBox14.Text);
                    cmd.Parameters.AddWithValue("Model", textBox14.Text);
                    cmd.Parameters.AddWithValue("Price", textBox13.Text);


                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        if (rd.Read())
                        {
                            textBox14.Text = rd["Brand"].ToString() + rd["Model"].ToString();
                            textBox13.Text = rd["Price"].ToString();

                        }
                        con.Close();
                    }

                }

            }
            using (SqlConnection con = new SqlConnection(constring))
            {
                vs_SQLCommand = "SELECT Brand, Model, Price FROM TBL_Robot ";
                vs_SQLCommand += " where RobotID = 'RBT06' ";

                using (SqlCommand cmd = new SqlCommand(vs_SQLCommand, con))
                {
                    con.Open();

                    cmd.Parameters.AddWithValue("Brand", textBox12.Text);
                    cmd.Parameters.AddWithValue("Model", textBox12.Text);
                    cmd.Parameters.AddWithValue("Price", textBox11.Text);

                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        if (rd.Read())
                        {
                            textBox12.Text = rd["Brand"].ToString() + rd["Model"].ToString();
                            textBox11.Text = rd["Price"].ToString();


                        }
                        con.Close();
                    }

                }

            }
            using (SqlConnection con = new SqlConnection(constring))
            {
                vs_SQLCommand = "SELECT Brand, Model, Price FROM TBL_Robot ";
                vs_SQLCommand += " where RobotID = 'RBT07' ";

                using (SqlCommand cmd = new SqlCommand(vs_SQLCommand, con))
                {
                    con.Open();

                    cmd.Parameters.AddWithValue("Brand", textBox10.Text);
                    cmd.Parameters.AddWithValue("Model", textBox10.Text);
                    cmd.Parameters.AddWithValue("Price", textBox9.Text);

                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        if (rd.Read())
                        {
                            textBox10.Text = rd["Brand"].ToString() + rd["Model"].ToString();
                            textBox9.Text = rd["Price"].ToString();


                        }
                        con.Close();
                    }

                }

            }
            using (SqlConnection con = new SqlConnection(constring))
            {
                vs_SQLCommand = "SELECT Brand, Model, Price FROM TBL_Robot ";
                vs_SQLCommand += " where RobotID = 'RBT08' ";

                using (SqlCommand cmd = new SqlCommand(vs_SQLCommand, con))
                {
                    con.Open();

                    cmd.Parameters.AddWithValue("Brand", textBox8.Text);
                    cmd.Parameters.AddWithValue("Model", textBox8.Text);
                    cmd.Parameters.AddWithValue("Price", textBox7.Text);

                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        if (rd.Read())
                        {
                            textBox8.Text = rd["Brand"].ToString() + rd["Model"].ToString();
                            textBox7.Text = rd["Price"].ToString();

                        }
                        con.Close();
                    }

                }

            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Shopping shopping = new Shopping();
            shopping.ShowDialog();
        }        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frm2Pro frm2Pro = new frm2Pro();
            frm2Pro.ShowDialog();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            frmMop2 frmMop20 = new frmMop2();  
            frmMop20.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            frms10T frms10T = new frms10T();
            frms10T.ShowDialog();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
