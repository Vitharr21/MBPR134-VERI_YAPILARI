using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 5, 1, 4, 2, 8 };

            bool degisimVarMi = true;

            Console.WriteLine("Bubble Sort başlıyor.");

            while (degisimVarMi)
            {
                degisimVarMi = false;

                for (int i = 0; i < sayilar.Length - 1; i++)
                {
                    if (sayilar[i] > sayilar[i + 1])
                    {
                        degisimVarMi = true;

                        /* swap(değişim) işlemi */
                        int temp = sayilar[i];
                        sayilar[i] = sayilar[i + 1];
                        sayilar[i + 1] = temp;
                    }
                }

            }

            Console.WriteLine("Bubble Sort tamamamlandı.");
            foreach (int sayi in sayilar)
            {
                Console.Write("{0} - ", sayi);
            }
        }
    }
}
