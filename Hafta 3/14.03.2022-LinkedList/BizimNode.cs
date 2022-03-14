using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._03._2022_LinkedList
{
    class BizimNode
    {
        /*
         veri tutulacak
         sonraki node
         */

        public BizimNode(int pVeri)
        {
            veri = pVeri;
        }

        public BizimNode() //default constructor
        {
        }

        public int veri;
        public BizimNode sonraki;
    }
}
