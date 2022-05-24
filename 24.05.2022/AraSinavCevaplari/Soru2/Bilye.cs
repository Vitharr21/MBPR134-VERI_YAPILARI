using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru2
{
    class Bilye
    {
        public string renk;
        //true-büyük, false-küçük
        public bool boyut;

        public Bilye(string renk, bool boyut)
        {
            this.renk = renk;
            this.boyut = boyut;
        }
    }
}
