using System;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = SayiUret(7);

            int[] siraliInput = new int[7];

            input.CopyTo(siraliInput, 0);
            siraliInput = Sirala(siraliInput);

            Console.WriteLine("Dizinin ilk hali:");
            EkranaYaz(input);

            Console.WriteLine();
            Console.WriteLine("Dizinin sıralı hali:");
            EkranaYaz(siraliInput);
        }

        private static void EkranaYaz(int[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write("{0} ", input[i]);
            }
        }

        private static int[] Sirala(int[] p_input)
        {
            for (int i = 0; i < p_input.Length; i++)
            {
                int temp = p_input[i];
                int currentIndex = i; 

                while (currentIndex > 0 && p_input[currentIndex - 1] > temp)
                {
                    p_input[currentIndex] = p_input[currentIndex - 1];
                    currentIndex--;
                }

                p_input[currentIndex] = temp;
            }

            return p_input;
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
