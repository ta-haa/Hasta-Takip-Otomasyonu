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
    public partial class kayit : Form
    {
        public kayit()
        {
            InitializeComponent();
        }

        private void kayitol_Click(object sender, EventArgs e)
        {
            /*
            try
            { 
                    sqlbaglanticlass.baglan.Open();
                    SqlCommand uyeol = new SqlCommand("insert into kullanici(ad,soyad,eposta,telefon,sifre) values (@ad,@soyad,@eposta,@telefon,@sifre)", sqlbaglanticlass.baglan);
                    uyeol.Parameters.AddWithValue("@eposta", txtKeposta.Text);
                    uyeol.Parameters.AddWithValue("@sifre", txtKsifre.Text);
                    uyeol.ExecuteNonQuery();
                    txtKeposta.ResetText();
                    txtKsifre.ResetText();
                    sqlbaglanticlass.baglan.Close();

                    giris panel = new giris();
                    panel.Show();
                 
            }

            catch (Exception)
            {
                MessageBox.Show("Beklenmedik Bir Hatayla Karşılaşıldı Lütfen Daha Sonra Tekrar Deneyiniz...", "!! Hata !!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                Close();
            }
            */
        }
         
       

        private void kayit_Load_1(object sender, EventArgs e)
        {
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

        private void kayitol_Click_1(object sender, EventArgs e)
        {
            baglan.baglanti.Open();
            SqlCommand kod = new SqlCommand("insert into admin(eposta,sifre) values (@eposta,@sifre)", baglan.baglanti);
             
            kod.Parameters.AddWithValue("@eposta", txtKeposta.Text);
            kod.Parameters.AddWithValue("@sifre", txtKsifre.Text); 

            kod.ExecuteNonQuery();
            MessageBox.Show("Doktor Eklendi");  
            baglan.baglanti.Close();
        }
    }
}
