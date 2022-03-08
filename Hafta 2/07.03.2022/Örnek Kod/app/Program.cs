using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1 = "Veri Yapıları Dersi";
            string[] tersKelimeler = new string[input1.Split(" ").Length];
            tersKelimeler = KelimeleriTersCevir(input1);

            Console.WriteLine("Kelimeleri görüntülemek için 1 e basabilirsiniz...");
            //int secim = Convert.ToInt32(Console.ReadLine());
            int secim = 1;
            switch (secim)
            {
                case 1:
                    foreach(var kelime in tersKelimeler){
                        Console.WriteLine(kelime);
                    }
                    break;
            }

            int[] sayilar =  new int[5];
            sayilar = SayiUret(5-1, sayilar);

            string yeniDizi = "";

            yeniDizi = Karistir(sayilar, tersKelimeler[1], (sayilar.Length+tersKelimeler[2].Length), yeniDizi);

            Console.WriteLine("Yeni Dizi {0}", yeniDizi);
        }

        private static string Karistir(int[] sayilar, string tersKelimeler, int s, string yeniDizi)
        {
            if(s > 0){
                return yeniDizi;
            }
            
            yeniDizi += sayilar[(s - (tersKelimeler.Length + 1))].ToString() + 
                tersKelimeler[new Random().Next(0,4)].ToString();
            return Karistir(sayilar, tersKelimeler, --s, yeniDizi);
        }

        private static int[] SayiUret(int n, int[] sayilar)
        {
            int sayiRnd = new Random().Next(0,100);

            if(n == 0){
                return sayilar;
            }
            
            sayilar[n] = sayiRnd;
            return SayiUret(--n, sayilar);
        }

        private static string[] KelimeleriTersCevir(string input1)
        {
            if (input1.Length < 0 || input1.Length == 0)
            {
                return null;
            }

            return input1.Split(" ");
        }
    }
}
