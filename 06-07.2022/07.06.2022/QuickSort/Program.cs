using System;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] sayilar = SayilariUret(8);

            Console.WriteLine("Dizinin ilk hali: ");
            foreach (int eleman in sayilar)
            {
                Console.Write("{0} - ", eleman);
            }

            Console.WriteLine();
            QuickSort(sayilar, 0, sayilar.Length - 1);

            Console.WriteLine("Sıralı dizi: ");
            foreach (int eleman in sayilar)
            {
                Console.Write("{0} - ", eleman);
            }
        }

        private static void QuickSort(int[] sayilar, int p_ilkIndis, int p_sonIndis)
        {
            if (p_ilkIndis < p_sonIndis)
            {
                int pivotIndeksi = diziyiBol(sayilar, p_ilkIndis, p_sonIndis);
                QuickSort(sayilar, p_ilkIndis, pivotIndeksi - 1); // pivot değerinden küçük elemanları sırala
                QuickSort(sayilar, pivotIndeksi + 1, p_sonIndis);// pivot değerinden büyük elemanları sırala
            }
        }

        private static int diziyiBol(int[] p_sayilar, int p_ilkIndis, int p_sonIndis)
        {
            int pivot = p_sayilar[p_sonIndis]; //son eleman pivot olarak seçildi
            int kucukDegerliIndeks = (p_ilkIndis - 1);

            for (int i = p_ilkIndis; i <= p_sonIndis; i++)
            {
                if (p_sayilar[i] < pivot)
                {
                    kucukDegerliIndeks++;
                    swap(p_sayilar, kucukDegerliIndeks, i);
                }
            }

            swap(p_sayilar, kucukDegerliIndeks + 1, p_sonIndis);

            return kucukDegerliIndeks + 1;
        }

        private static void swap(int[] p_sayilar, int degisecekEleman, int degisecekEleman2)
        {
            int temp = p_sayilar[degisecekEleman];
            p_sayilar[degisecekEleman] = p_sayilar[degisecekEleman2];
            p_sayilar[degisecekEleman2] = temp;
        }

        private static int[] SayilariUret(int p_uzunluk)
        {
            int[] tempDizi = new int[p_uzunluk];
            Random rnd = new Random();

            for (int i = 0; i < p_uzunluk; i++)
            {
                tempDizi[i] = rnd.Next(100);
            }

            return tempDizi;
        }
    }
}
