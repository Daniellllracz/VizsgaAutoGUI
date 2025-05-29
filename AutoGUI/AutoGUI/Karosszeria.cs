using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoGUI
{
    class Karosszeria
    {
        public int KarosszeriaId { get; set; }
        public string KarosszeriaNev { get; set; }

        public Karosszeria(int karosszeriaId, string karosszeriaNev)
        {
            KarosszeriaId = karosszeriaId;
            KarosszeriaNev = karosszeriaNev;
        }
    }
}
