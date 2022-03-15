using System;
using System.Collections.Generic;

namespace _15._03._2022_LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            /*LinkedList<string> lst = new LinkedList<string>();
            lst.*/

            VY_Node nd1 = new VY_Node("Ahmet");
            VY_Node nd2 = new VY_Node("Mehmet");
            VY_Node nd3 = new VY_Node("Cem");
            VY_Node nd4 = new VY_Node("Can");


            nd1.sonraki = nd2;
            nd2.sonraki = nd3;
            nd3.sonraki = nd4;

            VY_BagliListe bagliListe = new VY_BagliListe();
            bagliListe.head = nd1;


            Console.WriteLine("Hello World!");
        }
    }
}
