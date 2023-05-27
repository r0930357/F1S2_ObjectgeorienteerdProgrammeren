using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class Werknemer : Persoon
    {
        /* Werknemer
         * --------------------------------------------------------------
         * +Loon : double
         * --------------------------------------------------------------
         * +Werknemer(voornaam: string, achternaam: string, loon: double)
         * +ToString() : string
         */

        private double _loon;

        public double Loon
        {
            get { return _loon; }
            set { _loon = value; }
        }

        public Werknemer(string voornaam, string achternaam, double loon) : base(voornaam, achternaam)
        {
            Loon = loon;
        }

        public override string ToString()
        {
            return $"Mijn naam is {base.Achternaam} {base.Voornaam} mijn loon bedraagt: {this.Loon} euro/uur.";
        }
    }
}
