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

namespace AkilliIlac
{
    public partial class frm_HastaSayfası : Form
    {
        public frm_HastaSayfası()
        {
            InitializeComponent();
        }
       
        public string KullaniciId;
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-FC29F2C\\SQLEXPRESS;Initial Catalog=AkilliIlacKutusu;Integrated Security=True");
        SqlDataAdapter da;
        DataSet ds;
        
        private void frm_HastaSayfası_Load(object sender, EventArgs e)
        {
            //string s = frm_HastaGiris.secilen;
            //  baglan.Open();

            KullaniciId = label1.Text.ToString();

        }

        private void HastaListeYukle()
        {
            //SqlCommand command = new SqlCommand("select *from hastalar where HastaId='" + KullaniciId + "'", baglan);
            DataTable dt = new DataTable();
            string sql = "Select * from hastalar where HastaId='"+ KullaniciId + "'";
            
            da = new SqlDataAdapter(sql, baglan);
            ds = new DataSet();
            baglan.Open();
            da.Fill(ds, "tablo");
            baglan.Close();
            dataGridView1.DataSource = ds.Tables["tablo"];

            baglan.Close();
        }
        private void ReceteListesiYukle()
        {
            //SqlCommand command = new SqlCommand("select *from hastalar where HastaId='" + KullaniciId + "'", baglan);
            DataTable dt = new DataTable();
            string sql = "Select * from Recete where HastaId='" + KullaniciId + "'";

            da = new SqlDataAdapter(sql, baglan);
            ds = new DataSet();
            baglan.Open();
            da.Fill(ds, "tablo");
            baglan.Close();
            dataGridView1.DataSource = ds.Tables["tablo"];

            baglan.Close();
        }
        private void btn_bilgiler_Click(object sender, EventArgs e)
        {
            HastaListeYukle();
        }

        private void btn_rct_Click(object sender, EventArgs e)
        {
            ReceteListesiYukle();
        }
    }
}
