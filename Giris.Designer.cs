
namespace HaliYikama
{
    partial class Giris
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
            this.buttonGiris = new System.Windows.Forms.Button();
            this.tbKullanici_adi = new System.Windows.Forms.TextBox();
            this.tbSifre = new System.Windows.Forms.TextBox();
            this.labelKA = new System.Windows.Forms.Label();
            this.labelSifre = new System.Windows.Forms.Label();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnYeniKullanici = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonGiris
            // 
            this.buttonGiris.Location = new System.Drawing.Point(132, 117);
            this.buttonGiris.Name = "buttonGiris";
            this.buttonGiris.Size = new System.Drawing.Size(98, 32);
            this.buttonGiris.TabIndex = 0;
            this.buttonGiris.Text = "GİRİŞ YAP";
            this.buttonGiris.UseVisualStyleBackColor = true;
            this.buttonGiris.Click += new System.EventHandler(this.buttonGiris_Click);
            // 
            // tbKullanici_adi
            // 
            this.tbKullanici_adi.Location = new System.Drawing.Point(132, 21);
            this.tbKullanici_adi.Name = "tbKullanici_adi";
            this.tbKullanici_adi.Size = new System.Drawing.Size(201, 27);
            this.tbKullanici_adi.TabIndex = 1;
            // 
            // tbSifre
            // 
            this.tbSifre.Location = new System.Drawing.Point(132, 69);
            this.tbSifre.Name = "tbSifre";
            this.tbSifre.Size = new System.Drawing.Size(201, 27);
            this.tbSifre.TabIndex = 2;
            this.tbSifre.UseSystemPasswordChar = true;
            this.tbSifre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSifre_KeyDown);
            // 
            // labelKA
            // 
            this.labelKA.AutoSize = true;
            this.labelKA.Location = new System.Drawing.Point(34, 21);
            this.labelKA.Name = "labelKA";
            this.labelKA.Size = new System.Drawing.Size(92, 20);
            this.labelKA.TabIndex = 3;
            this.labelKA.Text = "Kullanıcı Adı";
            // 
            // labelSifre
            // 
            this.labelSifre.AutoSize = true;
            this.labelSifre.Location = new System.Drawing.Point(87, 76);
            this.labelSifre.Name = "labelSifre";
            this.labelSifre.Size = new System.Drawing.Size(39, 20);
            this.labelSifre.TabIndex = 4;
            this.labelSifre.Text = "Şifre";
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(235, 117);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(98, 32);
            this.btnCikis.TabIndex = 5;
            this.btnCikis.Text = "ÇIKIŞ";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnYeniKullanici
            // 
            this.btnYeniKullanici.Location = new System.Drawing.Point(132, 156);
            this.btnYeniKullanici.Name = "btnYeniKullanici";
            this.btnYeniKullanici.Size = new System.Drawing.Size(201, 29);
            this.btnYeniKullanici.TabIndex = 6;
            this.btnYeniKullanici.Text = "Yeni Kullanıcı";
            this.btnYeniKullanici.UseVisualStyleBackColor = true;
            this.btnYeniKullanici.Click += new System.EventHandler(this.btnYeniKullanici_Click);
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(455, 211);
            this.Controls.Add(this.btnYeniKullanici);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.labelSifre);
            this.Controls.Add(this.labelKA);
            this.Controls.Add(this.tbSifre);
            this.Controls.Add(this.tbKullanici_adi);
            this.Controls.Add(this.buttonGiris);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Giris";
            this.Text = "Giris";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.Giris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGiris;
        private System.Windows.Forms.TextBox tbKullanici_adi;
        private System.Windows.Forms.TextBox tbSifre;
        private System.Windows.Forms.Label labelKA;
        private System.Windows.Forms.Label labelSifre;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnYeniKullanici;
    }
}