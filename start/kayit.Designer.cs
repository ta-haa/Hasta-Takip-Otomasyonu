namespace start
{
    partial class kayit
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
            this.txtKeposta = new System.Windows.Forms.TextBox();
            this.txtKsifre = new System.Windows.Forms.TextBox();
            this.kayitol = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtKeposta
            // 
            this.txtKeposta.Location = new System.Drawing.Point(81, 109);
            this.txtKeposta.Multiline = true;
            this.txtKeposta.Name = "txtKeposta";
            this.txtKeposta.Size = new System.Drawing.Size(219, 39);
            this.txtKeposta.TabIndex = 0;
            // 
            // txtKsifre
            // 
            this.txtKsifre.Location = new System.Drawing.Point(81, 200);
            this.txtKsifre.Multiline = true;
            this.txtKsifre.Name = "txtKsifre";
            this.txtKsifre.PasswordChar = '*';
            this.txtKsifre.Size = new System.Drawing.Size(219, 37);
            this.txtKsifre.TabIndex = 1;
            // 
            // kayitol
            // 
            this.kayitol.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.kayitol.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.kayitol.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.kayitol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kayitol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kayitol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.kayitol.Location = new System.Drawing.Point(81, 268);
            this.kayitol.Name = "kayitol";
            this.kayitol.Size = new System.Drawing.Size(219, 50);
            this.kayitol.TabIndex = 2;
            this.kayitol.Text = "Kayit Ol";
            this.kayitol.UseVisualStyleBackColor = true;
            this.kayitol.Click += new System.EventHandler(this.kayitol_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(78, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Eposta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(78, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifre";
            // 
            // kayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(379, 543);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kayitol);
            this.Controls.Add(this.txtKsifre);
            this.Controls.Add(this.txtKeposta);
            this.Name = "kayit";
            this.Text = "Kayıt";
            this.Load += new System.EventHandler(this.kayit_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKeposta;
        private System.Windows.Forms.TextBox txtKsifre;
        private System.Windows.Forms.Button kayitol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}