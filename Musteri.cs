using System;
using System.Collections.Generic;
using System.Text;

namespace HaliYikama
{
   public class Musteri
    {
        public string MusteriAdi { get; set; }
        public string MusteriSoyadi { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
        public string Aciklama { get; set; }
        public string Bolge { get; set; }
        public int HaliAdet { get; set; }
        public string HaliMt2 { get; set; }
        public DateTime KayitTarihi { get; set; }
        public DateTime TahminiCikisTarihi { get; set; }
        public string Fiyat { get; set; }
        public Musteri(string musteriAdi, string musteriSoyadi, string telefon, string adres, string aciklama, string bolge, int haliAdet, DateTime kayitTarihi,DateTime tahminiCikisTarihi, string haliMt2, string fiyat)
        {
            MusteriAdi = musteriAdi;
            MusteriSoyadi = musteriSoyadi;
            Telefon = telefon;
            Adres = adres;
            Aciklama = aciklama;
            Bolge = bolge;
            HaliAdet = haliAdet;
            KayitTarihi = kayitTarihi;
            TahminiCikisTarihi = tahminiCikisTarihi;
            HaliMt2 = haliMt2;
            Fiyat = fiyat;
        }
    }
}
