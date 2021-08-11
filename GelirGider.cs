using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HaliYikama
{
    public partial class GelirGider : Form
    {
        public GelirGider()
        {
            InitializeComponent();
        }
        DataBase data;
        private void GelirGider_Load(object sender, EventArgs e)
        {
           data = new DataBase();
           ToplamGelir();
           GelirListele();
           ToplamMusteriSayisi();
           SilinenMusteriSayisi();
           GiderHesap(); 
        }
        public void GelirListele()
        {
                grdGelirListesi.DataSource = data.GelirListele();
        }
        private void btnGeri_Click(object sender, EventArgs e)
        {
            Müşteri_İşlem musteri = new Müşteri_İşlem();
            this.Visible = false;
            musteri.ShowDialog();
            this.Visible = true;
        }
        private void ToplamGelir()
        {
            grdGelirListesi.DataSource = data.GelirListele();
            double toplam = 0;
            for (int i = 0; i < grdGelirListesi.Rows.Count-1; i++)
            {
                string gelenFiyat = string.Format("{0:F}", grdGelirListesi.Rows[i].Cells[5].Value);
                string fiyat = gelenFiyat.Substring(1, gelenFiyat.Length - 1);
                toplam += Convert.ToDouble(fiyat);
            }
            lblToplamGelir.Text = Convert.ToString(toplam);
        }
        private void ToplamMusteriSayisi()
        {
            grdGelirListesi.DataSource = data.GelirListele();
            lblMusteriSayisi.Text = grdGelirListesi.Rows.Count.ToString();

        }
        private void SilinenMusteriSayisi()
        {
            grdSilinenMusteri.DataSource = data.SilinenListele();
            lblSilinenSayisi.Text = grdSilinenMusteri.Rows.Count.ToString();

        }
        private void GiderHesap()
        {
            int toplam = 0;
            grdGelirListesi.DataSource = data.GelirListele();
            for (int i = 0; i < grdGelirListesi.Rows.Count-1; i++)
            {
                string gelenAdet = grdGelirListesi.Rows[i].Cells[4].Value.ToString();
                toplam += Convert.ToInt32(gelenAdet);
            }
            lblToplamGider.Text = (toplam * 3,5).ToString();
            
        }
    }
}
