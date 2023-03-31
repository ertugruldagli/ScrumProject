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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace eCommerce
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        // sql ile veritabanıma bağlanmak için gerekli olan değişkenleri globalda tanımladım..
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        SqlCommand komut;
        DataTable dt;

        //yorum sTIRI

        //sql ile bağlanmak için gerekli olan bağlantı kodlarını
        //griddoldur metotu içerisinde tanımladım..
        void griddoldur()
        {
            //kkkk
            con = new SqlConnection(@"Data Source =LAPTOP-0DLJBOEE\SQLEXPRESS;Initial Catalog=teknoDB;Integrated Security=true");
            da = new SqlDataAdapter("SELECT GTID,GTType,GTMarka,GTModel,GTFiyat,GTImageYol FROM Table_1", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds,"Table_1");
            dataGridView1.DataSource = ds.Tables["Table_1"];
            dataGridView1.Columns["GTImageYol"].Visible = false;
            //veritanındaki Table_1 tablomduki GTImageYol
            //hücresinin datagridde görünümün gizlenmesini sağlayan kod..
            dataGridView1.Columns["GTID"].Visible = false;
            //veritanındaki Table_1 tablomduki GTID
            //hücresinin datagridde görünümün gizlenmesini sağlayan kod..
            con.Close();
        }
        //forma tıklandığında griddoldur metotumu çağırarak sqldeki verilere erişim sağlıyorum..
        private void Form2_Load(object sender, EventArgs e)
        {
            
            dataGridView1.RowHeadersVisible = false;
           //datagridde en baştaki kolunu görmek istemiyorsak..
            griddoldur();
        }

        //cellclick olayında datagirddin herhangi bir hücresine tıklandığında çalışacak komutlar..
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            //Datagridde seçilen ürün verilerini listbox içerisnde göstermek istedim..
            //Datagridden hücre seçildiğinde bilgiler gelecek,başka hücre seçildiğinde
            //ilk seçimdeki hücre bilgileri temizlenmesini istediğim için
            //listboxda ıtemın temizlenmesini sağlayacak kodları yazdım..
            listBox1.Items.Clear();

            //Sql'deki tablomun indexlerinde bulunan bilgilerin listboxta listelecek kodları yazdım
            listBox1.Items.Add(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
            listBox1.Items.Add(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
            listBox1.Items.Add(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
            listBox1.Items.Add(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());

            //Tablomun ürün görselini için tanımladığım indexini çağırıp
            //picturebox da gösterilmesi sağladım..
            pictureBox1.ImageLocation= dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

        }

    }
 
}
