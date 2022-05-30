using System;
using System.Collections;

namespace Soru1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            SinavBagliListe bagliListe = ProramiHazirla('A','B','C','D','E');

            Stack sinavYigin = new Stack();
            SinavNode currentNode = bagliListe.head;

            while (currentNode != null)
            {
                sinavYigin.Push(currentNode.veri);
                currentNode = currentNode.sonraki;
            }

            Console.WriteLine("Yığının en tepesindeki veri - {0}", sinavYigin.Pop());

        }

        private static SinavBagliListe ProramiHazirla()
        {
            SinavNode node1 = new SinavNode('A');
            SinavNode node2 = new SinavNode('B');
            SinavNode node3 = new SinavNode('C');
            SinavNode node4 = new SinavNode('D');
            SinavNode node5 = new SinavNode('E');

            node1.sonraki = node2;
            node2.sonraki = node3;
            node3.sonraki = node4;
            node4.sonraki = node5;

            SinavBagliListe bagliListe = new SinavBagliListe(node1);

            return bagliListe;
        }

        private static SinavBagliListe ProramiHazirla(char p1, char p2, char p3, char p4, char p5)
        {
            SinavNode node1 = new SinavNode(p1);
            SinavNode node2 = new SinavNode(p2);
            SinavNode node3 = new SinavNode(p3);
            SinavNode node4 = new SinavNode(p4);
            SinavNode node5 = new SinavNode(p5);

            node1.sonraki = node2;
            node2.sonraki = node3;
            node3.sonraki = node4;
            node4.sonraki = node5;

            SinavBagliListe bagliListe = new SinavBagliListe(node1);

            return bagliListe;
        }
    }
}
