using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class Kat : Dier
    {
        /* Kat
         * -----------------------------
         * +Gegevens : string
         * -----------------------------
         * +Kat(naam: string)
         * +Praten(zin: string) : string
         * +Strelen() : string
         */

        // De gegevens van een kat worden als volgende tekstuele waarde weergegeven: Mijn naam is <Naam> en ik ben een <klassenaam>. Miauw! Miauw!
        public override string Gegevens
        {
            get { return base.Gegevens + " Miauw! Miauw!"; }
        }

        public Kat(string naam) : base(naam) { }

        // Wanneer een kat praat, zal deze "MAAAUWWW!" als geluid maken.
        public override string Praten(string zin)
        {
            zin = "MAAAUWWW!";
            return zin;
        }

        // Wanneer een kat gestreeld wordt, zal deze "RRR! RRRR! RRRRRRRR!" als geluid maken.
        public override string Strelen()
        {
            string strelen = "RRR! RRRR! RRRRRRRR!";
            return strelen;
        }
    }
}
