using System;
using System.Collections.Generic;
using System.Text;

namespace RestoranProjesi
{
    public class Masa
    {
        public int MasaNo;
        public bool doluMu = false;
        public int kisiSayisi;
        public double masaHesabı;

        public List<Siparis> siparisler = new List<Siparis>();
    }
}
