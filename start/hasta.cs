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
    public partial class hasta : Form
    {
        public hasta()
        {
            InitializeComponent();

             
        }

        private void hasta_Load(object sender, EventArgs e)
        {

            string query = "SELECT doktorid FROM doktor";

            try
            { 
                    SqlCommand command = new SqlCommand(query, baglan.baglanti);
                baglan.baglanti.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                    { 
                        cmbbxdoktorid.Items.Clear();
                         
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);  
                            cmbbxdoktorid.Items.Add(id);  
                        }
                    }
                 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            baglan.baglanti.Close();


             

            txttc.TabIndex = 0;
            txtad.TabIndex = 1;
            txtsoyad.TabIndex = 2;

            Rectangle gradient_rectangle = new Rectangle(0, 0, Width, Height);
            Brush brush = new LinearGradientBrush(gradient_rectangle, Color.Cyan, Color.White, 45f);
            Graphics.ReferenceEquals(brush, gradient_rectangle);
            this.Paint += new PaintEventHandler(set_background);

            refakatdurumu.SelectedIndex = 0;
            cmbbxdoktorid.SelectedIndex = 0;
            cmbbxcinsiyet.SelectedIndex = 0;
            cmbbxdoktorid.SelectedIndex = 0;
            cmbbxkangrubu.SelectedIndex = 0;

            baglan.baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from hasta ", baglan.baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dtgrwhasta.DataSource = dt;
            baglan.baglanti.Close();

            this.txtrefakatciid.Text = "3";
        }

        private void set_background(Object sender, PaintEventArgs e)
        {

            Graphics graphics = e.Graphics;
            Rectangle gradient_rectangle = new Rectangle(0, 0, Width, Height);
            Brush b = new LinearGradientBrush(gradient_rectangle, Color.FromArgb(0, 0, 0), Color.FromArgb(0, 192, 192), 65f);
            graphics.FillRectangle(b, gradient_rectangle);

        }
         

         

        private void btntemizle_Click(object sender, EventArgs e)
        {
            txttc.ResetText();
            txtad.ResetText();
            txtsoyad.ResetText();   
            txttelefon.ResetText(); 
            txthastalikgecmisi.ResetText();  
            txthastalik.ResetText();
            txtboy.ResetText(); 
            txtkilo.ResetText(); 
            txtrecete.ResetText();
            txthastanotu.ResetText(); 

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            openFileDialog1.Filter = "Resim Dosyası |*.jpeg;*.png;*.jpg |  Tüm Dosyalar |*.*";
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {


            







            if (dtgrwhasta.CurrentCell != null)
            {

                pictureBox1.Load(dtgrwhasta.CurrentRow.Cells[1].Value.ToString());

                txtid.Text = dtgrwhasta.CurrentRow.Cells[0].Value.ToString();
               
                txttc.Text = dtgrwhasta.CurrentRow.Cells[2].Value.ToString();
                txtad.Text = dtgrwhasta.CurrentRow.Cells[3].Value.ToString();
                txtsoyad.Text = dtgrwhasta.CurrentRow.Cells[4].Value.ToString();
                cmbbxkangrubu.Text = dtgrwhasta.CurrentRow.Cells[5].Value.ToString();
                dtdogumtarihi.Text = dtgrwhasta.CurrentRow.Cells[6].Value.ToString();
                txttelefon.Text = dtgrwhasta.CurrentRow.Cells[7].Value.ToString();
                cmbbxdoktorid.Text = dtgrwhasta.CurrentRow.Cells[8].Value.ToString();
                txthastalikgecmisi.Text = dtgrwhasta.CurrentRow.Cells[9].Value.ToString();
                cmbbxcinsiyet.Text = dtgrwhasta.CurrentRow.Cells[10].Value.ToString();
                dtkayittarihi.Text = dtgrwhasta.CurrentRow.Cells[11].Value.ToString();
                txthastalik.Text = dtgrwhasta.CurrentRow.Cells[12].Value.ToString();
                txtboy.Text = dtgrwhasta.CurrentRow.Cells[13].Value.ToString();
                txtkilo.Text = dtgrwhasta.CurrentRow.Cells[14].Value.ToString();
                dttaburcutarihi.Text = dtgrwhasta.CurrentRow.Cells[15].Value.ToString();
                txtrecete.Text = dtgrwhasta.CurrentRow.Cells[16].Value.ToString();
                txthastanotu.Text = dtgrwhasta.CurrentRow.Cells[17].Value.ToString();
                txtrefakatciid.Text = dtgrwhasta.CurrentRow.Cells[18].Value.ToString();

                refakatdurumu.Visible = false;
                txtrefakatciid.Visible = false;
                lblrefakatciid.Visible = true;
            }
            else
            {
                MessageBox.Show("Hasta Yok");
            }

            baglan.baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from hasta ", baglan.baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dtgrwhasta.DataSource = dt;
            baglan.baglanti.Close();




             
            






        }

        private void refakatdurumu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (refakatdurumu.SelectedIndex == 1)
            {
                txtrefakatciid.Visible = true;
                lblrefakatciid.Visible = true;

                refakatci panel = new refakatci();
                panel.Show();
            }
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
             

            string kangrubu = cmbbxkangrubu.SelectedItem.ToString();
            string cinsiyet = cmbbxcinsiyet.SelectedItem.ToString();
            string doktorid = cmbbxdoktorid.SelectedItem.ToString();
            DateTime dogumtarihi = dtdogumtarihi.Value;
            DateTime kayittarihi = dtkayittarihi.Value;
            DateTime taburcutarihi = dttaburcutarihi.Value;

            baglan.baglanti.Open();
            SqlCommand kod = new SqlCommand("insert into hasta(fotograf,tc,ad,soyad,kangrubu,dogumtarihi,telefon,doktorid,hastalikgecmisi,cinsiyet,kayittarihi,hastalik,boy,kilo,taburcutarihi,hastarecete,hastanotu,refakatciid) values (@fotograf,@tc,@ad,@soyad,@kangrubu,@dogumtarihi,@telefon,@doktorid,@hastalikgecmisi,@cinsiyet,@kayittarihi,@hastalik,@boy,@kilo,@taburcutarihi,@hastarecete,@hastanotu,@refakatciid)", baglan.baglanti);
            kod.Parameters.AddWithValue("@fotograf", openFileDialog1.FileName);
            kod.Parameters.AddWithValue("@tc", txttc.Text);
            kod.Parameters.AddWithValue("@ad", txtad.Text);
            kod.Parameters.AddWithValue("@soyad", txtsoyad.Text);  
            kod.Parameters.AddWithValue("@kangrubu", kangrubu); 
            kod.Parameters.AddWithValue("@dogumtarihi", dogumtarihi);
            kod.Parameters.AddWithValue("@telefon", txttelefon.Text);
            kod.Parameters.AddWithValue("@doktorid", doktorid);
            kod.Parameters.AddWithValue("@hastalikgecmisi", txthastalikgecmisi.Text);
            kod.Parameters.AddWithValue("@cinsiyet", cinsiyet); 
            kod.Parameters.AddWithValue("@kayittarihi", kayittarihi);
            kod.Parameters.AddWithValue("@hastalik", txthastalik.Text); 
            kod.Parameters.AddWithValue("@boy", txtboy.Text);
            kod.Parameters.AddWithValue("@kilo", txtkilo.Text); 
            kod.Parameters.AddWithValue("@taburcutarihi", taburcutarihi);
            kod.Parameters.AddWithValue("@hastarecete", txtrecete.Text);
            kod.Parameters.AddWithValue("@hastanotu", txthastanotu.Text);
            kod.Parameters.AddWithValue("@refakatciid", txtrefakatciid.Text);

            kod.ExecuteNonQuery();
            MessageBox.Show("Hasta Eklendi");

            SqlCommand komut = new SqlCommand("select * from hasta ", baglan.baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dtgrwhasta.DataSource = dt;

            baglan.baglanti.Close();
        }

        private void txttc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtdogumtarihi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txttelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtdoktorid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtkayittarihi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtboy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtkilo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txttaburcutarihi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtrefakatciid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtara_Click(object sender, EventArgs e)
        {
            try
            {
                string arama = txthastaara.Text;
                baglan.baglanti.Open();
                SqlCommand ara = new SqlCommand("select * from hasta where ad like'%" + arama + "%'", baglan.baglanti);
                SqlDataReader dr = ara.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dtgrwhasta.DataSource = dt;
                baglan.baglanti.Close();
            }

            catch (Exception)
            {
                MessageBox.Show("Beklenmedik Bir Hatayla Karşılaşıldı Lütfen Daha Sonra Tekrar Deneyiniz...", "!! Hata !!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                Close();
            }
        }

        private void txthastaara_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string arama = txthastaara.Text;
                baglan.baglanti.Open();
                SqlCommand ara = new SqlCommand("select * from hasta where tc like'%" + arama + "%'", baglan.baglanti);
                SqlDataReader dr = ara.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dtgrwhasta.DataSource = dt;
                baglan.baglanti.Close();
            }

            catch (Exception)
            {
                MessageBox.Show("Beklenmedik Bir Hatayla Karşılaşıldı Lütfen Daha Sonra Tekrar Deneyiniz...", "!! Hata !!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                Close();
            }
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {   
            try
            {
                baglan.baglanti.Open();
                SqlCommand  parametre = new SqlCommand(
                    "update hasta set tc=@tc, ad=@ad, soyad=@soyad, kangrubu=@kangrubu, dogumtarihi=@dogumtarihi, telefon=@telefon, doktorid=@doktorid, hastalikgecmisi=@hastalikgecmisi, cinsiyet=@cinsiyet, kayittarihi=@kayittarihi, hastalik=@hastalik, boy=@boy, kilo=@kilo, taburcutarihi=@taburcutarihi, hastarecete=@hastarecete, hastanotu=@hastanotu, refakatciid=@refakatciid where id=@hastaid",
                    baglan.baglanti);

                 parametre.Parameters.AddWithValue("@hastaid", txtid.Text);
                 parametre.Parameters.AddWithValue("@tc", txttc.Text);
                 parametre.Parameters.AddWithValue("@ad", txtad.Text);
                 parametre.Parameters.AddWithValue("@soyad", txtsoyad.Text);
                 parametre.Parameters.AddWithValue("@kangrubu", cmbbxkangrubu.Text);
                 parametre.Parameters.AddWithValue("@dogumtarihi", dtdogumtarihi.Text);
                 parametre.Parameters.AddWithValue("@telefon", txttelefon.Text);
                 parametre.Parameters.AddWithValue("@doktorid", cmbbxdoktorid.Text);
                 parametre.Parameters.AddWithValue("@hastalikgecmisi", txthastalikgecmisi.Text);
                 parametre.Parameters.AddWithValue("@cinsiyet", cmbbxcinsiyet.Text);
                 parametre.Parameters.AddWithValue("@kayittarihi", dtkayittarihi.Text);
                 parametre.Parameters.AddWithValue("@hastalik", txthastalik.Text);
                 parametre.Parameters.AddWithValue("@boy", txtboy.Text);
                 parametre.Parameters.AddWithValue("@kilo", txtkilo.Text);
                 parametre.Parameters.AddWithValue("@taburcutarihi", dttaburcutarihi.Text);
                 parametre.Parameters.AddWithValue("@hastarecete", txtrecete.Text);
                 parametre.Parameters.AddWithValue("@hastanotu", txthastanotu.Text);
                 parametre.Parameters.AddWithValue("@refakatciid", txtrefakatciid.Text);

                 parametre.ExecuteNonQuery();
                MessageBox.Show("Bilgiler başarıyla güncellendi.");

                SqlCommand komut = new SqlCommand("select * from hasta ", baglan.baglanti);
                SqlDataReader dr = komut.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dtgrwhasta.DataSource = dt;

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

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtgrwhasta_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            int kayit = int.Parse(txtid.Text);

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
                    dtgrwhasta.DataSource = dt;

                    baglan.baglanti.Close();
                }
            }
        }
         
    }
}
