using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerUygulama
{
    public partial class Form1 : Form
    {
        bool GeriSayim = false;

        int saat = 0;
        int dakika = 0;
        int saniye = 0;
        int salise = 0;

        int gercekSaat = DateTime.Now.Hour;
        int gercekDakika = DateTime.Now.Minute;
        int gercekSaniye = DateTime.Now.Second;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbgSaat.Text = string.Empty;
            lbgDakika.Text = string.Empty;
            lbgSaniye.Text = string.Empty;
            lbgSalise.Text = string.Empty;

            lbSaat.Text = saat.ToString();
            lbDakika.Text = dakika.ToString();
            lbSaniye.Text = saniye.ToString();
            lbSalise.Text = salise.ToString();

            timer1.Interval = 10;
            timer1.Start();
            btnBasla.Enabled = false;
            
            if(btnBasla.BackColor == Color.Green)
            {
                Environment.Exit(0);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(!GeriSayim)
            {
                salise++;
                if(salise == 100)
                {
                    saniye++;
                    salise = 0;
                }
                if(saniye == 60)
                {
                    dakika++;
                    saniye = 0;
                }
                if(dakika == 60)
                {
                    saat++;
                    dakika = 0;
                }

                lbSaat.Text = saat.ToString();
                lbDakika.Text = dakika.ToString();
                lbSaniye.Text = saniye.ToString();
                lbSalise.Text = salise.ToString();
            }

            else
            {
                lbSalise.Text = string.Empty;
                lbSaniye.Text = string.Empty;
                lbDakika.Text = string.Empty;
                lbSaat.Text = string.Empty;

                btnBasla.Enabled = true;
                btnBasla.BackColor = Color.Green;

                lbgSalise.Text = salise.ToString();
                lbgSaniye.Text = saniye.ToString();
                lbgDakika.Text = dakika.ToString();
                lbgSaat.Text = saat.ToString();

                salise--;
                if(salise < 0)
                {
                    salise = 99;
                    saniye--;
                }
                if(saniye < 0 )
                {
                    saniye = 59;
                    dakika--;
                }
                if(dakika  < 0 )
                {
                    dakika = 59;
                    saat--;
                }
            }

            if(saat == gercekSaat && dakika == gercekDakika && saniye == gercekSaniye && !GeriSayim)
            {
                timer1.Stop();
                GeriSayim = true;
                btnBasla.Enabled = true;
            }
        }
    }
}
