
namespace HaliYikama
{
    partial class KullaniciOlustur
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
            this.btnGeri = new System.Windows.Forms.Button();
            this.tbCalisanSifreTekrar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalisanYenile = new System.Windows.Forms.Button();
            this.btnCalisanKaydol = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCalisanAdi = new System.Windows.Forms.TextBox();
            this.tbCalisanSifre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbCalisan = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(12, 5);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(49, 29);
            this.btnGeri.TabIndex = 10;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // tbCalisanSifreTekrar
            // 
            this.tbCalisanSifreTekrar.Location = new System.Drawing.Point(170, 121);
            this.tbCalisanSifreTekrar.Name = "tbCalisanSifreTekrar";
            this.tbCalisanSifreTekrar.Size = new System.Drawing.Size(125, 27);
            this.tbCalisanSifreTekrar.TabIndex = 22;
            this.tbCalisanSifreTekrar.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Kullanıcı Adı";
            // 
            // btnCalisanYenile
            // 
            this.btnCalisanYenile.Location = new System.Drawing.Point(170, 200);
            this.btnCalisanYenile.Name = "btnCalisanYenile";
            this.btnCalisanYenile.Size = new System.Drawing.Size(125, 29);
            this.btnCalisanYenile.TabIndex = 24;
            this.btnCalisanYenile.Text = "Yenile";
            this.btnCalisanYenile.UseVisualStyleBackColor = true;
            this.btnCalisanYenile.Click += new System.EventHandler(this.btnCalisanYenile_Click);
            // 
            // btnCalisanKaydol
            // 
            this.btnCalisanKaydol.Location = new System.Drawing.Point(40, 200);
            this.btnCalisanKaydol.Name = "btnCalisanKaydol";
            this.btnCalisanKaydol.Size = new System.Drawing.Size(125, 29);
            this.btnCalisanKaydol.TabIndex = 23;
            this.btnCalisanKaydol.Text = "Kaydol";
            this.btnCalisanKaydol.UseVisualStyleBackColor = true;
            this.btnCalisanKaydol.Click += new System.EventHandler(this.btnCalisanKaydol_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Şifre";
            // 
            // tbCalisanAdi
            // 
            this.tbCalisanAdi.Location = new System.Drawing.Point(170, 55);
            this.tbCalisanAdi.Name = "tbCalisanAdi";
            this.tbCalisanAdi.Size = new System.Drawing.Size(125, 27);
            this.tbCalisanAdi.TabIndex = 19;
            // 
            // tbCalisanSifre
            // 
            this.tbCalisanSifre.Location = new System.Drawing.Point(170, 88);
            this.tbCalisanSifre.Name = "tbCalisanSifre";
            this.tbCalisanSifre.Size = new System.Drawing.Size(125, 27);
            this.tbCalisanSifre.TabIndex = 20;
            this.tbCalisanSifre.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Şifre (Tekrar)";
            // 
            // cbCalisan
            // 
            this.cbCalisan.AutoSize = true;
            this.cbCalisan.Location = new System.Drawing.Point(184, 154);
            this.cbCalisan.Name = "cbCalisan";
            this.cbCalisan.Size = new System.Drawing.Size(87, 24);
            this.cbCalisan.TabIndex = 25;
            this.cbCalisan.Text = "Yetki Ver";
            this.cbCalisan.UseVisualStyleBackColor = true;
            // 
            // KullaniciOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 272);
            this.Controls.Add(this.cbCalisan);
            this.Controls.Add(this.tbCalisanSifreTekrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCalisanYenile);
            this.Controls.Add(this.btnCalisanKaydol);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbCalisanAdi);
            this.Controls.Add(this.tbCalisanSifre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGeri);
            this.Name = "KullaniciOlustur";
            this.Text = "KullaniciOlustur";
            this.Load += new System.EventHandler(this.KullaniciOlustur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.TextBox tbCalisanSifreTekrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalisanYenile;
        private System.Windows.Forms.Button btnCalisanKaydol;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCalisanAdi;
        private System.Windows.Forms.TextBox tbCalisanSifre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbCalisan;
    }
}