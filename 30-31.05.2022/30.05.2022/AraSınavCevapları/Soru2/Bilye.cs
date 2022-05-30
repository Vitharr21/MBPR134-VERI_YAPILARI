using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru2
{
    class Bilye
    {
        public string renk { get; set; }

        //false -> küçük, true -> büyük
        public bool buyukMu { get; set; }

        public Bilye(string p_renk, bool p_buyukMu)
        {
            renk = p_renk;
            buyukMu = p_buyukMu;
        }
    }
}
