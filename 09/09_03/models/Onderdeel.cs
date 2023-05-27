using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class Onderdeel
    {
        /* Onderdeel
         * -------------------------
         * +Prijs : double
         * -------------------------
         * +Onderdeel(prijs: double)
         */

        private double _prijs;

        public double Prijs
        {
            get { return _prijs; }
            set { _prijs = value; }
        }

        public Onderdeel(double prijs)
        {
            Prijs = prijs;
        }
    }
}
