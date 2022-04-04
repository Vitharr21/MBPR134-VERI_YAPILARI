using System;
using System.Collections;


using System.Collections.Generic;

namespace _04._04._2022
{
    class Program
    {
        static void Main(string[] args)
        {

            List<char> liste2 = new List<char>();
            /**  - List
                        int[] elemanlar = { 2, 4, 6, 89, 9 };
                        var liste = new List<int>(elemanlar);

                        liste.Add(22);

                        var kisiler = new List<dynamic>();//veri tabanı
                                                          
                        kisiler.Add(true);

                       //liste.AddRange(elemanlar);



                        bool varMi = liste.Contains(3333);
                        -*/

            try
            {
                var arrList = new ArrayList();
                int[] elemanlar = { 2, 4, 6, 8, 35 };

                ArrayList readOnlyList = ArrayList.ReadOnly(arrList);

                arrList.AddRange(elemanlar);
                bool deneme = arrList.IsReadOnly;

                bool deneme2 = readOnlyList.IsReadOnly; //içeriğinde değişiklik yapılmaz

                arrList.Add("merhaba");
                arrList.Add(false);


                Console.Write("For elemanlar");
                for (int i = 0; i < arrList.Count; i++)
                {
                    Console.Write(arrList[i] + ",");
                }
                Console.WriteLine();

                Console.Write("For elemanlar");
                foreach (var eleman in arrList)
                {
                    Console.Write(eleman + ",");
                }

                arrList[5] = Convert.ToInt32(arrList[5]) + 100;

                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.Write("Bir hata ile karşılaşıldı. Sistem yönetisi ile iletişime geçiniz.");
                //Loglama 
            }
            finally
            {
                //veri tabanı bağlantısınıkapat
            }

        }
    }
}

