using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp19
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        List<int> sayilar = new List<int>();
        List<int> siraliSayilar = new List<int>();
        List<Label> sayiEtiketleri = new List<Label>();
        int kalanSure;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timerHareket.Interval = 1000;
            timer1.Tick += timer1_Tick;
            btnBitir.Enabled = false;
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            OyunuBaslat(); 
        }

        private void OyunuBaslat()
        {
            pnlOyunAlani.Controls.Clear();  
            lstDogruSira.Items.Clear();  
            sayilar.Clear(); 
            siraliSayilar.Clear(); 
            sayiEtiketleri.Clear();  
            kalanSure = 60;  
            lblSure.Text = $"SÜRE\n{kalanSure} sn";  

            while (sayilar.Count < 10)
            {
                int rastgeleSayi = random.Next(1, 101); 
                if (!sayilar.Contains(rastgeleSayi))  
                {
                    sayilar.Add(rastgeleSayi);
                }
            }

            foreach (int sayi in sayilar)
            {
                Label lblSayi = new Label();
                lblSayi.Text = sayi.ToString();
                lblSayi.Font = new Font("Arial", 12, FontStyle.Bold);
                lblSayi.AutoSize = false;
                lblSayi.Size = new Size(50, 50);  
                lblSayi.TextAlign = ContentAlignment.MiddleCenter;
                lblSayi.BorderStyle = BorderStyle.FixedSingle;
                lblSayi.Cursor = Cursors.Hand;

                int x = random.Next(0, pnlOyunAlani.Width - lblSayi.Width); 
                int y = random.Next(0, pnlOyunAlani.Height - lblSayi.Height);
                lblSayi.Location = new Point(x, y);

                lblSayi.Click += LblSayi_Click;  

                pnlOyunAlani.Controls.Add(lblSayi); 
                sayiEtiketleri.Add(lblSayi); 
            }


            btnBasla.Enabled = false;
            btnBitir.Enabled = true;
            timer1.Start();  


            timerHareket.Start();
        }

        private void LblSayi_Click(object sender, EventArgs e)
        {
            Label tiklananLabel = (Label)sender;
            int tiklananSayi = Convert.ToInt32(tiklananLabel.Text);

            if (tiklananSayi % 2 == 0)
            {
                lstDogruSira.Items.Add(tiklananSayi);
                var sortedList = lstDogruSira.Items.Cast<int>().Where(x => x % 2 == 0).OrderBy(x => x).ToList();

                lstDogruSira.Items.Clear();
                foreach (var item in sortedList)
                {
                    lstDogruSira.Items.Add(item);
                }
            }

            if (lstDogruSira.Items.Count == sayilar.Count(sayi => sayi % 2 == 0))
            {
                OyunBitti(true); 
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            kalanSure--; 
            lblSure.Text = $"SÜRE\n{kalanSure} sn";  

            if (kalanSure <= 0)
            {
                OyunBitti(false);
            }
        }

        private void timerHareket_Tick(object sender, EventArgs e)
        {
            foreach (Label lblSayi in sayiEtiketleri)
            {
                int newX = random.Next(0, pnlOyunAlani.Width - lblSayi.Width);
                int newY = random.Next(0, pnlOyunAlani.Height - lblSayi.Height);
                lblSayi.Location = new Point(newX, newY);
            }
        }

        private void btnBitir_Click(object sender, EventArgs e)
        {
            OyunBitti(false, true); 
        }

        private void OyunBitti(bool kazandiMi, bool oyuncuBitirdi = false)
        {
            timer1.Stop(); 
            timerHareket.Stop(); 

            if (kazandiMi)
            {
                MessageBox.Show($"{kalanSure} saniye kala oyunu bitirdin", "tebrikler", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (oyuncuBitirdi)
            {
                MessageBox.Show("oyunu bitirdiniz.", "oyun bitti", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("süre doldu oyunu kaybettin", "oyun bitti", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            pnlOyunAlani.Controls.Clear();
            lstDogruSira.Items.Clear();
            btnBasla.Enabled = true;
            btnBitir.Enabled = false;
            lblSure.Text = "SÜRE";
        }
    }
}
