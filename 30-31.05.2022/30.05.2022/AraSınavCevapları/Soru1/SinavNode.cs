using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru1
{
    class SinavNode
    {
        public char veri;
        public SinavNode sonraki;

        public SinavNode(char pVeri)
        {
            veri = pVeri;
        }
    }
}
