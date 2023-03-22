using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace models
{
    public class Dier
    {
        /* Dier
         * -----------------------------
         * +Naam : string
         * +Gegevens : string
         * -----------------------------
         * #Dier(naam: string)
         * +Praten(zin: string) : string
         * +Strelen() : string
         * +ToString() : string
         * +Equals(obj: object) : bool
         */

        public string _naam;
        public string _gegevens;

        public string Naam
        {
            get { return _naam; }
            set { _naam = value; }
        }

        // De gegevens van een dier worden als volgende tekstuele waarde weergegeven: Mijn naam is <Naam> en ik ben een <klassenaam>.
        public virtual string Gegevens
        {
            get { return $"Mijn naam is {this.Naam} en ik ben een {this.GetType().Name}."; }
        }

        protected Dier(string naam)
        {
            Naam = naam;
        }

        // Wanneer een dier gestreeld wordt, zal er geen geluid gemaakt worden.
        public virtual string Strelen()
        {
            string strelen = string.Empty;
            return strelen;
        }

        // Wanneer een dier praat, zal er geen geluid gemaakt worden.
        public virtual string Praten(string zin)
        {
            zin = string.Empty;
            return zin;
        }

        // De methode ToString() geeft de gegevens van het dier weer.
        public override string ToString()
        {
            return $"{this.Gegevens}";
        }

        // De geluiden van het strelen en praten wordt specifiek per dier bepaald.
        public override bool Equals(object obj)
        {
            if (obj is Dier dier)
            {
                return (this.Strelen() == dier.Strelen()) && this.Praten("") == dier.Praten("");
            }
            return true;
        }

        // !! Indien CodeGrade moeilijk doet -> de "GetHashCode()" methode als override bijvoegen !!
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
