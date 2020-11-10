using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace AkilliIlac
{
    public partial class IlacKutusu : Form
    {
        public IlacKutusu()
        {
            InitializeComponent();
        }
       
       
        private void btn_kur_Click(object sender, EventArgs e)
        {
            numericUpDown1.Enabled = false;//Saati pasifleştiriyoruz.
            numericUpDown2.Enabled = false;//Dakikayı pasifleştiriyoruz.
            numericUpDown3.Enabled = false;//Saati pasifleştiriyoruz.
            numericUpDown4.Enabled = false;//Dakikayı pasifleştiriyoruz.
            numericUpDown5.Enabled = false;//Saati pasifleştiriyoruz.
            numericUpDown6.Enabled = false;//Dakikayı pasifleştiriyoruz.

        }

        private void IlacKutusu_Load(object sender, EventArgs e)
        {
            timer1.Start();
            
           
        }

    
        private void timer1_Tick(object sender, EventArgs e)
        {
            //int sayi;
            //sayi = Convert.ToInt32(textBox1.Text);
            
            label3.Text = DateTime.Now.ToShortTimeString();
            btn_kur.Enabled = true;

            if(textBox1.Text == "1")
            {
                if (numericUpDown1.Value == DateTime.Now.Hour && numericUpDown2.Value == DateTime.Now.Minute)
                {
                    numericUpDown3.Enabled = false;//Saati pasifleştiriyoruz.
                    numericUpDown4.Enabled = false;//Dakikayı pasifleştiriyoruz.
                    numericUpDown5.Enabled = false;//Saati pasifleştiriyoruz.
                    numericUpDown6.Enabled = false;//Dakikayı pasifleştiriyoruz.
                    timer1.Stop();
                    SoundPlayer player = new SoundPlayer();//Yeni bir soundplayer oluşturuyoruz
                    string sarkiYol = Application.StartupPath + "/alarm.wav";

                    player.SoundLocation = sarkiYol;
                    player.Play();
                }
            }
            else if (textBox1.Text == "2")
            {
                if (numericUpDown1.Value == DateTime.Now.Hour && numericUpDown2.Value == DateTime.Now.Minute && numericUpDown3.Value == DateTime.Now.Hour && numericUpDown4.Value == DateTime.Now.Minute)
                {
                   
                    numericUpDown5.Enabled = false;//Saati pasifleştiriyoruz.
                    numericUpDown6.Enabled = false;//Dakikayı pasifleştiriyoruz.
                    timer1.Stop();
                    SoundPlayer player = new SoundPlayer();//Yeni bir soundplayer oluşturuyoruz
                    string sarkiYol = Application.StartupPath + "/alarm.wav";

                    player.SoundLocation = sarkiYol;
                    player.Play();
                }
            }
            else if (textBox1.Text == "3")
            {
                if (numericUpDown1.Value == DateTime.Now.Hour && numericUpDown2.Value == DateTime.Now.Minute && numericUpDown3.Value == DateTime.Now.Hour && numericUpDown4.Value == DateTime.Now.Minute && numericUpDown5.Value == DateTime.Now.Hour && numericUpDown6.Value == DateTime.Now.Minute)
                {
                    timer1.Stop();
                    SoundPlayer player = new SoundPlayer();//Yeni bir soundplayer oluşturuyoruz
                    string sarkiYol = Application.StartupPath + "/alarm.wav";

                    player.SoundLocation = sarkiYol;
                    player.Play();
                }
            }

        }
    }
}
