using System;
using System.Collections.Generic;

namespace _15._03._2022_LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> lst = new LinkedList<string>();


            VY_Node nd1 = new VY_Node("Ahmet");
            VY_Node nd2 = new VY_Node("Mehmet");
            VY_Node nd3 = new VY_Node("Cem");
            VY_Node nd4 = new VY_Node("Can");


            nd1.sonraki = nd2;
            nd2.sonraki = nd3;
            nd3.sonraki = nd4;

            VY_BagliListe bagliListe = new VY_BagliListe();
            bagliListe.head = nd1;

            /*
             listeyi gezme - traverse linked list
             */

            VY_Node aktifNode = bagliListe.head; //üzerinde çalışılan node
            do
            {
                Console.Write(aktifNode.veri);

                aktifNode = aktifNode.sonraki;

                if (aktifNode.sonraki == null)
                {
                    Console.Write(aktifNode.veri);
                }

            } while (aktifNode.sonraki != null);

        }
    }
}
