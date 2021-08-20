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

    public partial class Müşteri_İşlem : Form
    {
        public Müşteri_İşlem()
        {
            InitializeComponent();
        }
        DataBase data;
        private void Müşteri_İşlem_Load(object sender, EventArgs e)
        {
            data = new DataBase();
            lblCalisanAdi.Text = Giris.ad;
            lblCalisanSifre.Text = Giris.sifre;
            lblCalisanTrueFalse.Text = Convert.ToString(Giris.TrueFalse);
            if (lblCalisanTrueFalse.Text == "1")
            {
                btnGelirGider.Enabled = true;
            }
            cbFiyatSec.SelectedItem = 3.5;
            cbFiyatSec.SelectedText = "3.5";
            ObjeEnabledFalse();
            btnAra_Click(null, null);
            MusteriSayisi();
            Listele();
        }
        private void btnYenikayit_Click(object sender, EventArgs e)
        {
            ObjeEnabledTrue();
            if (tbMusteriAdi.Text != null || tbMusteriSoyadi.Text != null || tbTelefon.Text != null || tbAdres.Text != null || tbAciklama.Text != null )
            {
                Clear();
                btnKaydet.Enabled = true;
                Listele();
            }
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (tbMusteriAdi.Text != "" && tbMusteriSoyadi.Text != "" && tbTelefon.Text != "" && tbHaliAdet.Text != "" && cbFiyatSec.SelectedIndex == -1)
            {
                MessageBox.Show("Alanlar Boş.");
            }
            else
            {
                ObjeEnabledFalse();
                data = new DataBase();
                Musteri m = new Musteri(tbMusteriAdi.Text, tbMusteriSoyadi.Text, tbTelefon.Text, tbAdres.Text, tbAciklama.Text, cbBolge.Text, Convert.ToInt32(tbHaliAdet.Text), dtpKayitTarihi.Value, dtpCikisTarihi.Value, Convert.ToString(tbHaliMt2.Text), Convert.ToString(cbFiyatSec.SelectedItem));
                if (data.CheckMusteri(m.Telefon))
                {
                    data.InsertMusteri(m);
                    btnAra_Click(null, null);
                    btnKaydet.Enabled = false;
                    Listele();
                    Clear();
                }
                else
                {
                    MessageBox.Show("Telefon numarası sisteme kayıtlıdır.Lütfen verilerinizi tekrar kontrol ederek tekrar deneyiniz.");
                    btnKaydet.Enabled = true;
                    ObjeEnabledTrue();
                    Listele();
                }
            }
        }
        private void btnListele_Click(object sender, EventArgs e)
        {
            Listele();
        }
        private void btnAra_Click(object sender, EventArgs e)
        {
            string a = tbMusteriAdi.Text;
            string s = tbMusteriSoyadi.Text;
            string t = tbTelefon.Text;
            grdMusteriListesi.DataSource = data.MusteriAra(a,s,t);
        }
        private void grdMusteriListesi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tbMusteriAdi.Text != "" && tbMusteriSoyadi.Text != "" && tbTelefon.Text != "" && tbHaliAdet.Text != "" &&  cbFiyatSec.SelectedIndex == -1)
            {
                MessageBox.Show("Alanlar Boş.");
            }
            else
            {
                int id = Convert.ToInt32(grdMusteriListesi.CurrentRow.Cells[2].Value.ToString());
                Musteri m = new Musteri(tbMusteriAdi.Text, tbMusteriSoyadi.Text, tbTelefon.Text, tbAdres.Text, tbAciklama.Text, cbBolge.Text, Convert.ToInt32(tbHaliAdet.Text), dtpKayitTarihi.Value, dtpCikisTarihi.Value, Convert.ToString(tbHaliMt2.Text), Convert.ToString(cbFiyatSec.SelectedItem));
                Tutar tutar = new Tutar(m, id);
                this.Visible = false;
                tutar.ShowDialog();
                this.Visible = true;
            }
        }
        private void grdMusteriListesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            grdMusteriListesi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            if (e.ColumnIndex == 0) 
            {
                MessageBox.Show("Silindi.");
                int a = Convert.ToInt32(grdMusteriListesi.CurrentRow.Cells[2].Value.ToString());
                data = new DataBase();
                data.DeleteMusteri(a);
                Listele();
            }
            if (e.ColumnIndex== 1)
            {
                if (tbMusteriAdi.Text != "" && tbMusteriSoyadi.Text != "" && tbTelefon.Text != "" && tbHaliAdet.Text != "" )
                {
                    int b = Convert.ToInt32(grdMusteriListesi.CurrentRow.Cells[2].Value.ToString());
                    data = new DataBase();
                    Musteri m = new Musteri(tbMusteriAdi.Text, tbMusteriSoyadi.Text, tbTelefon.Text, tbAdres.Text, tbAciklama.Text, cbBolge.Text, Convert.ToInt32(tbHaliAdet.Text), dtpKayitTarihi.Value, dtpCikisTarihi.Value, Convert.ToString(tbHaliMt2.Text), Convert.ToString(cbFiyatSec.SelectedItem));
                    if (data.CheckMusteri(m.Telefon, b))
                    {
                        data.UpdateMusteri(m, b);
                        btnAra_Click(null, null);
                        btnKaydet.Enabled = false;
                        Listele();
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Telefon numarası sisteme kayıtlıdır.Lütfen verilerinizi tekrar kontrol ederek tekrar deneyiniz.");
                        btnKaydet.Enabled = true;
                        ObjeEnabledTrue();
                        Listele();
                    }
                 
                }
                else
                {
                    MessageBox.Show("Dikkat!");
                }

            }
            if (grdMusteriListesi.CurrentRow != null && grdMusteriListesi.CurrentRow.Selected)
            {
                btnKaydet.Enabled = true;
                ObjeEnabledTrue();
                data = new DataBase();
                SqlCommand kmt = new SqlCommand("select * from Musteri where ID = @1 ", data.Baglantı());
                kmt.Parameters.AddWithValue("@1", grdMusteriListesi.CurrentRow.Cells[2].Value.ToString());
                SqlDataReader dr = kmt.ExecuteReader();
                while (dr.Read())
                {
                    tbMusteriAdi.Text = grdMusteriListesi.CurrentRow.Cells[3].Value.ToString();
                    tbMusteriSoyadi.Text = grdMusteriListesi.CurrentRow.Cells[4].Value.ToString();
                    tbTelefon.Text = grdMusteriListesi.CurrentRow.Cells[5].Value.ToString();
                    cbBolge.Text = grdMusteriListesi.CurrentRow.Cells[6].Value.ToString();
                    tbAdres.Text = grdMusteriListesi.CurrentRow.Cells[7].Value.ToString();
                    tbAciklama.Text = grdMusteriListesi.CurrentRow.Cells[8].Value.ToString();
                    tbHaliAdet.Text = grdMusteriListesi.CurrentRow.Cells[10].Value.ToString();
                    tbHaliMt2.Text = grdMusteriListesi.CurrentRow.Cells[12].Value.ToString();
                    string gelenFiyat = string.Format("{0:F}",grdMusteriListesi.CurrentRow.Cells[13].Value);
                    string fiyat = gelenFiyat.Substring(1, gelenFiyat.Length - 1);
                    string  haliMt2 = grdMusteriListesi.CurrentRow.Cells[12].Value.ToString();
                    decimal sonFiyat = (Convert.ToDecimal(fiyat) / Convert.ToDecimal(haliMt2));
                    cbFiyatSec.Text = string.Format("{0:0}", sonFiyat);
                    // String.Format("{0:0.0}", Convert.ToDouble(grdMusteriListesi.CurrentRow.Cells[13].Value) / Convert.ToDouble(grdMusteriListesi.CurrentRow.Cells[12].Value));
                }
                dr.Close();
            }
        }
        private void MusteriSayisi()
        {
           grdMusteriListesi.DataSource = data.Listele();
           label11.Text = grdMusteriListesi.Rows.Count.ToString();
        }
        private void Clear()
        {
            tbMusteriAdi.Clear();
            tbMusteriSoyadi.Clear();
            tbTelefon.Clear();
            tbAdres.Clear();
            tbAciklama.Clear();
            tbHaliAdet.Clear();
            tbHaliMt2.Clear();
        }
        private void Listele()
        {
            grdMusteriListesi.DataSource = data.Listele();
        }
        private void ObjeEnabledFalse()
        {
            dtpKayitTarihi.Enabled = false;
            tbMusteriAdi.Enabled = false;
            tbMusteriSoyadi.Enabled = false;
            tbTelefon.Enabled = false;
            tbAdres.Enabled = false;
            tbAciklama.Enabled = false;
            cbBolge.Enabled = false;
            tbHaliAdet.Enabled = false;
            dtpCikisTarihi.Enabled = false;
            tbHaliMt2.Enabled = false;
            cbFiyatSec.Enabled = false;
        }
        private void ObjeEnabledTrue()
        { 
            tbMusteriAdi.Enabled = true;
            tbMusteriSoyadi.Enabled = true;
            tbTelefon.Enabled = true;
            tbAdres.Enabled = true;
            tbAciklama.Enabled = true;
            cbBolge.Enabled = true;
            tbHaliAdet.Enabled = true;
            dtpCikisTarihi.Enabled = true;
            tbHaliMt2.Enabled = true;
            cbFiyatSec.Enabled = true;
        }
        private void tbHaliMt2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }
        private void tbHaliMt2_Leave(object sender, EventArgs e)
        {
            float para;
            para = float.Parse(tbHaliMt2.Text);
            tbHaliMt2.Text = para.ToString("N");
        }
        private void btnGelirGider_Click(object sender, EventArgs e)
        {
            GelirGider gelir = new GelirGider();
            this.Visible = false;
            gelir.ShowDialog();
            this.Visible = true;
        }

        private void btnHesapCikis_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            this.Visible = false;
            giris.ShowDialog();
            this.Visible = true;
        }
    }
}
