using System;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = SayiUret(8);

            quickSort(sayilar, 0, sayilar.Length - 1);

            Console.WriteLine("Hello World!");
        }

        private static void quickSort(int[] sayilar, int ilkIndis, int sonIndis)
        {
            if (ilkIndis < sonIndis)
            {
                int pivot = parcayaAyir(sayilar, ilkIndis, sonIndis);
                quickSort(sayilar, ilkIndis, pivot - 1); //pivot değerinden küçük olanları sıralamak için
                quickSort(sayilar, pivot + 1, sonIndis); // pivot değerinden büyük olanları sıralamak için

            }
        }

        private static int parcayaAyir(int[] p_sayilar, int p_ilkIndis, int p_sonIndis)
        {
            int pivot = p_sayilar[p_sonIndis]; //son eleman pivot olarak seçilmekte
            int enKucukIndis = (p_ilkIndis - 1);

            for (int i = p_ilkIndis; i <= p_sonIndis; i++)
            {
                if (p_sayilar[i] < pivot)
                {
                    enKucukIndis++;
                    swap(p_sayilar, enKucukIndis, i);

                }
            }

            swap(p_sayilar, enKucukIndis + 1, p_sonIndis);

            return enKucukIndis + 1;
        }

        private static void swap(int[] p_sayilar, int ilkIndis, int ikinciIndis)
        {
            int temp = p_sayilar[ilkIndis];
            p_sayilar[ilkIndis] = p_sayilar[ikinciIndis];
            p_sayilar[ikinciIndis] = temp;
        }

        private static int[] SayiUret(int p_uzunlıuk)
        {
            int[] tempDizi = new int[p_uzunlıuk];

            Random rnd = new Random();

            for (int i = 0; i < p_uzunlıuk; i++)
            {
                tempDizi[i] = rnd.Next(100);
            }

            return tempDizi;
        }
    }
}
