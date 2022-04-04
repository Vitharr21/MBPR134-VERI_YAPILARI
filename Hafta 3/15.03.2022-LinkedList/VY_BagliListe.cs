using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quizdevami
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> list = new LinkedList<string>();
            VY_Node nd1 = new VY_Node("A");
            VY_Node nd2 = new VY_Node("B");
            VY_Node nd3 = new VY_Node("C");
            VY_Node nd4 = new VY_Node("D");
            VY_Node nd5 = new VY_Node("E");


            nd1.sonraki = nd2;
            nd2.sonraki = nd3;
            nd3.sonraki = nd4;
            nd4.sonraki = nd5;


            VY_Bagliliste bagliliste = new VY_Bagliliste();
            bagliliste.head = nd1;
            VY_Node currentNode = bagliliste.head;

            while (currentNode != null)
            {
                Console.WriteLine(currentNode.veri);

                if (currentNode.sonraki.veri == "C")  //çektiğimiz n1 değerinden sonraki verilerden biri C değerine eşitse
                {
                    list.Remove(currentNode.sonraki.veri); //bir sonraki veriyi siliyor
                    currentNode = currentNode.sonraki.sonraki;//daha sonra sildiği veriyi atlayıp veri yazdırmaya devam ediyor
                }
                else
                {
                    currentNode = currentNode.sonraki; //eğer C değilse sonraki veriye geçiyor
                }

            }


            bagliliste.head = nd1;
            currentNode = bagliliste.head;
            while (currentNode != null)
            {
                Console.WriteLine(currentNode.veri);
                currentNode = currentNode.sonraki;
            }

            Console.ReadKey();
        }
    }
    class VY_Node
    {
        public string veri;
        public VY_Node sonraki;
        public VY_Node(string pveri)
        {
            veri = pveri;
        }
    }
    class VY_Bagliliste
    {
        public VY_Node head;
        public VY_Bagliliste()
        {
            head = null;
        }
    }
}