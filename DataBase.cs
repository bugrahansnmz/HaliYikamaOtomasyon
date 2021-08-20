using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace HaliYikama
{

    class DataBase
    {

        public SqlConnection Baglantı()
        {
            SqlConnection Baglan = new SqlConnection("Data Source=KINGHAZE;Initial Catalog=HaliYikama;Integrated Security=True");
            Baglan.Open();
            return Baglan;
        }
        public void InsertMusteri(Musteri musteri)
        {
            SqlConnection baglan = Baglantı();
            string b;
            b = string.Format("{0:C}", (Convert.ToDecimal(musteri.HaliMt2) * Convert.ToDecimal(musteri.Fiyat)) / 10);
            SqlCommand komut = new SqlCommand("INSERT INTO Musteri ( MusteriAdi, MusteriSoyadi, Telefon, Bolge, Adres, Aciklama, KayitTarihi, HaliAdedi,TahminiCikisTarihi,HaliMt2,Fiyat) VALUES ('" + musteri.MusteriAdi + "','" + musteri.MusteriSoyadi + "','" + musteri.Telefon + "','" + musteri.Bolge + "','" + musteri.Adres + "','" + musteri.Aciklama + "','" + musteri.KayitTarihi + "','" + musteri.HaliAdet + "','" + musteri.TahminiCikisTarihi + "','" + String.Format(musteri.HaliMt2) + "','" + b + "')", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
        }
        public DataTable MusteriAra(string a, string s, string t)
        {
            SqlConnection baglan = Baglantı();
            SqlDataAdapter komut = new SqlDataAdapter("select * from Musteri where MusteriAdi like'%" + a + "%'and MusteriSoyadi like'%" + s + "%' and Telefon  like'%" + t + "%' ", baglan);
            DataSet dataSet = new DataSet();
            komut.Fill(dataSet, "Musteri");
            komut.Dispose();
            baglan.Close();
            return dataSet.Tables["Musteri"];
        }
        public DataTable Listele()
        {
            SqlConnection baglan = Baglantı();
            SqlDataAdapter komut = new SqlDataAdapter("select * From Musteri", baglan);
            DataSet dataSet = new DataSet();
            komut.Fill(dataSet, "Musteri");
            komut.Dispose();
            baglan.Close();
            return dataSet.Tables["Musteri"];
        }
        public bool CheckMusteri(String tele)
        {
            SqlConnection baglan = Baglantı();
            SqlCommand kmt = new SqlCommand("SELECT * FROM Musteri where  Telefon ='" + tele + "'", baglan);
            SqlDataReader read = kmt.ExecuteReader();
            if (read.HasRows)
            {
                baglan.Close();
                return false;
            }
            baglan.Close();
            return true;
        }
        public bool CheckMusteri(String tele, int id)
        {
            SqlConnection baglan = Baglantı();
            SqlCommand kmt = new SqlCommand("SELECT * FROM Musteri where  Telefon ='" + tele + "' and not ID =" + id, baglan);
            SqlDataReader read = kmt.ExecuteReader();
            if (read.HasRows)
            {
                baglan.Close();
                return false;
            }
            baglan.Close();
            return true;
        }
        public void UpdateMusteri(Musteri musteri, int a)
        {
            SqlConnection baglan = Baglantı();
            string b;
            b = string.Format("{0:C}", (Convert.ToDecimal(musteri.HaliMt2) * Convert.ToDecimal(musteri.Fiyat)) / 10);
            SqlCommand kmt = new SqlCommand("UPDATE Musteri SET MusteriAdi = '" + musteri.MusteriAdi + "', MusteriSoyadi = '" + musteri.MusteriSoyadi + "', Telefon ='" + musteri.Telefon + "', Bolge='" + musteri.Bolge + "', Adres ='" + musteri.Adres + "', Aciklama='" + musteri.Aciklama + "', KayitTarihi ='" + musteri.KayitTarihi + "', HaliAdedi = " + musteri.HaliAdet + ", TahminiCikisTarihi ='" + musteri.TahminiCikisTarihi + "',HaliMt2='" + String.Format(musteri.HaliMt2) + "',Fiyat='" + b + "'  WHERE ID = " + a, baglan);
            kmt.ExecuteNonQuery();
            baglan.Close();
        }
        public void DeleteMusteri(int id)
        {
            SqlConnection baglan = Baglantı();
            SqlCommand kmt = new SqlCommand("INSERT INTO GidenMusteri(ID,Musteri_Adi,Musteri_Soyadi,Telefon,Bolge,Adres,Aciklama,Kayit_Tarihi,Hali_Adedi,Cıkıs_Tarihi,Hali_Mt2) select ID,MusteriAdi,MusteriSoyadi,Telefon,Bolge,Adres,Aciklama,KayitTarihi,HaliAdedi,TahminiCikisTarihi,HaliMt2 FROM Musteri WHERE ID =" + id, baglan);
            kmt.ExecuteNonQuery();
            SqlCommand komut = new SqlCommand("DELETE FROM Musteri WHERE ID = " + id + "  ", baglan);
            komut.ExecuteNonQuery();
        }
        public void CikanMusteri(int id, string fiyat)
        {
            SqlConnection baglan = Baglantı();
            SqlCommand kmt = new SqlCommand("INSERT INTO Gelirler(ID,Musteri_Adi,Musteri_Soyadi,Telefon,Hali_Adet,Fiyat,Hali_Mt2) select ID,MusteriAdi,MusteriSoyadi,Telefon,HaliAdedi,'" + fiyat + "',HaliMt2 FROM Musteri WHERE ID =" + id, baglan);
            kmt.ExecuteNonQuery();
            SqlCommand kmt2 = new SqlCommand("INSERT INTO GidenMusteri(ID,Musteri_Adi,Musteri_Soyadi,Telefon,Bolge,Adres,Aciklama,Kayit_Tarihi,Hali_Adedi,Cıkıs_Tarihi,Hali_Mt2) select ID,MusteriAdi,MusteriSoyadi,Telefon,Bolge,Adres,Aciklama,KayitTarihi,HaliAdedi,TahminiCikisTarihi,HaliMt2 FROM Musteri WHERE ID =" + id, baglan);
            kmt2.ExecuteNonQuery();
            SqlCommand komut = new SqlCommand("DELETE FROM Musteri WHERE ID = " + id + "  ", baglan);
            komut.ExecuteNonQuery();
        }
        public DataTable GelirListele()
        {
            SqlConnection baglan = Baglantı();
            SqlDataAdapter komut = new SqlDataAdapter("SELECT * FROM Gelirler", baglan);
            DataSet dataSet = new DataSet();
            komut.Fill(dataSet, "Gelirler");
            komut.Dispose();
            baglan.Close();
            return dataSet.Tables["Gelirler"];
        }
        public DataTable SilinenListele()
        {
            SqlConnection baglan = Baglantı();
            SqlDataAdapter komut = new SqlDataAdapter("SELECT * FROM GidenMusteri", baglan);
            DataSet dataSet = new DataSet();
            komut.Fill(dataSet, "GidenMusteri");
            komut.Dispose();
            baglan.Close();
            return dataSet.Tables["GidenMusteri"];
        }
        public void YoneticiKayit(Kullanici kullanici)
        {
            SqlConnection baglan = Baglantı();
            SqlCommand komut = new SqlCommand("INSERT INTO Calisan ( k_adi , k_sifre, calisan_tur) VALUES ('" + kullanici.kAdi + "','" + kullanici.kSifre + "','" + 1 + "')", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
        }
        public void CalisanKayit(Kullanici kullanici)
        {
            SqlConnection baglan = Baglantı();
            SqlCommand komut = new SqlCommand("INSERT INTO Calisan ( k_adi , k_sifre,calisan_tur) VALUES ('" + kullanici.kAdi + "','" + kullanici.kSifre + "','" + 0 + "')", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
        }
        public bool CheckYoneticiKullanici(int kadi)
        {
            SqlConnection baglan = Baglantı();
            SqlCommand kmt = new SqlCommand("SELECT * FROM Calisan WHERE  k_adi ='" + kadi + "' ", baglan);
            SqlDataReader read = kmt.ExecuteReader();
            if (read.HasRows)
            {
                baglan.Close();
                return false;
            }
            baglan.Close();
            return true;
        }
        public bool CheckCalisanKullanici2(string kadi, string ksifre, int calisanTur)
        {
            SqlConnection baglan = Baglantı();
            SqlCommand kmt = new SqlCommand("SELECT * FROM Calisan WHERE k_adi ='" + kadi + "' and k_sifre = '" + ksifre + "' and calisan_tur = '" + calisanTur + "' ", baglan);
            SqlDataReader read = kmt.ExecuteReader();
            if (read.HasRows)
            {
                baglan.Close();
                return false;
            }
            baglan.Close();
            return true;
        }
    }
}
