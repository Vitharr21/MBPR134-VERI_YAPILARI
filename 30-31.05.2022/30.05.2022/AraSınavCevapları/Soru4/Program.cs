using System;


/*
 Adınız ve soyadınızda bulunan ünlü harf sayısını bulan özyinelemeli fonksiyon ve 
bu fonksiyonun sonucunu konsola yazdıran programı C# programlama dili ile geliştiriniz (20 p).

 */

namespace Soru4
{
    class Program
    {
        static void Main(string[] args)
        {
            //string adSoyad = "Can Razbonyalı"; 
            Console.WriteLine("Sesli harf sayısı: {0}", SesliHarfSay("Can Razbonyalı"));
        }

        private static int SesliHarfSay(string param)
        {
            /*
             - ilk karakteri oku - param[0] substring()
             - sesli mi bak
             - 
             */
            string sesliHarfler = "aeuüoöıi";

            /*Console.WriteLine(sesliHarfler.Contains(param[1].ToString().ToLower()));
            string deneme = param.Substring(1);*/

            if (param.Length > 0)
            {
                if ((sesliHarfler.Contains(param[0].ToString().ToLower())))
                {
                    return SesliHarfSay(param.Substring(1)) + 1;
                }
                else
                    return SesliHarfSay(param.Substring(1));
            }
            else
                return 0;
        }
    }
}
