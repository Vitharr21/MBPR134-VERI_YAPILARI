using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 7, 2, 5, 1, 9 };

            bool degisimVarmi = true;
            int indis = 0;
            int temp;

            while (degisimVarmi)
            {
                degisimVarmi = false;
                indis = 0;

                while (indis < sayilar.Length - 1)
                {
                    if (sayilar[indis] > sayilar[indis + 1])
                    {
                        degisimVarmi = true;
                        temp = sayilar[indis];
                        sayilar[indis] = sayilar[indis + 1];
                        sayilar[indis + 1] = temp;
                    }

                    indis++;
                }

                /*for (int i = 0; i < sayilar.Length - 1; i++)
                {
                    if (sayilar[i] > sayilar[i + 1])
                    {
                        degisimVarmi = true;
                        temp = sayilar[i];
                        sayilar[i] = sayilar[i + 1];
                        sayilar[i + 1] = temp;
                    }
                }*/
            }

            Yazdir(sayilar);

        }

        private static void Yazdir(int[] p_sayilar)
        {
            Console.WriteLine("Sıralı dizi");
            for (int i = 0; i < p_sayilar.Length; i++)
            {
                Console.Write("{0},", p_sayilar[i]);
            }
        }
    }
}
