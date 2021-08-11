
namespace HaliYikama
{
    partial class GelirGider
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
            this.grdSilinenMusteri = new System.Windows.Forms.DataGridView();
            this.grdGelirListesi = new System.Windows.Forms.DataGridView();
            this.btnGeri = new System.Windows.Forms.Button();
            this.lblToplamGelir = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMusteriSayisi = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSilinenSayisi = new System.Windows.Forms.Label();
            this.lblGider = new System.Windows.Forms.Label();
            this.gbSilinen = new System.Windows.Forms.GroupBox();
            this.gbGelir = new System.Windows.Forms.GroupBox();
            this.gbText = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblToplamGider = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdSilinenMusteri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdGelirListesi)).BeginInit();
            this.gbSilinen.SuspendLayout();
            this.gbGelir.SuspendLayout();
            this.gbText.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdSilinenMusteri
            // 
            this.grdSilinenMusteri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSilinenMusteri.Location = new System.Drawing.Point(6, 56);
            this.grdSilinenMusteri.Name = "grdSilinenMusteri";
            this.grdSilinenMusteri.RowHeadersWidth = 51;
            this.grdSilinenMusteri.RowTemplate.Height = 29;
            this.grdSilinenMusteri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdSilinenMusteri.Size = new System.Drawing.Size(466, 423);
            this.grdSilinenMusteri.TabIndex = 0;
            // 
            // grdGelirListesi
            // 
            this.grdGelirListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdGelirListesi.Location = new System.Drawing.Point(6, 56);
            this.grdGelirListesi.Name = "grdGelirListesi";
            this.grdGelirListesi.RowHeadersWidth = 51;
            this.grdGelirListesi.RowTemplate.Height = 29;
            this.grdGelirListesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdGelirListesi.Size = new System.Drawing.Size(465, 423);
            this.grdGelirListesi.TabIndex = 1;
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(12, 12);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(94, 219);
            this.btnGeri.TabIndex = 3;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // lblToplamGelir
            // 
            this.lblToplamGelir.AutoSize = true;
            this.lblToplamGelir.Location = new System.Drawing.Point(476, 126);
            this.lblToplamGelir.Name = "lblToplamGelir";
            this.lblToplamGelir.Size = new System.Drawing.Size(15, 20);
            this.lblToplamGelir.TabIndex = 4;
            this.lblToplamGelir.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Toplam Gelir";
            // 
            // lblMusteriSayisi
            // 
            this.lblMusteriSayisi.AutoSize = true;
            this.lblMusteriSayisi.Location = new System.Drawing.Point(476, 36);
            this.lblMusteriSayisi.Name = "lblMusteriSayisi";
            this.lblMusteriSayisi.Size = new System.Drawing.Size(15, 20);
            this.lblMusteriSayisi.TabIndex = 7;
            this.lblMusteriSayisi.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Toplam Müşteri Sayısı";
            // 
            // lblSilinenSayisi
            // 
            this.lblSilinenSayisi.AutoSize = true;
            this.lblSilinenSayisi.Location = new System.Drawing.Point(476, 81);
            this.lblSilinenSayisi.Name = "lblSilinenSayisi";
            this.lblSilinenSayisi.Size = new System.Drawing.Size(15, 20);
            this.lblSilinenSayisi.TabIndex = 13;
            this.lblSilinenSayisi.Text = "-";
            // 
            // lblGider
            // 
            this.lblGider.AutoSize = true;
            this.lblGider.Location = new System.Drawing.Point(260, 81);
            this.lblGider.Name = "lblGider";
            this.lblGider.Size = new System.Drawing.Size(147, 20);
            this.lblGider.TabIndex = 12;
            this.lblGider.Text = "Silinen Müşteri Sayısı";
            // 
            // gbSilinen
            // 
            this.gbSilinen.Controls.Add(this.grdSilinenMusteri);
            this.gbSilinen.Location = new System.Drawing.Point(498, 237);
            this.gbSilinen.Name = "gbSilinen";
            this.gbSilinen.Size = new System.Drawing.Size(478, 485);
            this.gbSilinen.TabIndex = 14;
            this.gbSilinen.TabStop = false;
            this.gbSilinen.Text = "Silinenler Tablosu";
            // 
            // gbGelir
            // 
            this.gbGelir.Controls.Add(this.grdGelirListesi);
            this.gbGelir.Location = new System.Drawing.Point(12, 237);
            this.gbGelir.Name = "gbGelir";
            this.gbGelir.Size = new System.Drawing.Size(480, 485);
            this.gbGelir.TabIndex = 15;
            this.gbGelir.TabStop = false;
            this.gbGelir.Text = "Gelir Tablosu";
            // 
            // gbText
            // 
            this.gbText.Controls.Add(this.label2);
            this.gbText.Controls.Add(this.lblToplamGider);
            this.gbText.Controls.Add(this.lblSilinenSayisi);
            this.gbText.Controls.Add(this.lblGider);
            this.gbText.Controls.Add(this.lblMusteriSayisi);
            this.gbText.Controls.Add(this.label3);
            this.gbText.Controls.Add(this.label1);
            this.gbText.Controls.Add(this.lblToplamGelir);
            this.gbText.Location = new System.Drawing.Point(112, 12);
            this.gbText.Name = "gbText";
            this.gbText.Size = new System.Drawing.Size(858, 219);
            this.gbText.TabIndex = 23;
            this.gbText.TabStop = false;
            this.gbText.Text = "Genel Bilgiler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Toplam Gider";
            // 
            // lblToplamGider
            // 
            this.lblToplamGider.AutoSize = true;
            this.lblToplamGider.Location = new System.Drawing.Point(476, 171);
            this.lblToplamGider.Name = "lblToplamGider";
            this.lblToplamGider.Size = new System.Drawing.Size(15, 20);
            this.lblToplamGider.TabIndex = 14;
            this.lblToplamGider.Text = "-";
            // 
            // GelirGider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 734);
            this.Controls.Add(this.gbText);
            this.Controls.Add(this.gbGelir);
            this.Controls.Add(this.gbSilinen);
            this.Controls.Add(this.btnGeri);
            this.Name = "GelirGider";
            this.Text = "GelirGider";
            this.Load += new System.EventHandler(this.GelirGider_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdSilinenMusteri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdGelirListesi)).EndInit();
            this.gbSilinen.ResumeLayout(false);
            this.gbGelir.ResumeLayout(false);
            this.gbText.ResumeLayout(false);
            this.gbText.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdSilinenMusteri;
        private System.Windows.Forms.DataGridView grdGelirListesi;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Label lblToplamGelir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMusteriSayisi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblGider;
        private System.Windows.Forms.GroupBox gbSilinen;
        private System.Windows.Forms.GroupBox gbGelir;
        private System.Windows.Forms.Label lblSilinenSayisi;
        private System.Windows.Forms.GroupBox gbText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblToplamGider;
    }
}