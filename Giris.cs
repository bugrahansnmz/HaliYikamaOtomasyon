using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HaliYikama
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        DataBase data = new DataBase();
        static public string ad;
        static public string sifre;
        static public byte TrueFalse;
        
        public SqlConnection Baglantı()
        {
            SqlConnection Baglan = new SqlConnection("Data Source=KINGHAZE;Initial Catalog=HaliYikama;Integrated Security=True");
            Baglan.Open();
            return Baglan;
        }
        private void Giris_Load(object sender, EventArgs e)
        {
        }
       
        private void buttonGiris_Click(object sender, EventArgs e)
        {
            SqlConnection baglan = Baglantı();
            SqlCommand kmt = new SqlCommand("SELECT k_adi,k_sifre,calisan_tur FROM Calisan WHERE  k_adi ='" + tbKullanici_adi.Text + "' and k_sifre ='" + tbSifre.Text + "' ", baglan);
            SqlDataReader read = kmt.ExecuteReader();
            string k;
            string l;
            byte m;
            while (read.Read())
            {
                k = read.GetString(0);
                l = read.GetString(1);
                m = Convert.ToByte(read.GetBoolean(2));
                ad = read.GetString(0);
                sifre = read.GetString(1);
                TrueFalse = Convert.ToByte(read.GetBoolean(2));
                Kullanici kullanici = new Kullanici(k, l, m);
                if (!data.CheckCalisanKullanici2(kullanici.kAdi, kullanici.kSifre, kullanici.calisanTuru))
                {
                    if (kullanici.calisanTuru == 1)
                    {
                        MessageBox.Show("Yönetici Giriş Başarılı!");
                        Müşteri_İşlem musteri = new Müşteri_İşlem();
                        this.Visible = false;
                        musteri.ShowDialog();
                        this.Visible = true;
                    }
                    else if (kullanici.calisanTuru == 0)
                    {
                        MessageBox.Show("Çalışan Giriş Başarılı!");
                        Müşteri_İşlem musteri = new Müşteri_İşlem();
                        this.Visible = false;
                        musteri.ShowDialog();
                        this.Visible = true;
                    }
                }
                

            }
        }
        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void tbSifre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SqlConnection baglan = Baglantı();
                SqlCommand kmt = new SqlCommand("SELECT k_adi,k_sifre,calisan_tur FROM Calisan WHERE  k_adi ='" + tbKullanici_adi.Text + "' and k_sifre ='" + tbSifre.Text + "' ", baglan);
                SqlDataReader read = kmt.ExecuteReader();
                string k;
                string l;
                byte m;
                while (read.Read())
                {
                    k = read.GetString(0);
                    l = read.GetString(1);
                    m = Convert.ToByte(read.GetBoolean(2));
                    Kullanici kullanici = new Kullanici(k, l, m);
                    if (!data.CheckCalisanKullanici2(kullanici.kAdi, kullanici.kSifre, kullanici.calisanTuru))
                    {
                        if (kullanici.calisanTuru == 1)
                        {
                            MessageBox.Show("Yönetici Giriş Başarılı!");
                            Müşteri_İşlem musteri = new Müşteri_İşlem();
                            this.Visible = false;
                            musteri.ShowDialog();
                            this.Visible = true;
                        }
                        else if (kullanici.calisanTuru == 0)
                        {
                            MessageBox.Show("Çalışan Giriş Başarılı!");
                            Müşteri_İşlem musteri = new Müşteri_İşlem();
                            this.Visible = false;
                            musteri.ShowDialog();
                            this.Visible = true;
                        }
                    }

                }

            }
        }
        private void btnYeniKullanici_Click(object sender, EventArgs e)
        {
            KullaniciOlustur k = new KullaniciOlustur();
            this.Visible = false;
            k.ShowDialog();
            this.Visible = true;
        }
    }

}
