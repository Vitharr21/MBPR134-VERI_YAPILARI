using System;
using System.Collections;
using System.Collections.Generic;

/**
 * Kırmızı, mavi, sarı renklerinde; büyük ve küçük ölçülerine sahip, üç adet büyük kırmızı, altı 
 * adet küçük mavi ve dört adet küçük sarı bilyeleri bir torbada saklamak istiyorsunuz
 * (bilyeler struct ya da sınıf, torba da ders süresince işlenen veri yapıları ile temsil edilmeli). 
 *   Yukarıda belirtilen senaryoyu gerçekleştirip, 
 * sizlerden bilyelerin hepsi torbaya doldurulana kadar hangi bilyeden kaç tane torbaya koymanızı istediğinizi bekleyen 
 * programı C# programlama dili ile geliştiriniz (40 p). 
•	Hangi veri yapısını, neden kullanmayı tercih ettiğinizi açıklama satırında belirtmelisiniz.
•	Giriş yapacak kişi, torbaya bir seferde on üç adet küçük, mavi toplardan (bu diğer bilyeler için de genişletilebilir) yani, 
olmaması gereken bir durum gerçekleştirilmeye çalışabilir. Bu durumların kontrol edilip, anlamlı bir mesaj ile kullanıcının bilgilendirilmesi gerekir.

 */

namespace Soru2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Saklanmak istenen torbanın ağzı, bütün bilyeleri bir seferde içerisine koyabilecek kadar geniş olmamak ile birlikte, 
            *bir tane büyük ya da iki tane küçük bilye alabilecek kadar geniştir.*/

            Stack initDegerler = initProgram();

            Queue gTorba = (Queue)initDegerler.Pop(); //casting
            ArrayList gMasa = (ArrayList)initDegerler.Pop();
            Dictionary<string, int> gBilgi = (Dictionary<string, int>)initDegerler.Pop();

            while (gMasa.Count > 0)
            {
                string input = "";
                Console.WriteLine("Kaç adet hangi toptan koymak istiyorsunuz - büyüklük renk adet");
                input = Console.ReadLine();
                string[] inputArray = input.Split(" ");
                string bilyeGirdi = Cozumle(inputArray);


                if (gBilgi.ContainsKey(bilyeGirdi))
                {
                    Bilye cikacakEleman = null;

                    if (bilyeGirdi[0] == 'b' && Convert.ToInt32(inputArray[2]) > 1)
                    {
                        Console.WriteLine("Bir seferde iki büyük top alamaz...");
                    }
                    else if (bilyeGirdi[0] == 'k' && Convert.ToInt32(inputArray[2]) > 2)
                    {
                        Console.WriteLine("Bir seferde en fazla iki küçük top alabilir...");
                    }
                    else
                    {
                        for (int i = 0; i < Convert.ToInt32(inputArray[2]); i++)
                        {
                            foreach (Bilye eleman in gMasa)
                            {
                                if (bilyeGirdi[1] == eleman.renk[0] && (bilyeGirdi[0] == 'b' && eleman.boyut))
                                {
                                    cikacakEleman = eleman;
                                    break;
                                }
                            }

                            gMasa.Remove(cikacakEleman);
                            //çıkartılanı torbaya ekleme yapacak
                            gTorba.Enqueue(cikacakEleman);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Olmayan top...");
                }

            }

            Console.WriteLine("Hello World!");
        }

        private static string Cozumle(string[] inputArray)
        {
            string output = "";
            string hata = "";

            if (inputArray[0] == "büyük")
            {
                output += "b";
            }
            else if (inputArray[0] == "küçük")
            {
                output += "k";
            }
            else
            {
                hata = "boyut hatası";
                return hata;
            }

            if (inputArray[1] == "mavi")
            {
                output += "m";
            }
            else if (inputArray[1] == "kırmızı")
            {
                output += "k";

            }
            else if (inputArray[1] == "sarı")
            {
                output += "s";

            }
            else
            {
                hata = "renk hatası";
                return hata;
            }

            return output;

        }

        private static Stack initProgram()
        {
            /*kırmızı büyük bilyeler*/
            Bilye bk1 = new Bilye("kırmızı", true);
            Bilye bk2 = new Bilye("kırmızı", true);
            Bilye bk3 = new Bilye("kırmızı", true);

            /**küçük mavi bileyler*/
            Bilye km1 = new Bilye("mavi", false);
            Bilye km2 = new Bilye("mavi", false);
            Bilye km3 = new Bilye("mavi", false);
            Bilye km4 = new Bilye("mavi", false);
            Bilye km5 = new Bilye("mavi", false);
            Bilye km6 = new Bilye("mavi", false);

            /*küçük sarı bilyeler*/
            Bilye ks1 = new Bilye("sarı", false);
            Bilye ks2 = new Bilye("sarı", false);
            Bilye ks3 = new Bilye("sarı", false);
            Bilye ks4 = new Bilye("sarı", false);

            Bilye[] bilyeler = { bk1, bk2, bk3, km1, km2, km3, km4, km5, km6, ks1, ks2, ks3, ks4 };

            ArrayList masa = new ArrayList(bilyeler);
            Queue torba = new Queue();
            Dictionary<string, int> bilgi = new Dictionary<string, int>();

            bilgi.Add("bk", 3);
            bilgi.Add("km", 6);
            bilgi.Add("ks", 4);


            Stack initProgram = new Stack();
            initProgram.Push(bilgi);
            initProgram.Push(masa);
            initProgram.Push(torba);


            return initProgram;

        }
    }
}
