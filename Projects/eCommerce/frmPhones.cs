using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace eCommerce
{
    public partial class frmPhones : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=ED-INTERN;Initial Catalog=TEKNOLOGYDB;Integrated Security=True"); //Sql bağlantısı
        string SqlQuery = " ";  //SQL sorgularını yhazmak için oluşturulan değişken...
        
        public frmPhones()
        {
            InitializeComponent();
        }


        #region Yonlendirme Blogu
        private void sefsdgToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShopping frmShop = new frmShopping();
            frmShop.ShowDialog();
        }
        #endregion

        #region Form Özellikleri
        private void PropertyForm()
        {
            dgridAndorid.RowHeadersVisible = false; // Android DataGridView en baştaki boş kolonu gizle
            dgridIos.RowHeadersVisible = false;    // Android DataGridView en baştaki boş kolonu gizle
        }
        #endregion

        #region DataGrid Android Verileri Tabloya Aktar
        private void ShowData()
        {
            connection.Open();
            SqlQuery = "SELECT Marka, Model, Memory, Color, Price, ImagePath FROM TBLTelefon WHERE Category='A'";

             SqlCommand cmd = new SqlCommand(SqlQuery, connection);
            
            using (SqlDataAdapter dAdapter = new SqlDataAdapter(cmd))
            {
                    DataSet dSet = new DataSet();
                    dAdapter.Fill(dSet);

                    dgridAndorid.DataSource = dSet.Tables[0];
                    dgridAndorid.Columns["ImagePath"].Visible = false;// kullanıcılara gözükmez..

            }
             
            connection.Close();
        }



        #endregion

        #region DataGrid Android DoubleClick
        private void dgridAndorid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            liboxAndroid.Items.Clear();

            //Sql'deki Price sütündaki fiyatı listboxa yazar....
            liboxAndroid.Items.Add(dgridAndorid.Rows[e.RowIndex].Cells[0].Value.ToString());
            liboxAndroid.Items.Add(dgridAndorid.Rows[e.RowIndex].Cells[1].Value.ToString());
            liboxAndroid.Items.Add(dgridAndorid.Rows[e.RowIndex].Cells[2].Value.ToString());
            liboxAndroid.Items.Add(dgridAndorid.Rows[e.RowIndex].Cells[3].Value.ToString());

            // Sql'deki Price sütündaki fiyatı textboxa yazar....
            tboxAPrice.Text = dgridAndorid.Rows[e.RowIndex].Cells[4].Value.ToString();

            pBoxAndroid.ImageLocation = dgridAndorid.CurrentRow.Cells[5].Value.ToString();
            pBoxAndroid.SizeMode = PictureBoxSizeMode.StretchImage;

        }



        #endregion

        #region DataGrid Ios Verileri Tabloya Aktar
        private void tabControl1_Click(object sender, EventArgs e)
        {

            connection.Open();
            SqlQuery = "SELECT Marka, Model, Memory, Color, Price , ImagePath FROM TBLTelefon WHERE Category='I'";

            SqlCommand cmd = new SqlCommand(SqlQuery, connection);

            using (SqlDataAdapter dAdapter = new SqlDataAdapter(cmd))
            {
                DataSet dSet = new DataSet();
                dAdapter.Fill(dSet);
                dgridIos.DataSource = dSet.Tables[0];
                dgridIos.Columns["ImagePath"].Visible = false;// kullanıcılara gözükmez..
            }

            connection.Close();

        }
        #endregion

        #region DataGRid Ios DoubleClick
        private void dgridIos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            liboxIos.Items.Clear();

            //Sql'deki Price sütündaki fiyatı listboxa yazar....
            liboxIos.Items.Add(dgridIos.Rows[e.RowIndex].Cells[0].Value.ToString());
            liboxIos.Items.Add(dgridIos.Rows[e.RowIndex].Cells[1].Value.ToString());
            liboxIos.Items.Add(dgridIos.Rows[e.RowIndex].Cells[2].Value.ToString());
            liboxIos.Items.Add(dgridIos.Rows[e.RowIndex].Cells[3].Value.ToString());

            // Sql'deki Price sütündaki fiyatı textboxa yazar....
            tboxIosPrice.Text = dgridIos.Rows[e.RowIndex].Cells[4].Value.ToString();


            pBoxIos.ImageLocation = dgridIos.CurrentRow.Cells[5].Value.ToString();
            pBoxIos.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        #endregion

        #region Form Load
        private void frmPhones_Load(object sender, EventArgs e)
        {
            ShowData();
           
            PropertyForm();
        }
        #endregion

    }
}
