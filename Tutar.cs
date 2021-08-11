using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HaliYikama
{
    public partial class Tutar : Form
    {
        Musteri musteri;
        int id;
        public Tutar(Musteri musteri,int id)
        {
            this.musteri = musteri;
            this.id = id;
            InitializeComponent();
            MusteriBilgi();
        }
        DataBase data;

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Müşteri_İşlem m = new Müşteri_İşlem();
            this.Visible = false;
            m.ShowDialog();
            this.Visible = true;
        }
        private void MusteriBilgi()
        {
            lblMusteriAdi.Text = musteri.MusteriAdi;
            lblMusteriSoyadi.Text = musteri.MusteriSoyadi;
            lblTelefon.Text = musteri.Telefon;
            lblKayitTarihi.Text = Convert.ToString(musteri.KayitTarihi);
            lblCikisTarihi.Text = Convert.ToString(musteri.TahminiCikisTarihi);
            lblHaliAdet.Text = Convert.ToString(musteri.HaliAdet);
            lblHaliMt2.Text = Convert.ToString(musteri.HaliMt2);
            lblFiyat.Text = string.Format("{0:C}", (Convert.ToDecimal(musteri.HaliMt2) * Convert.ToDecimal(musteri.Fiyat)) / 10);


        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            
            data = new DataBase();
            string a = string.Format("{0:C}", (Convert.ToDecimal(musteri.HaliMt2) * Convert.ToDecimal(musteri.Fiyat)) / 10);
            data.CikanMusteri(id,a);
            if (true)
            {

            }
            Müşteri_İşlem m = new Müşteri_İşlem();
            this.Visible = false;
            m.ShowDialog();
            this.Visible = true;

        }
    }
}
