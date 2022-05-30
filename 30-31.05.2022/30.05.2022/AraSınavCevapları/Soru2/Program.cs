using System;
using System.Collections;

/*
 Kırmızı, mavi, sarı renklerinde; büyük ve küçük ölçülerine sahip, 

üç adet büyük kırmızı, altı adet küçük mavi ve 
dört adet küçük sarı bilyeleri bir torbada saklamak 


istiyorsunuz(bilyeler struct ya da sınıf, torba da ders süresince işlenen veri yapıları ile temsil edilmeli). 
Saklanmak istenen torbanın ağzı, bütün bilyeleri bir seferde içerisine koyabilecek kadar geniş 
olmamak ile birlikte, bir tane büyük ya da iki tane küçük bilye alabilecek kadar geniştir.  
Yukarıda belirtilen senaryoyu gerçekleştirip, sizlerden bilyelerin hepsi torbaya doldurulana 
kadar hangi bilyeden kaç tane torbaya koymanızı istediğinizi bekleyen programı C# programlama 
dili ile geliştiriniz (40 p). 

•	Hangi veri yapısını, neden kullanmayı tercih ettiğinizi açıklama satırında belirtmelisiniz.
•	Giriş yapacak kişi, torbaya bir seferde on üç adet küçük, mavi toplardan 
(bu diğer bilyeler için de genişletilebilir) yani, olmaması gereken bir 
durum gerçekleştirilmeye çalışabilir. Bu durumların kontrol edilip, anlamlı bir mesaj 
ile kullanıcının bilgilendirilmesi gerekir.

 */

namespace Soru2
{
    class Program
    {
        static void Main(string[] args)
        {
            //mavi - sarı - kırmızı
            ArrayList masadakiBilyeler = ProgramHazirlik();
            Stack torba = new Stack();

            ArrayList maviToplar = (ArrayList)masadakiBilyeler[0];
            ArrayList kirmiziToplar = (ArrayList)masadakiBilyeler[1];
            ArrayList sariToplar = (ArrayList)masadakiBilyeler[2];

            string inputAktarilacakBilyeler = "";
            string[] aktarilacakBilyeler_ayristirilmis;

            while ((maviToplar.Count + sariToplar.Count + kirmiziToplar.Count) > 0)
            {
                Console.WriteLine("Torbaya koymak istediğiniz renk adet ve büyüklük giriniz.\n" +
                    "bilyleri ; ile ayrıştırınız.");
                inputAktarilacakBilyeler = Console.ReadLine();
                aktarilacakBilyeler_ayristirilmis = inputAktarilacakBilyeler.Split(";");

                for (int i = 0; i < aktarilacakBilyeler_ayristirilmis.Length; i++)
                {
                    string[] bilyeBilgileri = aktarilacakBilyeler_ayristirilmis[i].Split(" ");

                    if (aktarilacakBilyeler_ayristirilmis.Length > 2)
                    {
                        Console.WriteLine("Tek seferde bir büyük ya da iki küçük bilye aktarılabilir!");
                        Console.Clear();
                        break;
                    }
                    else if (aktarilacakBilyeler_ayristirilmis[i].Contains("büyük") &&
                            aktarilacakBilyeler_ayristirilmis.Length > 1)
                    {
                        Console.WriteLine("Tek seferde bir büyük ya da iki küçük bilye aktarılabilir!");
                        Console.Clear();
                        break;
                    }
                    else if ((bilyeBilgileri[0] == "sarı" || bilyeBilgileri[0] == "mavi") &&
                                bilyeBilgileri[2] != "küçük")
                    {
                        Console.WriteLine("Sarı ve mavi bilyeler küçüktür.");
                        Console.Clear();
                        break;
                    }
                    else if (bilyeBilgileri[0] == "kırmızı" && bilyeBilgileri[2] != "büyük")
                    {
                        Console.WriteLine("Kırmızı bilyeler küçüktür.");
                        Console.Clear();
                        break;
                    }

                    switch (bilyeBilgileri[0])
                    {
                        case "kırmızı":
                            Bilye kirmiziBilye = (Bilye)kirmiziToplar[0];
                            kirmiziToplar.RemoveAt(0);
                            torba.Push(kirmiziBilye);
                            break;
                        case "mavi":
                            Bilye maviBilye = (Bilye)maviToplar[0];
                            maviToplar.RemoveAt(0);
                            torba.Push(maviBilye);
                            break;
                        case "sarı":
                            Bilye sariBilye = (Bilye)sariToplar[0];
                            sariToplar.RemoveAt(0);
                            torba.Push(sariBilye);
                            break;
                        default:
                            break;
                    }
                }
            }

        }

        private static ArrayList ProgramHazirlik()
        {
            Bilye buyuk_K1 = new Bilye("kırmızı", true);
            Bilye buyuk_K2 = new Bilye("kırmızı", true);
            Bilye buyuk_K3 = new Bilye("kırmızı", true);

            Bilye buyuk_M1 = new Bilye("mavi", false);
            Bilye buyuk_M2 = new Bilye("mavi", false);
            Bilye buyuk_M3 = new Bilye("mavi", false);
            Bilye buyuk_M4 = new Bilye("mavi", false);
            Bilye buyuk_M5 = new Bilye("mavi", false);
            Bilye buyuk_M6 = new Bilye("mavi", false);

            Bilye kucuk_S1 = new Bilye("sari", false);
            Bilye kucuk_S2 = new Bilye("sari", false);
            Bilye kucuk_S3 = new Bilye("sari", false);
            Bilye kucuk_S4 = new Bilye("sari", false);

            Bilye[] mavilerD = { buyuk_M1, buyuk_M2, buyuk_M3, buyuk_M4, buyuk_M5, buyuk_M6 };
            ArrayList maviler = new ArrayList(mavilerD);

            Bilye[] kirmizilarD = { buyuk_K1, buyuk_K2, buyuk_K3 };
            ArrayList kirmizilar = new ArrayList(kirmizilarD);

            Bilye[] sarilarD = { kucuk_S1,
                                 kucuk_S2,
                                 kucuk_S3,
                                 kucuk_S4};


            ArrayList sarilar = new ArrayList(sarilarD);

            ArrayList masa = new ArrayList();
            masa.Add(maviler);
            masa.Add(kirmizilar);
            masa.Add(sarilar);

            return masa;
        }
    }
}
