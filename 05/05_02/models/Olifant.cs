using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class Olifant : Dier
    {

        /* Olifant
         * -----------------------------
         * +Gegevens : string
         * -----------------------------
         * +Olifant(naam: string)
         * +Praten(zin: string) : string
         * +Strelen() : string
         */

        // De gegevens van een olifant worden als volgende tekstuele waarde weergegeven: Mijn naam is <Naam> en ik ben een <klassenaam>. Pfwww! STOMP!
        public override string Gegevens
        {
            get { return base.Gegevens + " Pfwww! STOMP!"; }
        }

        public Olifant(string naam) : base(naam) { }

        // Wanneer een olifant praat, zal deze "Pfwwwwwww!" als geluid maken.
        public override string Praten(string zin)
        {
            zin = "Pfwwwwwww!";
            return zin;
        }

        // Wanneer een olifant gestreeld wordt, zal deze "STOMP! STOMP! STOMP!" als geluid maken.
        public override string Strelen()
        {
            string strelen = "STOMP! STOMP! STOMP!";
            return strelen;
        }
    }
}
