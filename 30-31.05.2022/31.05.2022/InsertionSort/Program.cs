using System;
using System.Collections;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList deneme = new ArrayList();
            int[] sayilar = { 24, 46, 46, 12, 30, 21, 1, 40, 45, 20 };

            int[] siraliDizi = new int[sayilar.Length];

            sayilar.CopyTo(siraliDizi, 0);

            siraliDizi = InsertionSort(siraliDizi);

            Console.WriteLine("Dizinin ilk hali:");

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.Write("{0} ", sayilar[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Dizinin sıralı hali:");

            for (int i = 0; i < siraliDizi.Length; i++)
            {
                Console.Write("{0} ", siraliDizi[i]);
            }
        }

        private static int[] InsertionSort(int[] p_sayilar)
        {
            for (int i = 0; i < p_sayilar.Length; i++)
            {
                int islenenIndis = i;
                int temp = p_sayilar[i];

                while (islenenIndis > 0 && p_sayilar[islenenIndis - 1] > temp)
                {
                    p_sayilar[islenenIndis] = p_sayilar[islenenIndis - 1];
                    islenenIndis--;
                }
                p_sayilar[islenenIndis] = temp;
            }

            return p_sayilar;
        }

    }
}
