using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eCommerce
{
    public partial class frmPhones : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=ED-INTERN;Initial Catalog=TEKNOLOGYDB;Integrated Security=True");
        string SqlQuery = " ";
        public frmPhones()
        {
            InitializeComponent();
        }

        private void sefsdgToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShopping frmShop=new frmShopping();
            frmShop.ShowDialog();
        }

        private void PropertyForm()
        {
            dgridAndorid.RowHeadersVisible = false; //Eğer gd nin en baş tarafındaki kolunu görmmek istemiyorsak
        }

        private void ShowData()
        {
            SqlQuery = "SELECT Marka, Model, Memory, Color, Price FROM TBLTelefon WHERE Category='A' ";
            
            using (connection)
            {
               SqlCommand cmd =new SqlCommand(SqlQuery,connection);

                using (SqlDataAdapter dAdapter = new SqlDataAdapter(cmd))
                {
                    DataSet dSet = new DataSet(); 
                    dAdapter.Fill(dSet);

                    dgridAndorid.DataSource = dSet.Tables[0];
                }
            }
             
        }

        

        private void frmPhones_Load(object sender, EventArgs e)
        {
            ShowData();
            PropertyForm();
        }

        private void dgridAndorid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            liboxAndroid.Items.Clear();

            //liboxAndroid.Items.Add(
            //  dgridAndorid.Rows[e.RowIndex].Cells[0].Value.ToString() +
            //  dgridAndorid.Rows[e.RowIndex].Cells[1].Value.ToString() +
            //  dgridAndorid.Rows[e.RowIndex].Cells[2].Value.ToString() +
            //  dgridAndorid.Rows[e.RowIndex].Cells[3].Value.ToString()

            // );
            liboxAndroid.Items.Add(dgridAndorid.Rows[e.RowIndex].Cells[0].Value.ToString());
            liboxAndroid.Items.Add(dgridAndorid.Rows[e.RowIndex].Cells[1].Value.ToString());
            liboxAndroid.Items.Add(dgridAndorid.Rows[e.RowIndex].Cells[2].Value.ToString());
            liboxAndroid.Items.Add(dgridAndorid.Rows[e.RowIndex].Cells[3].Value.ToString());



            tboxAPrice.Text = dgridAndorid.Rows[e.RowIndex].Cells[4].ToString();


            

            pBoxAndroid.Image = Image.FromFile("C:\\UCC08\\Projects\\ScrumProject\\Projects\\eCommerce\\Resources\\indir.jpeg");
            pBoxAndroid.SizeMode = PictureBoxSizeMode.StretchImage;
        }



    }
}
