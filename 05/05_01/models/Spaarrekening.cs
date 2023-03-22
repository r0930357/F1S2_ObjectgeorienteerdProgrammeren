using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class Spaarrekening : Bankrekening
    {
        /* Spaarrekening
         * -------------------------
         * +Percentage : double
         * -------------------------
         * +Spaarrekening()
         * +ToonGegevens() : string
         * +SchrijfRentebij() : void
         * +ToString() : string
         */

        private double _percentage;

        public double Percentage
        {
            get { return _percentage; }
            set { _percentage = value; }
        }

        /* Constructor
         * Het percentage krijgt eens standaardwaarde van 15%
        */
        public Spaarrekening() { }

        public string ToonGegevens()
        {

        }

        public void SchrijfRentebij()
        {

        }

        /* Methode ToString()
         * Geeft de tekstuele voorstelling van het object als volgt:
         * <IbanNummer> -> Je huidig saldo bedraagt: <Saldo> euro.
         * De rentevoet bedraagt: <Percentage>%
         */
        public string ToString()
        {
            return base.ToString() + $"\nDe rentevoet bedraagt: {this.Percentage}%";
        }
    }
}
