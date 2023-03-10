using System;

namespace models
{
    public class Bmi
    {

        /* Ontwerp klasse
         * Bmi
         * --------------------------------------------------
         * +Gewicht : double
         * +Lengte : double
         * +Naam : string
         * --------------------------------------------------
         * +Bmi()
         * +Bmi(naam: string, weight: double, length: double)
         * +BerekenBmi() : double
         * +ToonGegevens() : string
         * --------------------------------------------------
         */


        public double _gewicht;
        public double _lengte;
        public string _naam;

        public double Gewicht
        {
            get { return _gewicht; }
            set { _gewicht = value; }
        }

        public double Lengte
        {
            get { return _lengte; }
            set { _lengte = value; }
        }

        public string Naam
        {
            get { return _naam; }
            set { _naam = value; }
        }

        public Bmi(string naam, double weight, double length)
        {
            Naam = naam;
            Gewicht = weight;
            Lengte = length;
        }

        public Bmi() : this("", 0, 0) { }

        /* Bereken de BMI als volgt: <Gewicht> / <Lengte>2.
         * Rond af tot op 1 cijfer na de komma.Gebruik hiervoor de methode Math.Round.
         */

        public double BerekenBmi()
        {
            double bmi;
            bmi = Gewicht / Math.Pow(Lengte, 2);
            return Math.Round(bmi, 1);
        }

        public string ToonGegevens()
        {
            string gegevens = $"{Naam} weegt {Gewicht} kg en is {Lengte} m groot. De BMI is {BerekenBmi()}.";
            return gegevens;
        }
    }
}
