using System;
using System.Collections;

namespace Soru1
{
    class Program
    {
        static void Main(string[] args)
        {
            SinavBagliListe bagliListe = new SinavBagliListe();
            Stack sinavYigin = new Stack();

            ListeElemani n1 = new ListeElemani("A");
            ListeElemani n2 = new ListeElemani("B");
            ListeElemani n3 = new ListeElemani("C");
            ListeElemani n4 = new ListeElemani("D");
            ListeElemani n5 = new ListeElemani("E");

            n1.sonraki = n2;
            n2.sonraki = n3;
            n3.sonraki = n4;
            n4.sonraki = n5;

            bagliListe.head = n1; //bağlı liste hazır
            ListeElemani currentNode = bagliListe.head;

            do
            {
                sinavYigin.Push(currentNode.veri);
                currentNode = currentNode.sonraki;
            } while (currentNode != null);

            Console.WriteLine("Yığının tepesindeki eleman: {0}", sinavYigin.Peek());

        }
    }
}
