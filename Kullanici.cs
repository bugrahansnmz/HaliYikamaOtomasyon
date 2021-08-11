using System;
using System.Collections.Generic;
using System.Text;

namespace HaliYikama
{
    class Kullanici
    {
        public string kAdi { get; set; }
        public string kSifre { get; set; }
        public int calisanTuru { get; set; }
        
        public Kullanici(string k_Adi,string k_Sifre,int calisanturu)
        {
            kAdi = k_Adi;
            kSifre = k_Sifre;
            calisanTuru = calisanturu;
            
        }
    }
}
