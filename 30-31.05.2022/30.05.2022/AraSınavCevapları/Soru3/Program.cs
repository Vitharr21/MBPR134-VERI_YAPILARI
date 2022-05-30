using System;
using System.Collections.Generic;

/*
Bir otopark, gün sonunda hangi marka araçtan kaç tane otopark hizmeti 
kullandığı bilgisini tutan bir uygulama geliştirilmesini istemiştir. 
Uygulama, görevli tarafından “gün sonu” yazılana kadar otoparktan 
çıkış yapan arabanın markasını girmesini bekleyerek çalışmalıdır. Görevli, “gün sonu” 
yazdığında da o ana kadar kalan arabalarının ve adetlerinin dökümünü ekranda görüntülemelidir.
•	Arabaların ve adetleri bilgileri, kullanacağınız veri yapısı içerisinde olmalıdır ya da 
bu veri yapısı içerisinde saydırılmalıdır.

 */

namespace Soru3
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputAracMarkasi = "";
            Dictionary<string, int> araclar = new Dictionary<string, int>();

            while (inputAracMarkasi.ToLower() != "gün sonu")
            {
                Console.Write("Çıkış yapan araç markası: ");
                inputAracMarkasi = Console.ReadLine().ToUpper();

                if (inputAracMarkasi.ToLower() != "gün sonu")
                {
                    Ekle(araclar, inputAracMarkasi);
                }

            }
            Yazdir(araclar);

            Console.Write("Sonlandırılıyor...");
        }

        private static void Yazdir(Dictionary<string, int> p_araclar)
        {
            foreach (KeyValuePair<string, int> arac in p_araclar)
            {
                Console.WriteLine("{0} - {1}", arac.Key, arac.Value);
            }
        }

        private static void Ekle(Dictionary<string, int> p_araclar, string p_inputAracMarkasi)
        {
            if (p_araclar.ContainsKey(p_inputAracMarkasi))
            {
                p_araclar[p_inputAracMarkasi] += 1;
            }
            //else if (!p_araclar.ContainsKey(p_inputAracMarkasi) && p_inputAracMarkasi.ToLower() != "gün sonu")
            else if (!p_araclar.ContainsKey(p_inputAracMarkasi))
            {
                p_araclar.Add(p_inputAracMarkasi, 1);
            }
        }
    }
}
