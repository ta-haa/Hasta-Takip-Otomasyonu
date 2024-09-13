namespace start
{
    partial class doktor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtgrwdoktor = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.txtdoktorbransi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdoktortelefon = new System.Windows.Forms.TextBox();
            this.txtdoktorsoyad = new System.Windows.Forms.TextBox();
            this.btntemizle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.lblzaman = new System.Windows.Forms.Label();
            this.lblcaptcha = new System.Windows.Forms.Label();
            this.txtdoktorad = new System.Windows.Forms.TextBox();
            this.Gsifre = new System.Windows.Forms.Label();
            this.Geposta = new System.Windows.Forms.Label();
            this.btnlistele = new System.Windows.Forms.Button();
            this.txtdoktortc = new System.Windows.Forms.TextBox();
            this.txtdoktorid = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtara = new System.Windows.Forms.Button();
            this.txtdoktorara = new System.Windows.Forms.TextBox();
            this.doktordogumtarihi = new System.Windows.Forms.DateTimePicker();
            this.doktorkayittarihi = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrwdoktor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgrwdoktor
            // 
            this.dtgrwdoktor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgrwdoktor.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgrwdoktor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrwdoktor.Location = new System.Drawing.Point(12, 470);
            this.dtgrwdoktor.Name = "dtgrwdoktor";
            this.dtgrwdoktor.RowHeadersWidth = 51;
            this.dtgrwdoktor.RowTemplate.Height = 24;
            this.dtgrwdoktor.Size = new System.Drawing.Size(1101, 420);
            this.dtgrwdoktor.TabIndex = 88;
            this.dtgrwdoktor.SelectionChanged += new System.EventHandler(this.dtgrwdoktor_SelectionChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(616, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 25);
            this.label8.TabIndex = 82;
            this.label8.Text = "Kayıt Tarihi";
            // 
            // txtdoktorbransi
            // 
            this.txtdoktorbransi.Location = new System.Drawing.Point(762, 133);
            this.txtdoktorbransi.Multiline = true;
            this.txtdoktorbransi.Name = "txtdoktorbransi";
            this.txtdoktorbransi.Size = new System.Drawing.Size(198, 32);
            this.txtdoktorbransi.TabIndex = 79;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(616, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 78;
            this.label1.Text = "Doktor Branşı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(616, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 75;
            this.label3.Text = "Telefon :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(616, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 25);
            this.label4.TabIndex = 74;
            this.label4.Text = "Doğum Tarihi :";
            // 
            // txtdoktortelefon
            // 
            this.txtdoktortelefon.Location = new System.Drawing.Point(762, 85);
            this.txtdoktortelefon.MaxLength = 11;
            this.txtdoktortelefon.Multiline = true;
            this.txtdoktortelefon.Name = "txtdoktortelefon";
            this.txtdoktortelefon.Size = new System.Drawing.Size(198, 32);
            this.txtdoktortelefon.TabIndex = 73;
            this.txtdoktortelefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdoktortelefon_KeyPress);
            // 
            // txtdoktorsoyad
            // 
            this.txtdoktorsoyad.Location = new System.Drawing.Point(388, 185);
            this.txtdoktorsoyad.Multiline = true;
            this.txtdoktorsoyad.Name = "txtdoktorsoyad";
            this.txtdoktorsoyad.Size = new System.Drawing.Size(198, 32);
            this.txtdoktorsoyad.TabIndex = 71;
            // 
            // btntemizle
            // 
            this.btntemizle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btntemizle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btntemizle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btntemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btntemizle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btntemizle.Location = new System.Drawing.Point(925, 309);
            this.btntemizle.Name = "btntemizle";
            this.btntemizle.Size = new System.Drawing.Size(187, 50);
            this.btntemizle.TabIndex = 70;
            this.btntemizle.Text = "Temizle";
            this.btntemizle.UseVisualStyleBackColor = true;
            this.btntemizle.Click += new System.EventHandler(this.btntemizle_Click);
            // 
            // btnsil
            // 
            this.btnsil.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnsil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnsil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnsil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnsil.Location = new System.Drawing.Point(718, 309);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(187, 50);
            this.btnsil.TabIndex = 69;
            this.btnsil.Text = "Doktor Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnguncelle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnguncelle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnguncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnguncelle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnguncelle.Location = new System.Drawing.Point(467, 309);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(231, 50);
            this.btnguncelle.TabIndex = 68;
            this.btnguncelle.Text = "Doktor Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // btnekle
            // 
            this.btnekle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnekle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnekle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnekle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnekle.Location = new System.Drawing.Point(260, 309);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(187, 50);
            this.btnekle.TabIndex = 67;
            this.btnekle.Text = "Doktor Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // lblzaman
            // 
            this.lblzaman.AutoSize = true;
            this.lblzaman.BackColor = System.Drawing.Color.Transparent;
            this.lblzaman.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblzaman.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblzaman.Location = new System.Drawing.Point(311, 188);
            this.lblzaman.Name = "lblzaman";
            this.lblzaman.Size = new System.Drawing.Size(80, 25);
            this.lblzaman.TabIndex = 66;
            this.lblzaman.Text = "Soyad :";
            // 
            // lblcaptcha
            // 
            this.lblcaptcha.AutoSize = true;
            this.lblcaptcha.BackColor = System.Drawing.Color.Transparent;
            this.lblcaptcha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblcaptcha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblcaptcha.Location = new System.Drawing.Point(311, 136);
            this.lblcaptcha.Name = "lblcaptcha";
            this.lblcaptcha.Size = new System.Drawing.Size(48, 25);
            this.lblcaptcha.TabIndex = 65;
            this.lblcaptcha.Text = "Ad :";
            // 
            // txtdoktorad
            // 
            this.txtdoktorad.Location = new System.Drawing.Point(388, 133);
            this.txtdoktorad.Multiline = true;
            this.txtdoktorad.Name = "txtdoktorad";
            this.txtdoktorad.Size = new System.Drawing.Size(198, 32);
            this.txtdoktorad.TabIndex = 64;
            // 
            // Gsifre
            // 
            this.Gsifre.AutoSize = true;
            this.Gsifre.BackColor = System.Drawing.Color.Transparent;
            this.Gsifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Gsifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Gsifre.Location = new System.Drawing.Point(311, 84);
            this.Gsifre.Name = "Gsifre";
            this.Gsifre.Size = new System.Drawing.Size(51, 25);
            this.Gsifre.TabIndex = 63;
            this.Gsifre.Text = "TC :";
            // 
            // Geposta
            // 
            this.Geposta.AutoSize = true;
            this.Geposta.BackColor = System.Drawing.Color.Transparent;
            this.Geposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Geposta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Geposta.Location = new System.Drawing.Point(311, 32);
            this.Geposta.Name = "Geposta";
            this.Geposta.Size = new System.Drawing.Size(42, 25);
            this.Geposta.TabIndex = 62;
            this.Geposta.Text = "ID :";
            // 
            // btnlistele
            // 
            this.btnlistele.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnlistele.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnlistele.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnlistele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlistele.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnlistele.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnlistele.Location = new System.Drawing.Point(53, 309);
            this.btnlistele.Name = "btnlistele";
            this.btnlistele.Size = new System.Drawing.Size(187, 50);
            this.btnlistele.TabIndex = 61;
            this.btnlistele.Text = "Doktor Listele";
            this.btnlistele.UseVisualStyleBackColor = true;
            this.btnlistele.Click += new System.EventHandler(this.btnlistele_Click);
            // 
            // txtdoktortc
            // 
            this.txtdoktortc.Location = new System.Drawing.Point(388, 85);
            this.txtdoktortc.MaxLength = 11;
            this.txtdoktortc.Multiline = true;
            this.txtdoktortc.Name = "txtdoktortc";
            this.txtdoktortc.Size = new System.Drawing.Size(198, 32);
            this.txtdoktortc.TabIndex = 60;
            this.txtdoktortc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdoktortc_KeyPress);
            // 
            // txtdoktorid
            // 
            this.txtdoktorid.Location = new System.Drawing.Point(388, 29);
            this.txtdoktorid.Multiline = true;
            this.txtdoktorid.Name = "txtdoktorid";
            this.txtdoktorid.ReadOnly = true;
            this.txtdoktorid.Size = new System.Drawing.Size(198, 32);
            this.txtdoktorid.TabIndex = 59;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(53, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 191);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 89;
            this.pictureBox1.TabStop = false;
            // 
            // txtara
            // 
            this.txtara.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtara.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.txtara.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.txtara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtara.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtara.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtara.Location = new System.Drawing.Point(823, 389);
            this.txtara.Name = "txtara";
            this.txtara.Size = new System.Drawing.Size(159, 63);
            this.txtara.TabIndex = 91;
            this.txtara.Text = "Doktor Ara";
            this.txtara.UseVisualStyleBackColor = true;
            this.txtara.Click += new System.EventHandler(this.txtara_Click);
            // 
            // txtdoktorara
            // 
            this.txtdoktorara.Location = new System.Drawing.Point(230, 389);
            this.txtdoktorara.Multiline = true;
            this.txtdoktorara.Name = "txtdoktorara";
            this.txtdoktorara.Size = new System.Drawing.Size(565, 63);
            this.txtdoktorara.TabIndex = 90;
            // 
            // doktordogumtarihi
            // 
            this.doktordogumtarihi.Location = new System.Drawing.Point(762, 34);
            this.doktordogumtarihi.Name = "doktordogumtarihi";
            this.doktordogumtarihi.Size = new System.Drawing.Size(200, 22);
            this.doktordogumtarihi.TabIndex = 92;
            // 
            // doktorkayittarihi
            // 
            this.doktorkayittarihi.Location = new System.Drawing.Point(762, 188);
            this.doktorkayittarihi.Name = "doktorkayittarihi";
            this.doktorkayittarihi.Size = new System.Drawing.Size(200, 22);
            this.doktorkayittarihi.TabIndex = 93;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(53, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 50);
            this.button1.TabIndex = 94;
            this.button1.Text = "Resim Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // doktor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 931);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.doktorkayittarihi);
            this.Controls.Add(this.doktordogumtarihi);
            this.Controls.Add(this.txtara);
            this.Controls.Add(this.txtdoktorara);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dtgrwdoktor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtdoktorbransi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtdoktortelefon);
            this.Controls.Add(this.txtdoktorsoyad);
            this.Controls.Add(this.btntemizle);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.lblzaman);
            this.Controls.Add(this.lblcaptcha);
            this.Controls.Add(this.txtdoktorad);
            this.Controls.Add(this.Gsifre);
            this.Controls.Add(this.Geposta);
            this.Controls.Add(this.btnlistele);
            this.Controls.Add(this.txtdoktortc);
            this.Controls.Add(this.txtdoktorid);
            this.Name = "doktor";
            this.Text = "Doktorlar";
            this.Load += new System.EventHandler(this.doktor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrwdoktor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgrwdoktor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtdoktorbransi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdoktortelefon;
        private System.Windows.Forms.TextBox txtdoktorsoyad;
        private System.Windows.Forms.Button btntemizle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Label lblzaman;
        private System.Windows.Forms.Label lblcaptcha;
        private System.Windows.Forms.TextBox txtdoktorad;
        private System.Windows.Forms.Label Gsifre;
        private System.Windows.Forms.Label Geposta;
        private System.Windows.Forms.Button btnlistele;
        private System.Windows.Forms.TextBox txtdoktortc;
        private System.Windows.Forms.TextBox txtdoktorid;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button txtara;
        private System.Windows.Forms.TextBox txtdoktorara;
        private System.Windows.Forms.DateTimePicker doktordogumtarihi;
        private System.Windows.Forms.DateTimePicker doktorkayittarihi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}