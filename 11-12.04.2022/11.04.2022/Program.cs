using System;
using System.Collections.Generic;

namespace _11._04._2022
{

    class Program
    {
        public struct Kisi
        {
            public string adSoyad;
            public int ceptekiPara;

            public Kisi(string d1, int d2)
            {
                this.adSoyad = d1;
                this.ceptekiPara = d2;
            }
        };

        static void Main(string[] args)
        {

            try
            {
                Kisi k1 = new Kisi();

                Kisi k2 = new Kisi();

                Kisi k3 = new Kisi();

                Kisi k4 = new Kisi();

                Kisi k5 = new Kisi();

                Kisi ben = new Kisi("Can Razbonyalı", 200);


                /*sinemaBiletKuyruk.Enqueue(k1);
                sinemaBiletKuyruk.Enqueue(k2);
                sinemaBiletKuyruk.Enqueue(k3);
                sinemaBiletKuyruk.Enqueue(ben);
                sinemaBiletKuyruk.Enqueue(k4);
                sinemaBiletKuyruk.Enqueue(k5);*/


                Kisi[] kisiler = { k1, k2, k3, ben, k4, k5 };
                Queue<Kisi> sinemaBiletKuyruk = new Queue<Kisi>(kisiler);

                while (sinemaBiletKuyruk.Count > 0)
                {
                    Kisi siradakiKisi = sinemaBiletKuyruk.Peek();
                    if (siradakiKisi.adSoyad != null)
                    {
                        siradakiKisi.ceptekiPara -= 50;
                        ben = siradakiKisi;
                    }
                    
                    sinemaBiletKuyruk.Dequeue();
                }

                Console.WriteLine("Sira eridi - ", sinemaBiletKuyruk.Count);

                //string[] kisiler = { "Cem", "Ali", "Cemil" };

                /*
                 ilk giren ilk çıkar - FIFO
                 */
                //kuyruk.Count

                //Queue<string> kuyruk = new Queue<string>();
                //Queue<string> kuyruk2 = new Queue<string>(kisiler);
                //Queue<string> kuyruk3 = new Queue<string>();


                /*Ekleme
                kuyruk.Enqueue("Deneme");
                kuyruk.Enqueue("Deneme2");
                kuyruk.Enqueue("Deneme3");

                Console.WriteLine(kuyruk.Contains("deneme2"));*/

                /*Çıkartma*/
                //Console.WriteLine("Çıkan eleman {0}", kuyruk2.Dequeue());

                /*kuyruk3.Enqueue("Exception");
                if (!(kuyruk3.Count > 0))
                {
                    throw new Exception("Kuyruk boş!");
                }
                Console.WriteLine("Çıkan eleman {0}", kuyruk3.Dequeue());*/

                //kuyruk3.Enqueue(122);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oldu - {0}", ex);
            }

        }
    }
}
