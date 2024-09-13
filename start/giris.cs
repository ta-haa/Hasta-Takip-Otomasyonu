using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace start
{
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }

        int sayac = 10;
        private void giris_Load(object sender, EventArgs e)
        { 
            lblzaman.Text = "10";
            zaman.Start();
            zaman.Interval = 1000; 



            Rectangle gradient_rectangle = new Rectangle(0, 0, Width, Height);
            Brush brush = new LinearGradientBrush(gradient_rectangle, Color.Cyan, Color.White, 45f);
            Graphics.ReferenceEquals(brush, gradient_rectangle);
            this.Paint += new PaintEventHandler(set_background);
        }
         
        private void set_background(Object sender, PaintEventArgs e)
        {

            Graphics graphics = e.Graphics;
            Rectangle gradient_rectangle = new Rectangle(0, 0, Width, Height);
            Brush b = new LinearGradientBrush(gradient_rectangle, Color.FromArgb(0, 0, 0), Color.FromArgb(0, 192, 192), 65f);
            graphics.FillRectangle(b, gradient_rectangle);

        }

        private void zaman_Tick(object sender, EventArgs e)
        {
                sayac--;
                lblzaman.Text = sayac.ToString(); 

                if (sayac == 0)
                {
                    sayac = 10;
                    string[] BuyukHarfler = { "A", "B", "C", "Ç", "D", "E", "F", "G", "Ğ", "H", "I", "İ", "J", "K", "L", "M", "N", "O", "Ö", "P", "R", "S", "Ş", "T", "U", "Ü", "V", "Y", "Z" };
                    string[] KucukHarfler = { "a", "b", "c", "ç", "d", "e", "f", "g", "ğ", "h", "ı", "i", "j", "k", "l", "m", "n", "o", "ö", "p", "r", "s", "ş", "t", "u", "ü", "v", "y", "z" };
                    string[] Semboller = { "+", "-", "/", "*", "!", "#", "$", "%", "½", "{", "[", "/", "(", ")", "]", "=", "}", "?", "<", ">", "|", "@", "~", "¨", "æ", "ß", ",", ";", ":", "." };


                    Random rnd = new Random();

                    int sembol1, sembol2, sembol3, sembol4;

                    sembol1 = rnd.Next(0, BuyukHarfler.Length);
                    sembol2 = rnd.Next(0, 10);
                    sembol3 = rnd.Next(0, KucukHarfler.Length);
                    sembol4 = rnd.Next(0, Semboller.Length);

                    lblcaptcha.Text = BuyukHarfler[sembol1] + sembol2.ToString() + KucukHarfler[sembol3] + Semboller[sembol4];
                 

                } 
        }

        private void btnkayit_Click(object sender, EventArgs e)
        {
            try
            {
                string yazi1 = lblcaptcha.Text;
                string yazi2 = txtcaptcha.Text;
                if (yazi1 != yazi2)
                {
                    MessageBox.Show("Captcha Hatalı");
                    Close();
                }
                else
                {
                    baglan.baglanti.Open();
                    SqlCommand uyegiris = new SqlCommand("select * from Admin where eposta=@eposta and sifre=@sifre", baglan.baglanti);
                    uyegiris.Parameters.AddWithValue("@eposta", txteposta.Text);
                    uyegiris.Parameters.AddWithValue("@sifre", txtsifre.Text);

                    SqlDataAdapter da = new SqlDataAdapter(uyegiris);


                    DataTable tablo = new DataTable();
                    da.Fill(tablo);
                    if (tablo.Rows.Count > 0)
                    {
                        MessageBox.Show("Hoşgeldiniz " + txteposta.Text);
                    }
                    else
                    {
                        MessageBox.Show("Eposta veya Şifre Hatalı");
                    }
                    baglan.baglanti.Close();
                } 
                  
            }
            catch (Exception)
            {
                MessageBox.Show("Beklenmedik Bir Hatayla Karşılaşıldı Lütfen Daha Sonra Tekrar Deneyiniz...", "!! Hata !!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                Close();
            }
            
        }
    }
}
