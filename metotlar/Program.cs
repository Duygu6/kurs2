using System;

namespace metotlar
{
    class Urun
    {
        static void Main(string[] args)
        {  
            string UrunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";

            string[] meyveler = new string[] { "elma,karpuz" };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.fiyati = 15;
            urun1.aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.fiyati = 80;
            urun2.aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine("urun.Adi");
                Console.WriteLine("urun.fiyati");
                Console.WriteLine("urun.aciklama");
                Console.WriteLine("------------");
            }

            Console.WriteLine("----metotlar-----");
            //instance - örnek
            //array dizi
            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil Armut", 12, 10);
            sepetManager.Ekle2("Elma", "Yeşil elma", 12, 9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12, 8);

                

        }

    }
}


//dont repeat yourself - DRY - clean code - best practice