using System;
using System.Collections.Generic;

namespace _19._04._2022
{
    class Program
    {
        struct Urun
        {
            public int miktar;
            public string ad;

        }
        static void Main(string[] args)
        {
            Dictionary<int, string> deneme = new Dictionary<int, string>();

            try
            {
                /*
                deneme.Add(1, "Maltepe Ünı.-Maltepe");
                deneme.Add(2, "Maltepe Ünı.-Kadıköy");
                deneme.Add(3, "Maltepe Ünı.-Bosta");

                //string value = "";
                deneme.TryGetValue(2, out string value);
                Console.Write("2 id li değer {0}\n", value);

                Console.Write("3 id li değer {0}", deneme[3]);

                deneme[3] = deneme[3] + "ncı";

                deneme[3] = deneme[3] + "merhaba";

                string val = deneme[1].Replace('ı', 'i').ToUpper();



                foreach (KeyValuePair<int, string> servisHatti in deneme)
                {
                    string newVal = deneme[servisHatti.Key].Replace('ı', 'i');
                    deneme[servisHatti.Key] = newVal;
                    servisHatti.Value.Replace('ı', 'i');
                    servisHatti.Value.Replace('ö', 'o');
                    Console.WriteLine(servisHatti.Value);
                }

                KeyValuePair<int, string> yeniHat = new KeyValuePair<int, string>(4, "Maltepe Üni.-Tuzla");


                //deneme.ContainsKey(4) == false
                if (!deneme.ContainsKey(4))
                {
                    deneme.Add(4, "Maltepe Üni.-Tuzla");
                }*/

                Urun elma = new Urun();
                elma.miktar = 1;
                elma.ad = "elma";


                Urun armut = new Urun();
                armut.miktar = 2;
                armut.ad = "armut";


                Urun muz = new Urun();
                muz.miktar = 1;
                muz.ad = "armut";



                Stack<Urun> sepetimiz = new Stack<Urun>();
                sepetimiz.Push(elma);
                sepetimiz.Push(armut);
                sepetimiz.Push(muz);

                Dictionary<string, int> urunler = new Dictionary<string, int>();

                while (sepetimiz.Count > 0)
                {
                    Urun cikanUrun = sepetimiz.Pop();

                    if (urunler.ContainsKey(cikanUrun.ad)){
                        throw new Exception("ekleme hatası");
                    }

                    urunler.Add(cikanUrun.ad, cikanUrun.miktar + 1);

                }



            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
        }
    }
}
