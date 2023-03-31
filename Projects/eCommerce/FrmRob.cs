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
using System.Diagnostics;
using System.Reflection;

namespace eCommerce
{
    public partial class FrmRob : Form
    {
        //Aşağıdaki değişken Veri Tabanına bağlanabilmek için gerekli olan bağlantıdır. Bu makinada bu database e bağlanmak istiyorum...
        string constring = @"Data Source=.;Initial Catalog=TEKNOLOGYDB;Integrated Security=True"; 
        string vs_SQLCommand = "";
        public FrmRob()
        {
            InitializeComponent();
        }
        private void FrmRob_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(constring)) // SqlConnection ile connectin sınıfımdan con adında nesne oluşturuyorum constring den yararlanarak
            {
                vs_SQLCommand = "select Brand, Model, Price, Color from TBLESPRESSOMAK "; // SQL'den ulaşmak istediğim 
                vs_SQLCommand += "  Where EspID = '2' ";                                  //komutları burada hazrılıyorum.

                using (SqlCommand cmd = new SqlCommand(vs_SQLCommand, con)) //con nesnesini kullanarak SQL komutunu oluşturuyorum.
                {
                    con.Open();
                    //Atamalarımı aşağıdaki komutlar ile gerçekleştiriyorum.
                    cmd.Parameters.AddWithValue("Brand", textBox1.Text); 
                    cmd.Parameters.AddWithValue("Model", textBox1.Text);
                    cmd.Parameters.AddWithValue("Color", textBox1.Text);
                    cmd.Parameters.AddWithValue("Price", textBox2.Text);

                    using (SqlDataReader rd = cmd.ExecuteReader()) //Bir ya da birden fazla satırların sonuç olarak döneceği sorgularda SqlCommand' ın ExecuteReader özelliği kullanılmaktadır. ExecuteReader geriye SqlDataReader tipinde veri döndürmektedir.
                    {
                        if (rd.Read()) //Veriler okunduysa aşağıdaki işlemlerimi gerçekleştiriyor.
                        {
                            textBox1.Text = rd["Brand"].ToString() + rd["Model"].ToString() + rd["Color"].ToString();
                            textBox1.ForeColor = Color.Black;
                            textBox2.Text = rd["Price"].ToString();

                        }
                        con.Close();
                    }

                }

            }
            using (SqlConnection con = new SqlConnection(constring))
            {
                vs_SQLCommand = "select Brand, Model, Price, Color from TBLESPRESSOMAK ";
                vs_SQLCommand += "  Where EspID = '5' ";

                using (SqlCommand cmd = new SqlCommand(vs_SQLCommand, con))
                {
                    con.Open();

                    cmd.Parameters.AddWithValue("Brand", textBox14.Text);
                    cmd.Parameters.AddWithValue("Model", textBox14.Text);
                    cmd.Parameters.AddWithValue("Color", textBox14.Text);
                    cmd.Parameters.AddWithValue("Price", textBox13.Text);

                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        if (rd.Read())
                        {
                            textBox14.Text = rd["Brand"].ToString() + rd["Model"].ToString() + rd["Color"].ToString();
                            textBox13.Text = rd["Price"].ToString();

                        }
                        con.Close();
                    }

                }

            }
            using (SqlConnection con = new SqlConnection(constring))
            {
                vs_SQLCommand = "select Brand, Model, Price, Color from TBLESPRESSOMAK ";
                vs_SQLCommand += "  Where EspID = '3' ";

                using (SqlCommand cmd = new SqlCommand(vs_SQLCommand, con))
                {
                    con.Open();

                    cmd.Parameters.AddWithValue("Brand", textBox12.Text);
                    cmd.Parameters.AddWithValue("Model", textBox12.Text);
                    cmd.Parameters.AddWithValue("Color", textBox12.Text);
                    cmd.Parameters.AddWithValue("Price", textBox11.Text);

                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        if (rd.Read())
                        {
                            textBox12.Text = rd["Brand"].ToString() + rd["Model"].ToString() + rd["Color"].ToString();
                            textBox11.Text = rd["Price"].ToString();

                        }
                        con.Close();
                    }

                }

            }
            using (SqlConnection con = new SqlConnection(constring))
            {
                vs_SQLCommand = "select Brand, Model, Price, Color from TBLESPRESSOMAK ";
                vs_SQLCommand += "  Where EspID = '8' ";

                using (SqlCommand cmd = new SqlCommand(vs_SQLCommand, con))
                {
                    con.Open();

                    cmd.Parameters.AddWithValue("Brand", textBox10.Text);
                    cmd.Parameters.AddWithValue("Model", textBox10.Text);
                    cmd.Parameters.AddWithValue("Color", textBox10.Text);
                    cmd.Parameters.AddWithValue("Price", textBox9.Text);

                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        if (rd.Read())
                        {
                            textBox10.Text = rd["Brand"].ToString() + rd["Model"].ToString() + rd["Color"].ToString();
                            textBox9.Text = rd["Price"].ToString();

                        }
                        con.Close();
                    }

                }

            }
            using (SqlConnection con = new SqlConnection(constring))
            {
                vs_SQLCommand = "select Brand, Model, Price, Color from TBLESPRESSOMAK ";
                vs_SQLCommand += "  Where EspID = '7' ";

                using (SqlCommand cmd = new SqlCommand(vs_SQLCommand, con))
                {
                    con.Open();

                    cmd.Parameters.AddWithValue("Brand", textBox6.Text);
                    cmd.Parameters.AddWithValue("Model", textBox6.Text);
                    cmd.Parameters.AddWithValue("Color", textBox6.Text);
                    cmd.Parameters.AddWithValue("Price", textBox5.Text);

                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        if (rd.Read())
                        {
                            textBox6.Text = rd["Brand"].ToString() + rd["Model"].ToString() + rd["Color"].ToString();
                            textBox5.Text = rd["Price"].ToString();

                        }
                        con.Close();
                    }

                }

            }
            using (SqlConnection con = new SqlConnection(constring))
            {
                vs_SQLCommand = "select Brand, Model, Price, Color from TBLESPRESSOMAK ";
                vs_SQLCommand += "  Where EspID = '1' ";

                using (SqlCommand cmd = new SqlCommand(vs_SQLCommand, con))
                {
                    con.Open();

                    cmd.Parameters.AddWithValue("Brand", textBox8.Text);
                    cmd.Parameters.AddWithValue("Model", textBox8.Text);
                    cmd.Parameters.AddWithValue("Color", textBox8.Text);
                    cmd.Parameters.AddWithValue("Price", textBox7.Text);

                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        if (rd.Read())
                        {
                            textBox8.Text = rd["Brand"].ToString() + rd["Model"].ToString() + rd["Color"].ToString();
                            textBox7.Text = rd["Price"].ToString();

                        }
                        con.Close();
                    }

                }

            }
            using (SqlConnection  con = new SqlConnection(constring))
            {
                vs_SQLCommand = "select Brand, Model, Price, Color from TBLESPRESSOMAK ";
                vs_SQLCommand += " Where EspID = '4' ";

                using (SqlCommand cmd = new SqlCommand(vs_SQLCommand, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("Brand", textBox4.Text);
                    cmd.Parameters.AddWithValue("Model", textBox4.Text);
                    cmd.Parameters.AddWithValue("Color", textBox4.Text);
                    cmd.Parameters.AddWithValue("Price", textBox3.Text);

                    using(SqlDataReader rd = cmd.ExecuteReader())
                    {
                        if (rd.Read())
                        {
                             textBox4.Text = rd["Brand"].ToString() + rd["Model"].ToString() + rd["Color"].ToString();
                            textBox3.Text = rd["Price"].ToString();
                        }
                       
                    }
                    con.Close();
                }
            }
            using (SqlConnection con = new SqlConnection(constring))
            {
                vs_SQLCommand = "select Brand, Model, Price, Color from TBLESPRESSOMAK ";
                vs_SQLCommand += "Where EspID = '6' ";
                
                using(SqlCommand cmd = new SqlCommand(vs_SQLCommand,con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("Brand", textBox16.Text);
                    cmd.Parameters.AddWithValue("Model", textBox16.Text);
                    cmd.Parameters.AddWithValue("Color", textBox16.Text);
                    cmd.Parameters.AddWithValue("Price", textBox15.Text);

                    using(IDataReader rd = cmd.ExecuteReader())
                    {
                        if (rd.Read())
                        {
                            textBox16.Text = rd["Brand"].ToString() + rd["Model"].ToString() + rd["Color"].ToString();
                            textBox15.Text = rd["Price"].ToString();

                        }

                    }
                    con.Close();
                }
            }


           






        }
        // anaformumdan ulaşmak istediğim diğer formalara Aşağıdaki komutlar yardımıyla ulaşmış oluyorum
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmDelGray frmDelGray = new frmDelGray();  
            frmDelGray.ShowDialog();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            frmDelBlue frmDelBlue= new frmDelBlue();
            frmDelBlue.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            frmDelGreen frmDelGreen= new frmDelGreen();
            frmDelGreen.ShowDialog();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }
    }
}
