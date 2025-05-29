using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoGUI
{
    class Auto
    {
        public int Azonosito { get; set; }
        public int Evjarat { get; set; }
        public Gyarto Gyarto { get; set; }
        public string Modell { get; set; }
        public int Kilometer { get; set; }
        public Karosszeria Karosszeria { get; set; }
        public int Hengerek { get; set; }
        public Valto Valto { get; set; }
        public string Kulsoszin { get; set; }
        public string Belsoszin { get; set; }
        public int Szemelyek { get; set; }
        public int Ajtok { get; set; }
        public double Fogyasztasvarosban { get; set; }
        public double FogyasztasPalya { get; set; }
        public int Ar { get; set; }


        public Auto (string sor)
        {
            var v = sor.Split(';');
            Azonosito = int.Parse(v[0]);
            Evjarat = int.Parse(v[1]);
            Gyarto = new Gyarto(int.Parse(v[2]), v[3]);
            Modell = v[4];
            Kilometer = int.Parse(v[5]);
            Karosszeria = new Karosszeria(int.Parse(v[6]), v[7]);
            Hengerek = int.Parse(v[8]);
            Valto = new Valto(int.Parse(v[9]), v[10]);
            Kulsoszin = v[11];
            Belsoszin = v[12];
            Szemelyek = int.Parse(v[13]);
            Ajtok = int.Parse(v[14]);
            Fogyasztasvarosban = double.Parse(v[15]);
            FogyasztasPalya = double.Parse(v[16]);
            Ar = int.Parse(v[17]);
        }
    }
}

