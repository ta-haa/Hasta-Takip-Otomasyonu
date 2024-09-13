namespace start
{
    partial class giris
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
            this.components = new System.ComponentModel.Container();
            this.Gsifre = new System.Windows.Forms.Label();
            this.Geposta = new System.Windows.Forms.Label();
            this.btngiris = new System.Windows.Forms.Button();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.txteposta = new System.Windows.Forms.TextBox();
            this.lblcaptcha = new System.Windows.Forms.Label();
            this.txtcaptcha = new System.Windows.Forms.TextBox();
            this.zaman = new System.Windows.Forms.Timer(this.components);
            this.lblzaman = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Gsifre
            // 
            this.Gsifre.AutoSize = true;
            this.Gsifre.BackColor = System.Drawing.Color.Transparent;
            this.Gsifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Gsifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Gsifre.Location = new System.Drawing.Point(49, 162);
            this.Gsifre.Name = "Gsifre";
            this.Gsifre.Size = new System.Drawing.Size(52, 25);
            this.Gsifre.TabIndex = 9;
            this.Gsifre.Text = "Şifre";
            // 
            // Geposta
            // 
            this.Geposta.AutoSize = true;
            this.Geposta.BackColor = System.Drawing.Color.Transparent;
            this.Geposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Geposta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Geposta.Location = new System.Drawing.Point(49, 72);
            this.Geposta.Name = "Geposta";
            this.Geposta.Size = new System.Drawing.Size(73, 25);
            this.Geposta.TabIndex = 8;
            this.Geposta.Text = "Eposta";
            // 
            // btngiris
            // 
            this.btngiris.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btngiris.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btngiris.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btngiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngiris.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btngiris.Location = new System.Drawing.Point(54, 366);
            this.btngiris.Name = "btngiris";
            this.btngiris.Size = new System.Drawing.Size(219, 50);
            this.btngiris.TabIndex = 7;
            this.btngiris.Text = "Giriş Yap";
            this.btngiris.UseVisualStyleBackColor = true;
            this.btngiris.Click += new System.EventHandler(this.btnkayit_Click);
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(52, 200);
            this.txtsifre.Multiline = true;
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.PasswordChar = '*';
            this.txtsifre.Size = new System.Drawing.Size(219, 37);
            this.txtsifre.TabIndex = 6;
            // 
            // txteposta
            // 
            this.txteposta.Location = new System.Drawing.Point(52, 109);
            this.txteposta.Multiline = true;
            this.txteposta.Name = "txteposta";
            this.txteposta.Size = new System.Drawing.Size(219, 39);
            this.txteposta.TabIndex = 5;
            // 
            // lblcaptcha
            // 
            this.lblcaptcha.AutoSize = true;
            this.lblcaptcha.BackColor = System.Drawing.Color.Transparent;
            this.lblcaptcha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblcaptcha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblcaptcha.Location = new System.Drawing.Point(49, 257);
            this.lblcaptcha.Name = "lblcaptcha";
            this.lblcaptcha.Size = new System.Drawing.Size(86, 25);
            this.lblcaptcha.TabIndex = 11;
            this.lblcaptcha.Text = "Captcha";
            // 
            // txtcaptcha
            // 
            this.txtcaptcha.Location = new System.Drawing.Point(54, 300);
            this.txtcaptcha.Multiline = true;
            this.txtcaptcha.Name = "txtcaptcha";
            this.txtcaptcha.Size = new System.Drawing.Size(219, 37);
            this.txtcaptcha.TabIndex = 10;
            // 
            // zaman
            // 
            this.zaman.Tick += new System.EventHandler(this.zaman_Tick);
            // 
            // lblzaman
            // 
            this.lblzaman.AutoSize = true;
            this.lblzaman.BackColor = System.Drawing.Color.Transparent;
            this.lblzaman.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblzaman.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblzaman.Location = new System.Drawing.Point(219, 257);
            this.lblzaman.Name = "lblzaman";
            this.lblzaman.Size = new System.Drawing.Size(54, 25);
            this.lblzaman.TabIndex = 12;
            this.lblzaman.Text = "Süre";
            // 
            // giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 507);
            this.Controls.Add(this.lblzaman);
            this.Controls.Add(this.lblcaptcha);
            this.Controls.Add(this.txtcaptcha);
            this.Controls.Add(this.Gsifre);
            this.Controls.Add(this.Geposta);
            this.Controls.Add(this.btngiris);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.txteposta);
            this.Name = "giris";
            this.Text = "Giriş";
            this.Load += new System.EventHandler(this.giris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Gsifre;
        private System.Windows.Forms.Label Geposta;
        private System.Windows.Forms.Button btngiris;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.TextBox txteposta;
        private System.Windows.Forms.Label lblcaptcha;
        private System.Windows.Forms.TextBox txtcaptcha;
        private System.Windows.Forms.Timer zaman;
        private System.Windows.Forms.Label lblzaman;
    }
}