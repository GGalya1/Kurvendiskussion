using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurvendiskussion
{
    class lineareFunktion
    {
        //Eigenschaften (Properties)
        private double anstieg { get; set; }
        private double yAchsenAbschnitt { get; set; }

        //Methoden

        //Konstruktor (muss von außen aursufbar sein, darum "public")
        public lineareFunktion(double anstieg, double yAchsenAbschnitt) //"double anstieg" existiert nur hier, und das hat nicts mit Eigenschaft "anstieg" zu tun
        {
            this.anstieg = anstieg; //"this.anstieg" nihm die Eigenschaft mit diesem Namen und das soll mit Variable die nach "=" eingesetzt werden
            this.yAchsenAbschnitt = yAchsenAbschnitt;
        }

        //weitere Methoden
        public double berechneNullstelle()
        {
            double nullstelle;
            nullstelle = -yAchsenAbschnitt / anstieg;
            return nullstelle;
        }

        public double berechneFunktionswert(double XWert)
        {
            double Funktionswert;
            Funktionswert=anstieg* XWert + yAchsenAbschnitt;
            return Funktionswert;
        }
    }
}
