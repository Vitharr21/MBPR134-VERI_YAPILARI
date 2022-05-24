using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru1
{
    class ListeElemani
    {
        public string veri;
        public ListeElemani sonraki;

        public ListeElemani(string param)
        {
            veri = param;
        }
    }
}
