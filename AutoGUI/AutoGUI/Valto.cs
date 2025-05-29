using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoGUI
{
    class Valto
    {
        public int ValtoId { get; set; }
        public string ValtoNev { get; set; }

        public Valto(int valtoId, string valtoNev)
        {
            ValtoId = valtoId;
            ValtoNev = valtoNev;
        }
    }
}
