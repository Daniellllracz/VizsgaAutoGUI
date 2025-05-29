using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoGUI
{
    class Gyarto
    {
        public int GyartoId { get; set; }
        public string GyartoNev { get; set; }

        public Gyarto(int gyartoId, string gyartoNev)
        {
            GyartoId = gyartoId;
            GyartoNev = gyartoNev;
        }
    }
}
