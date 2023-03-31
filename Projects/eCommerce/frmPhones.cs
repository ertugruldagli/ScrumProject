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

        string SqlQuery = " ";     //SQL sorgularını yazmak için oluşturulan değişken...

        SqlCommand cmd;           //Sql'den veri çekmek için oluşturalan değişken global kısma tanımlandı...
        SqlDataAdapter dAdapter; //Table ve yazılan sorguyu birleştirmak için köprü görevi görür...
        DataSet dSet;           //Oluşurulan verileri data seti içerisine atama yapar.
        
        public frmPhones()
        {
            InitializeComponent();
        }


        #region Yonlendirme Blogu             
        private void sefsdgToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShopping frmShop = new frmShopping();        //formun içinde ilgili forma geçmek için kullanınlan tanımlamadır. Burada geçilen form için nesne oluşturulur.
            frmShop.ShowDialog();                           //oluşturulan nesne(form) gösterilir.
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

            //method oluşturuldu: Veritabından çekilen verilen için gerekli işlemleri sayfa genelinde alt alta yazmak yerine methodlara ayrıldı. Spagetti kod yazımının önüne  geçildi.
        {
            connection.Open();  //Sql connectionu burada çalıştırılır.
            SqlQuery = "SELECT Marka, Model, Memory, Color, Price, ImagePath FROM TBLTelefon WHERE Category='A'"; //istenilen veritabnı sorgusu; globalde tanımlanan değişkene atılır.

            cmd = new SqlCommand(SqlQuery, connection);  //SqlCommand nesnesi, connection ile çağırılarak sql sorgusu çalıştırılır.
            
            using (dAdapter = new SqlDataAdapter(cmd))  // ADapter nesnesi oluşutularak tablo ile sorgu arasında köprü görevi oluşturulur.

            //Using blogunda tanımlanmasının sebebi; Using Sayesinde manuel olarak nesneyi Dispose etmemmize gerek kalmaz.

            //Dispose:IDisposable interface inden türemiş nesneler using(){} bloğu içinde oluşturulursa,using bloğundan çıkılır çıkılmaz GC(Garbage Collector)’ye devredilir ve hemen silinirler(Dispose edilirler).

            //Çünkü IDisposable’den türemiş classlarda %100 Dispose metodu vardır.
            {
                dSet = new DataSet();               // Veri kümesi nesnesi oluşturuldu
                    dAdapter.Fill(dSet);                //oluşturulan nesne, köprü ile birleştirildi

                    dgridAndorid.DataSource = dSet.Tables[0]; // birleşim sonrası tablo içine dolduruldu.
                    dgridAndorid.Columns["ImagePath"].Visible = false;// tablodaki istenilen kolon kullanıcılara gözükmez..

            }
             
            connection.Close(); //Sql connection kapatıldı
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

            // Sql'deki resim yolunu sütündaki pictureboxta gösterilir...
            pBoxAndroid.ImageLocation = dgridAndorid.CurrentRow.Cells[5].Value.ToString();
            pBoxAndroid.SizeMode = PictureBoxSizeMode.StretchImage;

        }



        #endregion

        #region DataGrid Ios Verileri Tabloya Aktar
        private void tabControl1_Click(object sender, EventArgs e)
        {
            //tabControl1_Click event methodu: tabControl'e tıklama işlemi gerçekleştiğinde aşağıdaki işlemleri yerine getir.

            connection.Open();
            SqlQuery = "SELECT Marka, Model, Memory, Color, Price , ImagePath FROM TBLTelefon WHERE Category='I'";

             cmd = new SqlCommand(SqlQuery, connection);

            using ( dAdapter = new SqlDataAdapter(cmd))
            {
                dSet = new DataSet();
                dAdapter.Fill(dSet);
                dgridIos.DataSource = dSet.Tables[0];
                dgridIos.Columns["ImagePath"].Visible = false;// kullanıcılara gözükmez..
            }

            connection.Close();

        }
        #endregion

        #region DataGRid Ios DoubleClick
        private void dgridIos_CellContentClick(object sender, DataGridViewCellEventArgs e)    

            //CellContenctClik event methodu: datagrid'e tıklama işlemi gerçekleştiğinde aşağıdaki işlemleri yerine getir.
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

        //Form çalıştırıldığında form ile çalışacak methodlar..
        private void frmPhones_Load(object sender, EventArgs e)
        {
            ShowData(); 
           
            PropertyForm();
        }
        #endregion

    }
}
