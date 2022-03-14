using System;
using System.Collections.Generic;

namespace _14._03._2022_LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int[] elemanlar = { 1, 2, 3, 4, 5, 6 };

            LinkedList<int> bagliListe = new LinkedList<int>();

            LinkedList<int> bagliListe2 = new LinkedList<int>(elemanlar);

            bagliListe2.AddLast(99);
            LinkedListNode<int> nodeReferans = new LinkedListNode<int>(4);
            bagliListe2.AddBefore(nodeReferans, 666);*/

            BizimBagliListe vyBagliListe = new BizimBagliListe();

            BizimNode nodeIlk = new BizimNode(5);
            nodeIlk.sonraki = null;

            BizimNode nodeIki = new BizimNode(6);
            BizimNode nodeUc = new BizimNode(7);



            vyBagliListe.head = nodeIlk;

            /*if (vyBagliListe.head == null)
            {
                vyBagliListe.head = nodeIlk;
            }*/



            Console.WriteLine("Liste boş...");

            nodeIlk.sonraki = nodeIki;
            nodeIki.sonraki = nodeUc;
            nodeUc.sonraki = null;

            /*
             bağlı listeyi gezmek
             */

            BizimNode currentNode = vyBagliListe.head; //her seferinde üzerinde çalışılan node

            //while ((currentNode != null) && (currentNode.sonraki != null))
            while (currentNode != null)
            {
                Console.WriteLine(currentNode.veri);
                currentNode = currentNode.sonraki;
            }

            Console.WriteLine("Hello World!");
        }
    }
}
