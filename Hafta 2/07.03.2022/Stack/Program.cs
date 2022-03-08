using System;
using System.Collections;
using System.Collections.Generic;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> vy_stack = new Stack<int>(); //kurucu metod
            Stack<string> vy_stack2 = new Stack<string>(5); // constructor method 
            //constructor overloading - kurucu aşırı yükleme


            int[] deneme = { 1, 3, 5, 7, 9 };

            Stack<int> vy_stack3 = new Stack<int>(deneme);

            int a = vy_stack3.Peek();

            var enumerator = vy_stack3.GetEnumerator();

            
            /*int elemanKonum = 1;

            while (enumerator.MoveNext())
            {
                Console.WriteLine("{0}. eleman:{1}", elemanKonum, enumerator.Current);
                elemanKonum++;
            }*/


            Console.WriteLine("Peek işlemi: {0}", vy_stack3.Peek());

            int st2_count = vy_stack2.Count;

            string input = "";

            try
            {
                vy_stack2.Push(22);
                vy_stack2.Push(23);
                vy_stack2.Push(25);
                vy_stack2.Push(26);
                vy_stack2.Push(223);
                vy_stack2.Push(2222);

                vy_stack2.Peek();

                vy_stack2.Pop();
                vy_stack2.Pop();
                vy_stack2.Pop();
                vy_stack2.Pop();
                vy_stack2.Pop();
                vy_stack2.Pop();
                
                vy_stack2.Pop();
            }
            catch (Exception e)
            {
                Console.WriteLine("Hata...");
            }

            /*if (vy_stack2.Count > 0)
            {
                vy_stack2.Peek();

            }
            else
                Console.WriteLine("Stack boş...");*/


            
            /*foreach (int sayi in vy_stack3)//variable
            {
                enumerator.MoveNext();
                Console.WriteLine("pozisyon:" + enumerator.Current + " - " + sayi);
            }*/

            //Console.WriteLine("");
        }
    }
}
