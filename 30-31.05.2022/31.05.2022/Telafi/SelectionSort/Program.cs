using System;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = SayiUret(10);
            int[] siraliDizi = new int[input.Length];
            input.CopyTo(siraliDizi, 0);

            siraliDizi = SelectionSort(siraliDizi);

        }

        private static int[] SelectionSort(int[] param)
        {
            for (int i = 0; i < param.Length; i++)
            {
                int enKucukIndis = i;

                for (int j = i + 1; j < param.Length; j++)
                {
                    if (param[enKucukIndis] > param[j])
                    {
                        enKucukIndis = j;
                    }
                }

                if (enKucukIndis != i)//bu koşul sağlanmayabilir?
                {
                    int temp = param[enKucukIndis];
                    param[enKucukIndis] = param[i];
                    param[i] = temp;
                }

            }

            return param;
        }

        private static int[] SayiUret(int param)
        {
            int[] uretilenDizi = new int[param];

            Random rnd = new Random();

            for (int i = 0; i < param; i++)
            {
                uretilenDizi[i] = rnd.Next(100);
            }

            return uretilenDizi;
        }
    }
}
