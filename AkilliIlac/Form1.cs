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
    public partial class frm_giris : Form
    {
        public frm_giris()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-FC29F2C\\SQLEXPRESS;Initial Catalog=AkilliIlacKutusu;Integrated Security=True");

        private void btn_EczGiris_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand command = new SqlCommand("Select *from Eczaci where EczaciId='" + txt_EczaciId.Text + "' AND EczaciSifre='" + txt_Eczacısifre.Text + "'", baglan);//Veritabanından YoneticiId ve YoneticiId ye ait sifreyi sorgulama.
            SqlDataReader datareader = command.ExecuteReader();
            if (datareader.Read())//Dondurulen degerin "True" olması durumunu kontrol etme.
            {
                datareader.Close();
                EczaciSayfasi EczaciSayfasi = new EczaciSayfasi();
                EczaciSayfasi.Show();
                //this.Hide();
            }
            else
                MessageBox.Show("Kullanici Id veya Şifre hatalı !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            baglan.Close();
        }

        private void lbl_kullanıcıgiriş_Click(object sender, EventArgs e)
        {
            frm_HastaGiris hastaSayfasi = new frm_HastaGiris();
            hastaSayfasi.Show();
            this.Hide();
        }
    }
}
