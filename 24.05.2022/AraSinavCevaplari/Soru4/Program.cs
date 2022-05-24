using System;

namespace Soru4
{
    class Program
    {
        static void Main(string[] args)
        {
            string adSoyad = "Can Razbonyalı";
            int deneme = HarfBul(adSoyad);
            Console.Write("Sesli harf sayısı: {0}", HarfBul(adSoyad));
        }

        private static int HarfBul(string param)
        {
            string sesliHarfler = "aeuüıioö";

            /*
             ilk karakteri al+
             sesli mi kontrolü
                -evet karatkteri diziden çıkart, metodu kendine bir ekleyerek döndür
                -hayır karatkteri diziden çıkart, metodu kendine döndür
             ekrana mesaj yaz
             */


            if (param.Length > 0)
            {
                char harf = param[0];
                if (sesliHarfler.Contains(harf.ToString().ToLower()))
                {
                    return HarfBul(param.Substring(1, param.Length - 1)) + 1;
                }
                else
                    return HarfBul(param.Substring(1, param.Length - 1));
            }
            else
                return 0;
        }

        /*private static void HarfBul(string param)
        {
            string sesliHarfler = "aeuüıioö";
            int sayac = 0;

            for (int i = 0; i < param.Length; i++)
            {
                if (sesliHarfler.Contains(param[i].ToString().ToLower()))
                {
                    sayac += 1;
                }
            }

            Console.Write(sayac);
        }*/
    }
}
