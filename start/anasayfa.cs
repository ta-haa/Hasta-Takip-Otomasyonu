using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace start
{
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }

        private void kayit_Click(object sender, EventArgs e)
        {
            kayit panel = new kayit();
            panel.Show();
        }

        private void giris_Click(object sender, EventArgs e)
        {
            giris panel = new giris();
            panel.Show();
        }

        private void hasta_Click(object sender, EventArgs e)
        {
            hasta panel = new hasta();
            panel.Show();
        }

        private void doktor_Click(object sender, EventArgs e)
        {
            doktor panel = new doktor();
            panel.Show();
        }

        private void formuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void formuKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void anasayfa_Load(object sender, EventArgs e)
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

        private void yardımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void iletişimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/@TahaKeskin");
        }

        private void btnqr_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/@TahaKeskin");
        }
    }
}
