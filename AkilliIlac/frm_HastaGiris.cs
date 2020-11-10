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
    public partial class frm_HastaGiris : Form
    {
        public frm_HastaGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-FC29F2C\\SQLEXPRESS;Initial Catalog=AkilliIlacKutusu;Integrated Security=True");
       // public static string secilen;
        
        private void btn_HastaGiris_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand command = new SqlCommand("Select HastaId from hastalar where HastaId='" + txt_hastaID.Text + "' AND HastaSifre='" + txt_hasataSifre.Text + "'", baglan);//Veritabanından YoneticiId ve YoneticiId ye ait sifreyi sorgulama.
            SqlDataReader datareader = command.ExecuteReader();
            if (datareader.Read())//Dondurulen degerin "True" olması durumunu kontrol etme.
            {
               
                datareader.Close();
                frm_HastaSayfası hasta = new frm_HastaSayfası();
                hasta.label1.Text = txt_hastaID.Text.ToString();
                hasta.Show();
                this.Hide();
                //secilen=txt_hastaID.Text.ToString();
               
                
            }
            else
                MessageBox.Show("Kullanici Id veya Şifre hatalı !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            baglan.Close();
        }
    }
}
