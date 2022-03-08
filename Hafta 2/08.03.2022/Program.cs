using System;
using System.Collections.Generic;

namespace _08._03._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] collectionDeneme =
            {
                "a","b","c","d"
            };

            Stack<string> stk = new Stack<string>(collectionDeneme);

            //Stack<string> stk2 = new Stack<string>(5);

            //stk2 = ElemanEkle(stk2);

            //stack in en tepesindeki elemanı alır
            string elmn = stk.Peek();


            Console.WriteLine("Bir değer giriniz");
            elmn = Console.ReadLine();

            //stack e eleman ekleme
            stk.Push(elmn);
            Console.WriteLine("{0} eklendi", elmn);

            //elemanın stack te olup olmadığını belirtir
            bool a1 = stk.Contains("eleman22");
            bool a2 = stk.Contains("eleman2");


            string[] elemanlarArr = stk.ToArray();

            //stk[2] = "dasadsad";
            elemanlarArr[2] = "değiştirdik";

            /*stack in tepesinde eleman çıkartma
             son eklenen elemanı çıkartma 
             */
            string cikanEleman = stk.Pop();
            Console.WriteLine("{0} çıkartıldı", cikanEleman);

            //stackk içierisindeki elemanları görüntüleme

            int sayac = stk.Count;
            foreach (string eleman in stk)
            {
                Console.WriteLine("{1}. eleman: {0}", eleman, sayac);
                sayac--;
            }

            /*
             önemli
             */

            int[] sayilarDizi = { 1, 2, 3, 4, 5, 6 };
            Stack<int> stackSayilar = new Stack<int>(sayilarDizi);

            /*if (stackSayilar.Count > 0)
            {
                stackSayilar.Peek();
                stackSayilar.Pop();
            }
            else
            {
                Console.Write("Stack boş...");
            }*/

            try
            {
                stackSayilar.Peek();
                stackSayilar.Pop();
            }
            catch(Exception e)
            {
                Console.Write("Stack boş... {0}", e);
            }
            finally
            {
                Console.Write("Her zaman çalışan alan");
            }

            elmn = Console.ReadLine();
            TersCevir(elmn);


            /*Stack<int> stk2 = new Stack<int>();
            Stack<bool> stk3 = new Stack<bool>();*/
        }

        private static void TersCevir(string elmn)
        {
            Stack<char> tersStack = new Stack<char>(elmn);
            foreach (var karakter in tersStack)
            {
                Console.Write(karakter);
            }
        }

        private static Stack<string> ElemanEkle(Stack<string> stk2)
        {
            stk2.Push("a");
            stk2.Push("a");
            stk2.Push("a");
            stk2.Push("a");
            stk2.Push("a");
            stk2.Push("a");
            stk2.Push("a");
            stk2.Push("a");

            return stk2;

        }
    }
}
