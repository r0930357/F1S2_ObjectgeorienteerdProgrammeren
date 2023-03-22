using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class Papegaai : Dier
    {
        /* Papegaai
         * -----------------------------
         * +Gegevens : string
         * -----------------------------
         * +Papegaai(naam: string)
         * +Praten(zin: string) : string
         * +Strelen() : string
         */

        // De gegevens van een papegaai worden als volgende tekstuele waarde weergegeven: Mijn naam is <Naam> en ik ben een <klassenaam>. Krahh, C# is leuk! Krahh! Wipo!
        public override string Gegevens
        {
            get { return base.Gegevens + " Krahh, C# is leuk! Krahh! Wipo!"; }
        }

        public Papegaai(string naam) : base(naam) { }

        // Wanneer een papegaai praat, zal deze "Krahh! <zin>" als geluid maken.
        public override string Praten(string zin)
        {
            zin = $"Krahh! {zin}";
            return zin;
        }

        // Wanneer een papegaai gestreeld wordt, zal deze "Koko! koko! kokoooohh!" als geluid maken.
        public override string Strelen()
        {
            string strelen = "Koko! koko! kokoooohh!";
            return strelen;
        }
    }
}
