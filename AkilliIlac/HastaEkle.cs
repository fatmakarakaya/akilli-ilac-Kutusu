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
    public partial class HastaEkle : Form
    {
        public HastaEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-FC29F2C\\SQLEXPRESS;Initial Catalog=AkilliIlacKutusu;Integrated Security=True");
        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                    baglan.Open();
                // Bağlantımızı kontrol ediyoruz, eğer kapalıysa açıyoruz.
                string kayit = "insert into hastalar(HastaId,Adi,Soyadi,Cinsiyet,Yas,Mail,Telefon,EczaciId,HastaSifre) values (@tcno,@isim,@soyisim,@cinsiyet,@yas,@mail,@telefon,@EczaciId,@HastaSifre)";
              
                SqlCommand komut = new SqlCommand(kayit, baglan);
                //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
                komut.Parameters.AddWithValue("@tcno", txt_tc.Text.ToString());
                komut.Parameters.AddWithValue("@isim", txt_adi.Text.ToString());
                komut.Parameters.AddWithValue("@soyisim", txt_soyad.Text.ToString());
                komut.Parameters.AddWithValue("@cinsiyet", cmb_cinsiyet.Text.ToString());
                komut.Parameters.AddWithValue("@yas", txt_yas.Text.ToString());
                komut.Parameters.AddWithValue("@mail", txt_mail.Text.ToString());
                komut.Parameters.AddWithValue("@telefon", txt_telefon.Text.ToString());
                komut.Parameters.AddWithValue("@EczaciId", "123");
                komut.Parameters.AddWithValue("@HastaSifre", txt_sifre.Text.ToString());
                //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
                komut.ExecuteNonQuery();
                //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
                baglan.Close();
                MessageBox.Show("Hasta Kayıt İşlemi Gerçekleşti.");
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }
        }

        private void HastaEkle_Load(object sender, EventArgs e)
        {

        }

        private void btn_cık_Click(object sender, EventArgs e)
        {
            DialogResult giriskapanis = MessageBox.Show("Programı kapatmak istediğinizden eminmisiniz ? ", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (giriskapanis == DialogResult.Yes)
            {
                this.Close();

            }
        }
    }
}
