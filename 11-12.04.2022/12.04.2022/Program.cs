using System;
using System.Collections.Generic;

namespace _12._04._2022
{
    class Program
    {
        public struct Kisi
        {
            public string adSoyad;
            public int tckn;
            public int paraMiktar;
            public bool biletVarMi;


            public Kisi(string adSoyad, int tckn, int paraMiktar, bool biletVarMi)
            {
                this.adSoyad = adSoyad;
                this.tckn = tckn;
                this.paraMiktar = paraMiktar;
                this.biletVarMi = biletVarMi;
            }

        };

        static void Main(string[] args)
        {
            /*
                sinema bileti alınmak isteniyor
                önümüzde 3 kişi bulunmakta, iki daha sırada beklerken geldi
                bilet 100TL olduğu kabul ediliyor
             */

            const int biletFiyat = 100;

            Kisi kisi1 = new Kisi();
            Kisi kisi2 = new Kisi();
            Kisi kisi3 = new Kisi();
            Kisi kisi4 = new Kisi();
            Kisi kisi5 = new Kisi();

            Kisi Ben = new Kisi("Can Razbonyalı", 123, 250, false);

            Kisi[] ilkUcKisi = { kisi1, kisi2, kisi3 };

            //ilk üç kişi ile sıra oluştu
            Queue<Kisi> siradakiKisiler = new Queue<Kisi>(ilkUcKisi);

            siradakiKisiler.Enqueue(Ben);

            //tek tek arkamıza gelen kişiler
            siradakiKisiler.Enqueue(kisi4);
            siradakiKisiler.Enqueue(kisi5);

            //Kisi ben = new Kisi();
            //foreach (var herBirKisi in siradakiKisiler) {
            while (siradakiKisiler.Count > 0)
            {
                Kisi herBirKisi = siradakiKisiler.Peek();

                if (herBirKisi.tckn != 0)
                {
                    //ben = herBirKisi;
                    Ben.paraMiktar -= biletFiyat;
                    Ben.biletVarMi = true;
                }

                siradakiKisiler.Dequeue();//biletini alması
            }

            //Console.WriteLine("Cepteki para - {0}", ben.paraMiktar);

            Queue<Kisi> salonGirisSirasi = new Queue<Kisi>(ilkUcKisi);
            if (Ben.biletVarMi)
            {
                salonGirisSirasi.Enqueue(Ben);
            }


            Console.WriteLine("Cepteki para - {0}", Ben.paraMiktar);

        }
    }
}
