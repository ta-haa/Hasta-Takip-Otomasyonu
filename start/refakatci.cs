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
    public partial class refakatci : Form
    {
        public refakatci()
        {
            InitializeComponent();
        }

        private void btntemizle_Click(object sender, EventArgs e)
        { 
            txtrefakatcitc.ResetText();
            txtrefakatciadi.ResetText();
            txtrefakatcitelefon.ResetText(); 
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            baglan.baglanti.Open();
            SqlCommand kod = new SqlCommand("insert into refakatci(refakatcitc,refakatciad,refakatcitelefon) values (@refakatcitc,@refakatciad,@refakatcitelefon)", baglan.baglanti);
            kod.Parameters.AddWithValue("@refakatcitc", txtrefakatcitc.Text);
            kod.Parameters.AddWithValue("@refakatciad", txtrefakatciadi.Text);
            kod.Parameters.AddWithValue("@refakatcitelefon", txtrefakatcitelefon.Text); 

            kod.ExecuteNonQuery();
            MessageBox.Show("Envanter Eklendi");

            SqlCommand komut = new SqlCommand("select * from refakatci ", baglan.baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dtgrwrefakatcilar.DataSource = dt;

            baglan.baglanti.Close();
        }

        private void refakatci_Load(object sender, EventArgs e)
        { 

            baglan.baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from refakatci ", baglan.baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dtgrwrefakatcilar.DataSource = dt;
            baglan.baglanti.Close();


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


        private void btngoster_Click(object sender, EventArgs e)
        {
            if (dtgrwrefakatcilar.CurrentCell != null)
            {  
                txtrefakatciid.Text = dtgrwrefakatcilar.CurrentRow.Cells[0].Value.ToString();
                txtrefakatcitc.Text = dtgrwrefakatcilar.CurrentRow.Cells[1].Value.ToString();
                txtrefakatciadi.Text = dtgrwrefakatcilar.CurrentRow.Cells[2].Value.ToString();
                txtrefakatcitelefon.Text = dtgrwrefakatcilar.CurrentRow.Cells[3].Value.ToString();
            }
            else
            {
                MessageBox.Show("Refakatçı Yok");

            }
        }

        private void txtrefakatcitc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtrefakatcitelefon_KeyPress(object sender, KeyPressEventArgs e)
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
                string arama = txtrefakatciara.Text;
                baglan.baglanti.Open();
                SqlCommand ara = new SqlCommand("select * from refakatci where refakatciad like'%" + arama + "%'", baglan.baglanti);
                SqlDataReader dr = ara.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dtgrwrefakatcilar.DataSource = dt;
                baglan.baglanti.Close();
            }

            catch (Exception)
            {
                MessageBox.Show("Beklenmedik Bir Hatayla Karşılaşıldı Lütfen Daha Sonra Tekrar Deneyiniz...", "!! Hata !!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                Close();
            }
        }
    }
}
