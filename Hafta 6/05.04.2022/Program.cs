using System;
using System.Collections;
using System.Collections.Generic;

namespace _05._04._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 1, 3, 5, 6 };
            List<int> liste = new List<int>(sayilar);


            /*for (int i = 0; i < liste.Count; i++)
            {
                Console.Write(liste[i]);
            }

            Console.WriteLine("foreach");

            foreach (var eleman in liste)
            {
                Console.Write(eleman + ",");
            }*/

            try
            {
                ArrayList arrList = new ArrayList();
                //ArrayList arrList2 = new ArrayList();



                arrList.Add(false);//cinsiyet
                arrList.Add(100);
                arrList.Add("Can Razbonyalı");//ad soyad
                /*arrList.Add(5.2);
                arrList.Add('c');*/

                foreach (var satir in arrList)
                {
                    Console.Write(satir);
                }

                if (!(bool)arrList[0]) { //cast
                    Exception ex = new Exception("deneme");
                }

                Console.WriteLine();
                arrList[2] = Convert.ToInt32(arrList[2]) + 100;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Program çok başarılı " + ex);
            }
            finally
            {
                Console.WriteLine("Finally");
            }



            //arrList2.Add(arrList);


            /* Console.WriteLine("Liste içinde liste");

             foreach (ArrayList elemanArrList2 in arrList2)
             {
                 foreach (var eleman in elemanArrList2)
                 {
                     Console.Write(eleman + ",");

                 }
             }*/


        }
    }
}
