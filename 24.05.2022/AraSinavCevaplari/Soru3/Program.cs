using System;
using System.Collections.Generic;

namespace Soru3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> araclarListesi = new Dictionary<string, int>();

            while (true)
            {
                string marka = ""; //mutable

                Console.WriteLine("Araç markasını giriniz...");
                marka = Console.ReadLine().Trim();

                if (marka != "gün sonu")
                {
                    if (!araclarListesi.ContainsKey(marka))
                        araclarListesi.Add(marka, 1);
                    else
                        araclarListesi[marka] = araclarListesi[marka] + 1;
                }
                else
                {
                    break;
                }

                Console.Clear();

            }

            Console.Clear();

            Console.WriteLine("----- kapanış -----");
            Yazdir(araclarListesi);

        }

        private static void Yazdir(Dictionary<string, int> paramDict)
        {
            foreach (KeyValuePair<string, int> eleman in paramDict)
            {
                Console.WriteLine("{0} - {1}", eleman.Key, eleman.Value);
            }
        }
    }
}
