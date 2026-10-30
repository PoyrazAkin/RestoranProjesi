namespace RestoranProjesi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Yemek> corbalar = new List<Yemek>();
            List<Yemek> salatalar = new List<Yemek>();
            List<Yemek> makarnalar = new List<Yemek>();
            List<Yemek> etler = new List<Yemek>();
            List<Yemek> baliklar = new List<Yemek>();
            List<Yemek> icecekler = new List<Yemek>();

            Yemek mercimek = new Yemek();
            mercimek.Ad = "Mercimek Corbasi";
            mercimek.Fiyat = 100;
            mercimek.Kategori = "Çorba";

            corbalar.Add(mercimek);

            Yemek ezo = new Yemek();
            ezo.Ad = "Ezogelin Çorbası";
            ezo.Fiyat = 110;
            ezo.Kategori = "Çorba";

            corbalar.Add(ezo);

            Yemek yayla = new Yemek();
            yayla.Ad = "Yayla Çorbası";
            yayla.Fiyat = 115;
            yayla.Kategori = "Çorba";

            corbalar.Add(yayla);

            Yemek coban = new Yemek();
            coban.Ad = "Coban Salatası";
            coban.Fiyat = 100;
            coban.Kategori = "Salata";

            salatalar.Add(coban);

            Yemek mevsim = new Yemek();
            mevsim.Ad = "Mevsim Salatası";
            mevsim.Fiyat = 110;
            mevsim.Kategori = "Salata";

            salatalar.Add(mevsim);

            Yemek sezar = new Yemek();
            sezar.Ad = "Sezar Salatası";
            sezar.Fiyat= 115;
            sezar.Kategori = "Salata";

            salatalar.Add(sezar);

            Yemek spagetti = new Yemek();
            spagetti.Ad = "Spagetti";
            spagetti.Fiyat = 300;
            spagetti.Kategori = "Makarna";

            makarnalar.Add(spagetti);

            Yemek fırınMakarna = new Yemek();
            fırınMakarna.Ad = "Fırın Makarna";
            fırınMakarna.Fiyat = 320;
            fırınMakarna.Kategori = "Makarna";

            makarnalar.Add(fırınMakarna);

            Yemek kıymalıMakarna = new Yemek();
            kıymalıMakarna.Ad = "Kıymalı Makarna";
            kıymalıMakarna.Fiyat = 330;
            kıymalıMakarna.Kategori = "Makarna";

            makarnalar.Add(kıymalıMakarna);

            Yemek kofte = new Yemek();
            kofte.Ad = "Kofte";
            kofte.Fiyat = 400;
            kofte.Kategori = "Et";

            etler.Add(kofte);

            Yemek pirzola = new Yemek();
            pirzola.Ad = "Pirzola";
            pirzola.Fiyat = 500;
            pirzola.Kategori = "Et";

            etler.Add(pirzola);

            Yemek kanat = new Yemek();
            kanat.Ad = "Kanat";
            kanat.Fiyat = 350;
            kanat.Kategori = "Et";

            etler.Add(kanat);

            Yemek hamsi = new Yemek();
            hamsi.Ad = "Hamsi";
            hamsi.Fiyat = 300;
            hamsi.Kategori = "Balik";

            baliklar.Add(hamsi);

            Yemek somon = new Yemek();
            somon.Ad = "Somon";
            somon.Fiyat = 700;
            somon.Kategori = "Balik";

            baliklar.Add(somon);

            Yemek lufer = new Yemek();
            lufer.Ad = "Lufer";
            lufer.Fiyat = 600;
            lufer.Kategori = "Balik";

            baliklar.Add(lufer);

            Yemek raki = new Yemek();
            raki.Ad = "Rakı";
            raki.Fiyat = 3000;
            raki.Kategori = "İcecek";

            icecekler.Add(raki);

            Yemek kola = new Yemek();
            kola.Ad = "Kola";
            kola.Fiyat = 220;
            kola.Kategori = "İcecek";

            icecekler.Add(kola);

            Yemek su = new Yemek();
            su.Ad = "Su";
            su.Fiyat = 200;
            su.Kategori = "İcecekler";

            icecekler.Add(su);

            List<Masa> masalar = new List<Masa>();

            for (int i = 1; i <= 5; i++)
            {
                Masa yeniMasa = new Masa();
                yeniMasa.MasaNo = i;
                masalar.Add(yeniMasa);
            }

            while(true)
            {
                anaMenu();

                Console.WriteLine("Seçiminizi yapınız");
                string secim = Console.ReadLine();

                switch(secim)
                {
                    case "1":
                        siparisAl(masalar,corbalar,salatalar,makarnalar,etler,baliklar,icecekler);
                        break;

                    case "2":
                        hesapAl(masalar);
                        break;

                    case "3":
                        masaDurumu(masalar);
                        break;

                    case "4":
                        zRaporu();
                        break;

                    case "5":
                        Console.WriteLine("Çıkış");
                        return;

                    default:
                        Console.WriteLine("Hatalı seçim");
                        break;
                }
            }
        }

        static void anaMenu()
        {
            Console.WriteLine("1-Siparis al");
            Console.WriteLine("2-Hesap al");
            Console.WriteLine("3-Masa durumu");
            Console.WriteLine("4-Z raporu al");
            Console.WriteLine("5-Çıkış");
        }

        static void zRaporu()
        {
            Console.WriteLine("---GÜNLÜK Z RAPORU---");
            Console.WriteLine("Toplam kazanç: " + gunlukKazanc + " TL");
        }

        static void masaDurumu(List<Masa> masalar)
        {
            foreach (Masa masa in masalar)
            {
                if (masa.doluMu == true)
                {
                    Console.WriteLine(masa.MasaNo + ". Masa dolu - " + masa.kisiSayisi + " kişi - " +
                    masa.masaHesabı + " TL");
                }
                else
                {
                    Console.WriteLine(masa.MasaNo + ". Masa Boş");
                }
            }
        }
        static double gunlukKazanc = 0;
        static void hesapAl(List<Masa> masalar)
        {
            Console.WriteLine("Hesabı alınacak masa numarası:");
            int masaNo = Convert.ToInt32(Console.ReadLine());

            foreach (Masa masa in masalar)
            {
                if (masa.MasaNo == masaNo && masa.doluMu == true)
                {
                    Console.WriteLine("---HESAP DETAYI---");

                    foreach (Siparis siparis in masa.siparisler)
                    {
                        Console.WriteLine(siparis.yemekAdı + " x " + siparis.adet + " = " + siparis.adet * siparis.fiyat + " TL");
                    }

                    Console.WriteLine("Toplam: " + masa.masaHesabı + " TL");

                    Console.WriteLine("Ödeme alındı mı? (E/H)");
                    string cevap = Console.ReadLine().ToUpper();

                    if (cevap == "E")
                    {
                        gunlukKazanc += masa.masaHesabı;

                        masa.masaHesabı = 0;
                        masa.kisiSayisi = 0;
                        masa.doluMu = false;
                        masa.siparisler.Clear();

                        Console.WriteLine("Ödeme alındı. Masa boşaltıldı.");
                    }

                    return;
                }
            }

            Console.WriteLine("Masa bulunamadı veya boş.");
        }

        static void siparisAl(List<Masa> masalar,List<Yemek> corbalar, List<Yemek> salatalar, List<Yemek> makarnalar, List<Yemek> etler, List<Yemek> baliklar, List<Yemek> icecekler)
        {
            Console.WriteLine("---SİPARİS ALMA---");

            foreach(Masa masa in masalar)
            {
                if(masa.doluMu == false)
                {
                    Console.WriteLine(masa.MasaNo + ". masa" + " boş");
                }
            }

            Console.WriteLine("Masa numarası seçiniz");
            int masaNo = Convert.ToInt32(Console.ReadLine());

            Masa secilenMasa = null;

            foreach(Masa masa in masalar)
            {
                if(masa.MasaNo == masaNo)
                {
                    secilenMasa = masa;
                    break;
                }
            }

            if(secilenMasa == null)
            {
                Console.WriteLine("Geçersiz masa numarası");
                return;
            }

            Console.WriteLine("Seçilen masa: " + secilenMasa.MasaNo);

            if (secilenMasa.doluMu == false)
            {
                Console.WriteLine("Kaç kişi oturacak?");
                int kisiSayisi = Convert.ToInt32(Console.ReadLine());

                if (kisiSayisi < 1 || kisiSayisi > 5)
                {
                    Console.WriteLine("Bir masaya en fazla 5 kişi oturabilir.");
                    return;
                }

                secilenMasa.kisiSayisi = kisiSayisi;
                secilenMasa.doluMu = true;
            }

            while (true)
            {
                Console.WriteLine("Yemek Kategorisi");
                Console.WriteLine("1-Çorbalar");
                Console.WriteLine("2-Salatalar");
                Console.WriteLine("3-Makarnalar");
                Console.WriteLine("4-Etler");
                Console.WriteLine("5-Balıklar");
                Console.WriteLine("6-İçecekler");
                Console.WriteLine("0-Ana Menü");

                Console.WriteLine("Kategori seçiniz");
                string kategoriSecim = Console.ReadLine();

                int numara = 1;

                List<Yemek> secilenKategori = new List<Yemek>();

                switch (kategoriSecim)
                {
                    case "1":
                        secilenKategori = corbalar;

                        foreach (Yemek yemek in corbalar)
                        {
                            Console.WriteLine(numara + "-" + yemek.Ad + " " + yemek.Fiyat + " TL");
                            numara++;
                        }
                        break;

                    case "2":
                        secilenKategori = salatalar;

                        foreach (Yemek yemek in salatalar)
                        {
                            Console.WriteLine(numara + "-" + yemek.Ad + " " + yemek.Fiyat + " TL");
                            numara++;
                        }
                        break;

                    case "3":
                        secilenKategori = makarnalar;

                        foreach (Yemek yemek in makarnalar)
                        {
                            Console.WriteLine(numara + "-" + yemek.Ad + " " + yemek.Fiyat + " TL");
                            numara++;
                        }
                        break;

                    case "4":
                        secilenKategori = etler;

                        foreach (Yemek yemek in etler)
                        {
                            Console.WriteLine(numara + "-" + yemek.Ad + " " + yemek.Fiyat + " TL");
                            numara++;
                        }
                        break;

                    case "5":
                        secilenKategori = baliklar;

                        foreach (Yemek yemek in baliklar)
                        {
                            Console.WriteLine(numara + "-" + yemek.Ad + " " + yemek.Fiyat + " TL");
                            numara++;
                        }
                        break;

                    case "6":
                        secilenKategori = icecekler;

                        foreach (Yemek yemek in icecekler)
                        {
                            Console.WriteLine(numara + "-" + yemek.Ad + " " + yemek.Fiyat + " TL");
                            numara++;
                        }
                        break;

                    case "0":
                        return;
                }

                if (secilenKategori.Count == 0)
                {
                    continue;
                }

                Console.WriteLine("Yemek numarasını giriniz:");
                int yemekNo = Convert.ToInt32(Console.ReadLine());

                if (yemekNo < 1 || yemekNo > secilenKategori.Count)
                {
                    Console.WriteLine("Geçersiz yemek numarası");
                    continue;
                }

                Yemek secilenYemek = secilenKategori[yemekNo - 1];

                Console.WriteLine("Seçilen yemek: " + secilenYemek.Ad);
                Console.WriteLine("Fiyatı: " + secilenYemek.Fiyat + " TL");

                Console.WriteLine("Kaç adet istiyorsunuz?");
                int adet = Convert.ToInt32(Console.ReadLine());

                if (adet <= 0)
                {
                    Console.WriteLine("En az 1 adet seçmelisiniz.");
                    continue;
                }

                Siparis yeniSiparis = new Siparis();

                yeniSiparis.yemekAdı = secilenYemek.Ad;
                yeniSiparis.adet = adet;
                yeniSiparis.fiyat = secilenYemek.Fiyat;

                secilenMasa.siparisler.Add(yeniSiparis);

                double tutar = adet * secilenYemek.Fiyat;

                secilenMasa.masaHesabı += tutar;

                Console.WriteLine("Sipariş başarıyla eklendi.");
                Console.WriteLine("Sipariş tutarı: " + tutar + " TL");
                Console.WriteLine("Masanın toplam hesabı: " + secilenMasa.masaHesabı + " TL");

                Console.WriteLine("Başka sipariş vermek istiyor musunuz? (E/H)");
                string cevap = Console.ReadLine().ToUpper();

                if (cevap == "H")
                {
                    break;
                }
            }
        }
    }
}
