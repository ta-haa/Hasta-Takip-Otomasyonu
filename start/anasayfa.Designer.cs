namespace start
{
    partial class anasayfa
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anasayfa));
            this.kayit = new System.Windows.Forms.Button();
            this.giris = new System.Windows.Forms.Button();
            this.hasta = new System.Windows.Forms.Button();
            this.doktor = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.formuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.formuKapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.iletişimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnqr = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kayit
            // 
            this.kayit.Location = new System.Drawing.Point(80, 107);
            this.kayit.Name = "kayit";
            this.kayit.Size = new System.Drawing.Size(167, 106);
            this.kayit.TabIndex = 0;
            this.kayit.Text = "Kayıt";
            this.kayit.UseVisualStyleBackColor = true;
            this.kayit.Click += new System.EventHandler(this.kayit_Click);
            // 
            // giris
            // 
            this.giris.Location = new System.Drawing.Point(339, 107);
            this.giris.Name = "giris";
            this.giris.Size = new System.Drawing.Size(167, 106);
            this.giris.TabIndex = 1;
            this.giris.Text = "Giriş";
            this.giris.UseVisualStyleBackColor = true;
            this.giris.Click += new System.EventHandler(this.giris_Click);
            // 
            // hasta
            // 
            this.hasta.Location = new System.Drawing.Point(80, 359);
            this.hasta.Name = "hasta";
            this.hasta.Size = new System.Drawing.Size(167, 106);
            this.hasta.TabIndex = 2;
            this.hasta.Text = "Hasta Takip";
            this.hasta.UseVisualStyleBackColor = true;
            this.hasta.Click += new System.EventHandler(this.hasta_Click);
            // 
            // doktor
            // 
            this.doktor.Location = new System.Drawing.Point(339, 359);
            this.doktor.Name = "doktor";
            this.doktor.Size = new System.Drawing.Size(167, 106);
            this.doktor.TabIndex = 3;
            this.doktor.Text = "Doktorlar";
            this.doktor.UseVisualStyleBackColor = true;
            this.doktor.Click += new System.EventHandler(this.doktor_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(932, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yardımToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(932, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iletişimToolStripMenuItem});
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.yardımToolStripMenuItem.Text = "Yardım";
            this.yardımToolStripMenuItem.Click += new System.EventHandler(this.yardımToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formuToolStripMenuItem,
            this.toolStripMenuItem2,
            this.formuKapatToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(164, 76);
            // 
            // formuToolStripMenuItem
            // 
            this.formuToolStripMenuItem.Name = "formuToolStripMenuItem";
            this.formuToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
            this.formuToolStripMenuItem.Text = "Formu Aç";
            this.formuToolStripMenuItem.Click += new System.EventHandler(this.formuToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(163, 24);
            this.toolStripMenuItem2.Text = "Formu Gizle";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // formuKapatToolStripMenuItem
            // 
            this.formuKapatToolStripMenuItem.Name = "formuKapatToolStripMenuItem";
            this.formuKapatToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
            this.formuKapatToolStripMenuItem.Text = "Formu Kapat";
            this.formuKapatToolStripMenuItem.Click += new System.EventHandler(this.formuKapatToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Hastane";
            this.notifyIcon1.Visible = true;
            // 
            // iletişimToolStripMenuItem
            // 
            this.iletişimToolStripMenuItem.Name = "iletişimToolStripMenuItem";
            this.iletişimToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.iletişimToolStripMenuItem.Text = "İletişim";
            this.iletişimToolStripMenuItem.Click += new System.EventHandler(this.iletişimToolStripMenuItem_Click);
            // 
            // btnqr
            // 
            this.btnqr.BackColor = System.Drawing.Color.Red;
            this.btnqr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnqr.Font = new System.Drawing.Font("Hobo Std", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnqr.ForeColor = System.Drawing.Color.Transparent;
            this.btnqr.Image = ((System.Drawing.Image)(resources.GetObject("btnqr.Image")));
            this.btnqr.Location = new System.Drawing.Point(575, 107);
            this.btnqr.Name = "btnqr";
            this.btnqr.Size = new System.Drawing.Size(350, 358);
            this.btnqr.TabIndex = 49;
            this.btnqr.UseVisualStyleBackColor = false;
            this.btnqr.Click += new System.EventHandler(this.btnqr_Click);
            // 
            // anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 561);
            this.Controls.Add(this.btnqr);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.doktor);
            this.Controls.Add(this.hasta);
            this.Controls.Add(this.giris);
            this.Controls.Add(this.kayit);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "anasayfa";
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.anasayfa_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button kayit;
        private System.Windows.Forms.Button giris;
        private System.Windows.Forms.Button hasta;
        private System.Windows.Forms.Button doktor;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripMenuItem formuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem formuKapatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iletişimToolStripMenuItem;
        private System.Windows.Forms.Button btnqr;
    }
}

