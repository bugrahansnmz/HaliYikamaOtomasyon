using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HaliYikama
{
    public partial class KullaniciOlustur : Form
    {
        public KullaniciOlustur()
        {
            InitializeComponent();
        }
        DataBase data;
        private void KullaniciOlustur_Load(object sender, EventArgs e)
        {
            data = new DataBase();
        }
        private void btnCalisanKaydol_Click(object sender, EventArgs e)
        {
            if (tbCalisanAdi.Text != "" && tbCalisanSifre.Text != "" && tbCalisanSifreTekrar.Text != "" && tbCalisanSifre.Text == tbCalisanSifreTekrar.Text)
            {
                if (cbCalisan.Checked == true)
                {
                  Kullanici k = new Kullanici(tbCalisanAdi.Text, tbCalisanSifre.Text,1);
                  if (data.CheckYoneticiKullanici(k.calisanTuru))
                  {
                      data.YoneticiKayit(k);
                      MessageBox.Show("Yönetici Kayıt Başarılı.");
                  }
                  else
                  {
                      MessageBox.Show("Bu kullanıcı adı veya şifre zaten var.");
                  }
                }
                else
                {
                    Kullanici k = new Kullanici(tbCalisanAdi.Text, tbCalisanSifre.Text, 0);
                    if (data.CheckYoneticiKullanici(k.calisanTuru))
                    {
                        data.CalisanKayit(k);
                        MessageBox.Show("Çalışan Kayıt Başarılı.");
                    }
                    else
                    {
                        MessageBox.Show("Bu kullanıcı adı veya şifre zaten var.");
                    }
                }
                

            }
            else
            {
                MessageBox.Show("Hatalı Giriş.");
            }
        }
        private void btnGeri_Click(object sender, EventArgs e)
        {
            Giris g = new Giris();
            this.Visible = false;
            g.ShowDialog();
            this.Visible = true;
        }
       
        private void btnCalisanYenile_Click(object sender, EventArgs e)
        {
            tbCalisanAdi.Clear();
            tbCalisanSifre.Clear();
            tbCalisanSifreTekrar.Clear();
        }
    }
}
