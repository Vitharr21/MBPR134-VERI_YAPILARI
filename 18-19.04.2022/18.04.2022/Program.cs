using System;
using System.Collections.Generic;

namespace _18._04._2022
{
    class Program
    {
        struct Kisi
        {
            public string ad;
            public int yas;
        }

        static void Main(string[] args)
        {
            /*Random vyRandom = new Random();
            int unvanIndx = vyRandom.Next(1, 4);

            Kisi denemeKisi = new Kisi();
            denemeKisi.ad = "Can Deneme";
            denemeKisi.yas = 36;

            string[] unvanlar = { "Müdür", "Müdür Yrd.", "Sekreter" };


            Dictionary<string, Kisi> orgSemasi = new Dictionary<string, Kisi>();
            orgSemasi.Add(unvanlar[unvanIndx], denemeKisi);

            //Dictionary - Sözlük
            Dictionary<string, int> dicIsimYas = new Dictionary<string, int>();

            dicIsimYas.Add("Murat", 33);
            dicIsimYas.Add("Aslı", 33);
            dicIsimYas.TryAdd("Try-Add", 20);

            Console.WriteLine("Yaş: {0}", dicIsimYas["Aslı"]);


            dicIsimYas["Aslı"] = dicIsimYas["Aslı"] + 1;
            Console.WriteLine("Doğum gününden sonra Aslı: {0} yaşında", dicIsimYas["Aslı"]);



            bool eklendiMi = dicIsimYas.TryAdd("Aslıı", 35);

            if (eklendiMi)
            {
                Console.WriteLine("Başarı ile eklendi...");
            }

            foreach (KeyValuePair<string, int> eleman in dicIsimYas)
            {
                Console.WriteLine(eleman);
            }

            //dicIsimYas.Add("Aslı", 35);*/


            string[] sinifUyeleri = { "Ali", "Gencay", "Aslı", "Caner", "Gencay", "Ali", "Caner", "Caner" };
            Dictionary<string, int> sinifDictionary = new Dictionary<string, int>();

            foreach (var kisi in sinifUyeleri)
            {
                if (!sinifDictionary.ContainsKey(kisi))
                {
                    sinifDictionary.TryAdd(kisi, 1);
                }
                else
                {
                    sinifDictionary[kisi] = sinifDictionary[kisi] + 1;
                }
            }

            int deger = 0, deger2 = 0;
            if (sinifDictionary.ContainsKey("Ali"))
            {
                sinifDictionary.TryGetValue("Ali", out deger);
                deger2 = sinifDictionary["Ali"];
            }

            string anahtarDeger = "Ali" + deger;


            DictionaryGoruntule(sinifDictionary, "Sınıf Mevcudu");
        }

        private static void DictionaryGoruntule(Dictionary<string, int> sinifDictionary, string mesaj)
        {
            Console.WriteLine(mesaj);
            foreach (var kisi in sinifDictionary)
            {
                Console.WriteLine(kisi);
            }
        }
    }
}
