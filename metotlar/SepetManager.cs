using System;
using System.Collections.Generic;
using System.Text;

namespace metotlar
{
    class SepetManager
    {
        //naming convention
        //SYTAX


        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler, Sepete Eklendi : " + urun.Adi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int StokAdedi)
        {
            Console.WriteLine("Tebrikler, Sepete eklendi : " + urunAdi);
        }

    }


  
}
