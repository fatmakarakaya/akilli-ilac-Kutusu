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
    public partial class EczaciSayfasi : Form
    {
        public EczaciSayfasi()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-FC29F2C\\SQLEXPRESS;Initial Catalog=AkilliIlacKutusu;Integrated Security=True");
        SqlDataAdapter da;
        DataSet ds;

        private void btn_hastalar_Click(object sender, EventArgs e)
        {
            HastaListeYukle();
        }

        private void btn_ilaclar_Click(object sender, EventArgs e)
        {
            IlacListeYukle();
        }

        private void HastaListeYukle()
        {
            DataTable dt = new DataTable();
            string sql = "Select * from hastalar";
            da = new SqlDataAdapter(sql, baglan);
            ds = new DataSet();
            baglan.Open();
            da.Fill(ds, "tablo");
            baglan.Close();
            dataGridView1.DataSource = ds.Tables["tablo"];

            baglan.Close();
        }

        private void btn_rct_Click(object sender, EventArgs e)
        {
            ReceteListeYukle();
        }

        private void btn_hstekle_Click(object sender, EventArgs e)
        {
            HastaEkle HastaEkle = new HastaEkle();
            HastaEkle.Show();
        }

        private void btn_rctekle_Click(object sender, EventArgs e)
        {
            ReceteEkle receteEkle = new ReceteEkle();
            receteEkle.Show();
        }

        private void EczaciSayfasi_Load_1(object sender, EventArgs e)
        {

        }

        private void IlacListeYukle()
        {
            DataTable dt = new DataTable();
            string sql = "Select * from Ilac";
            da = new SqlDataAdapter(sql, baglan);
            ds = new DataSet();
            baglan.Open();
            da.Fill(ds, "tablo");
            baglan.Close();
            dataGridView1.DataSource = ds.Tables["tablo"];

            baglan.Close();
        }
        private void ReceteListeYukle()
        {
            DataTable dt = new DataTable();
            string sql = "Select * from Recete";
            da = new SqlDataAdapter(sql, baglan);
            ds = new DataSet();
            baglan.Open();
            da.Fill(ds, "tablo");
            baglan.Close();
            dataGridView1.DataSource = ds.Tables["tablo"];

            baglan.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult giriskapanis = MessageBox.Show("Programı kapatmak istediğinizden eminmisiniz ? ", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (giriskapanis == DialogResult.Yes)
            {
                this.Close();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IlacKutusu ilac = new IlacKutusu();
            ilac.Show();
            
        }
    }
}
