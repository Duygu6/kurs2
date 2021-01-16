using System;

namespace kurs2
{
   
            class Program
        {
            static void Main(string[] args)

            {
                urunler urunler1 = new urunler();
                urunler1.urunadi = "Bilgisayar";
                urunler1.urunfiyati = 30;

                urunler urunler2 = new urunler();
                urunler2.urunadi = "Tablet";
                urunler2.urunfiyati = 20;

                urunler urunler3 = new urunler();
                urunler3.urunadi = "Telefon";
                urunler3.urunfiyati = 10;


                urunler[] urunlerabc = new urunler[] { urunler1, urunler2, urunler3 };
                //for
                Console.WriteLine("for");
                for (int i = 0; i < urunlerabc.Length; i++)
                {
                    Console.WriteLine(urunlerabc[i].urunadi + " : " + urunlerabc[i].urunfiyati);
                }

                Console.WriteLine("foreach");
                //foreach
                foreach (var urunler in urunlerabc)
                {
                    Console.WriteLine(urunler.urunadi + " : " + urunler.urunfiyati);
                }

                Console.WriteLine("while");

                //while

                int y = 0;
                while (y < urunlerabc.Length) ;
                {
                    Console.WriteLine(urunlerabc[y].urunadi);
                    Console.WriteLine(urunlerabc[y].urunfiyati);

                    int i = y++;
                }
            }


            class urunler
            {
                public string urunadi { get; set; }
                public int urunfiyati { get; set; }

            }

        }
    }


    

