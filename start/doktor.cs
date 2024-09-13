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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace start
{
    public partial class doktor : Form
    {
        public doktor()
        {
            InitializeComponent();
        }

        private void doktor_Load(object sender, EventArgs e)
        {

            Rectangle gradient_rectangle = new Rectangle(0, 0, Width, Height);
            Brush brush = new LinearGradientBrush(gradient_rectangle, Color.Cyan, Color.White, 45f);
            Graphics.ReferenceEquals(brush, gradient_rectangle);
            this.Paint += new PaintEventHandler(set_background);

            baglan.baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from doktor ", baglan.baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dtgrwdoktor.DataSource = dt;
            baglan.baglanti.Close();
        }
        private void set_background(Object sender, PaintEventArgs e)
        {

            Graphics graphics = e.Graphics;
            Rectangle gradient_rectangle = new Rectangle(0, 0, Width, Height);
            Brush b = new LinearGradientBrush(gradient_rectangle, Color.FromArgb(0, 0, 0), Color.FromArgb(0, 192, 192), 65f);
            graphics.FillRectangle(b, gradient_rectangle);

        }

        private void btnekle_Click(object sender, EventArgs e)
        { 
            DateTime dktrdogumtarihi = doktordogumtarihi.Value;
            DateTime dktrkayittarihi = doktorkayittarihi.Value; 


            baglan.baglanti.Open();
            SqlCommand kod = new SqlCommand("insert into doktor(doktorfotograf,doktortc,doktorad,doktorsoyad,doktordogumtarihi,doktortelefon,doktorbransi,doktorkayittarihi) values (@doktorfotograf,@doktortc,@doktorad,@doktorsoyad,@doktordogumtarihi,@doktortelefon,@doktorbransi,@doktorkayittarihi)", baglan.baglanti);
            kod.Parameters.AddWithValue("@doktorfotograf", openFileDialog1.FileName);
            kod.Parameters.AddWithValue("@doktortc", txtdoktortc.Text);
            kod.Parameters.AddWithValue("@doktorad", txtdoktorad.Text);
            kod.Parameters.AddWithValue("@doktorsoyad", txtdoktorsoyad.Text);
            kod.Parameters.AddWithValue("@doktordogumtarihi", dktrdogumtarihi);
            kod.Parameters.AddWithValue("@doktortelefon", txtdoktortelefon.Text);
            kod.Parameters.AddWithValue("@doktorbransi", txtdoktorbransi.Text);
            kod.Parameters.AddWithValue("@doktorkayittarihi", dktrkayittarihi); 

            kod.ExecuteNonQuery();
            MessageBox.Show("Doktor Eklendi");

            SqlCommand komut = new SqlCommand("select * from doktor ", baglan.baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dtgrwdoktor.DataSource = dt;

            baglan.baglanti.Close();
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            pictureBox1.Load(dtgrwdoktor.CurrentRow.Cells[1].Value.ToString());

            txtdoktorid.Text = dtgrwdoktor.CurrentRow.Cells[0].Value.ToString();
            txtdoktortc.Text = dtgrwdoktor.CurrentRow.Cells[2].Value.ToString();
            txtdoktorad.Text = dtgrwdoktor.CurrentRow.Cells[3].Value.ToString();
            txtdoktorsoyad.Text = dtgrwdoktor.CurrentRow.Cells[4].Value.ToString();
            doktordogumtarihi.Text = dtgrwdoktor.CurrentRow.Cells[5].Value.ToString();
            txtdoktortelefon.Text = dtgrwdoktor.CurrentRow.Cells[6].Value.ToString();
            txtdoktorbransi.Text = dtgrwdoktor.CurrentRow.Cells[7].Value.ToString();
            doktorkayittarihi.Text = dtgrwdoktor.CurrentRow.Cells[8].Value.ToString();

            if (dtgrwdoktor.CurrentCell != null)
            {
                txtdoktorid.Text = dtgrwdoktor.CurrentRow.Cells[0].Value.ToString();
            }
            else
            {
                MessageBox.Show("Doktor Yok"); 
            }


            baglan.baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from doktor ", baglan.baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dtgrwdoktor.DataSource = dt;
            baglan.baglanti.Close();
        }

        private void txtara_Click(object sender, EventArgs e)
        {
            try
            {
                string arama = txtdoktorara.Text;
                baglan.baglanti.Open();
                SqlCommand ara = new SqlCommand("select * from doktor where doktorad like'%" + arama + "%'", baglan.baglanti);
                SqlDataReader dr = ara.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dtgrwdoktor.DataSource = dt;
                baglan.baglanti.Close();
            }

            catch (Exception)
            {
                MessageBox.Show("Beklenmedik Bir Hatayla Karşılaşıldı Lütfen Daha Sonra Tekrar Deneyiniz...", "!! Hata !!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                Close();
            }
        }

        private void txtdoktortc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtdoktortelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            try
            {
                baglan.baglanti.Open();
                SqlCommand sifreguncelle = new SqlCommand("update doktor set doktortc=@doktortc, doktorad=@doktorad, doktorsoyad=@doktorsoyad,doktordogumtarihi=@doktordogumtarihi,doktortelefon=@doktortelefon,doktorbransi=@doktorbransi,doktorkayittarihi=@doktorkayittarihi where doktorid=@doktorid", baglan.baglanti);
                sifreguncelle.Parameters.AddWithValue("@doktorid", txtdoktorid.Text);
                sifreguncelle.Parameters.AddWithValue("@doktortc", txtdoktortc.Text);
                sifreguncelle.Parameters.AddWithValue("@doktorad", txtdoktorad.Text);
                sifreguncelle.Parameters.AddWithValue("@doktorsoyad", txtdoktorsoyad.Text);
                sifreguncelle.Parameters.AddWithValue("@doktordogumtarihi", doktordogumtarihi.Text);
                sifreguncelle.Parameters.AddWithValue("@doktortelefon", txtdoktortelefon.Text);
                sifreguncelle.Parameters.AddWithValue("@doktorbransi", txtdoktorbransi.Text);
                sifreguncelle.Parameters.AddWithValue("@doktorkayittarihi", doktorkayittarihi.Text);  
                sifreguncelle.ExecuteNonQuery();
                MessageBox.Show("Bilgiler başarıyla güncellendi.");

                SqlCommand komut = new SqlCommand("select * from doktor ", baglan.baglanti);
                SqlDataReader dr = komut.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dtgrwdoktor.DataSource = dt;

                baglan.baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Beklenmedik bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (baglan.baglanti.State == System.Data.ConnectionState.Open)
                {
                    baglan.baglanti.Close();
                }
            }
        }

        private void dtgrwdoktor_SelectionChanged(object sender, EventArgs e)
        { 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            openFileDialog1.Filter = "Resim Dosyası |*.jpeg;*.png;*.jpg |  Tüm Dosyalar |*.*";
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            int kayit = int.Parse(txtdoktorid.Text);

            var result = MessageBox.Show("Bak Emin Misin Siliyim Mi", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                var result2 = MessageBox.Show("Bak Siliyorum", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result2 == DialogResult.Yes)
                {

                    baglan.baglanti.Open();

                    SqlCommand sorgu = new SqlCommand("delete from hasta where id=" + kayit, baglan.baglanti);
                    sorgu.ExecuteNonQuery();
                    MessageBox.Show("mesaj silindi");

                    SqlCommand komut = new SqlCommand("select * from hasta ", baglan.baglanti);
                    SqlDataReader dr = komut.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    dtgrwdoktor.DataSource = dt;

                    baglan.baglanti.Close();
                }
            }
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            txtara.ResetText();
            txtdoktorad.ResetText();
            txtdoktorbransi.ResetText();
            txtdoktorsoyad.ResetText();
            txtdoktortelefon.ResetText(); 
        }
    }
}
