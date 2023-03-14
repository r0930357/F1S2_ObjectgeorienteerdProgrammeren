using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class Volkswagen : Auto
    {
        /* Volkswagen
         * -----------------------------------------------------------------------------------------------------
         * +Volkswagen(nummerplaat: string, aantalKilometers: double, kostPrijs: double, literBrandstof: double)
         * +Rijden(aantalKilometer: double)
        */

        // Constructor
        // Maak gebruik van de constructor van de superklasse.
        public Volkswagen(string nummerplaat, double aantalKilometers, double kostPrijs, double literBrandstof) : base(nummerplaat, aantalKilometers, kostPrijs, literBrandstof) { }

        //Methode

        /* Methode Rijden(double aantalKilometer)
         * Deze methode zal kilometers toevoegen aan het totale aantal en vervolgens de hoeveelheid brandstof verrekenen waarbij er bij 25 kilometer 1 liter verbruikt is.
         * public override void Rijden(double aantalKimeter)
         */

        public override void Rijden(double aantalKilometer)
        {
            this.Aantalkilometer += aantalKilometer;
            this.Literbrandstof -= (aantalKilometer / 25);
        }
    }
}
