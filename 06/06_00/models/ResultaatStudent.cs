using System;
using System.Collections.Generic;
using System.Text;


namespace models
{
    public class ResultaatStudent
    {
        /* ResultaatStudent
         * -----------------------------------------------
         * +Naam : string
         * +Punten : double
         * +Resultaat : string
         * -----------------------------------------------
         * +ResultaatStudent(naam: string, punten: double)
         * +ResultaatStudent()
         * +ToString() : string
         */

        private string _naam;
        private double _punten;

        private string Naam
        {
            get { return _naam; }
            set { _naam = value; }
        }

        private double Punten
        {
            get { return _punten; }
            set { _punten = value; }
        }

        /* Property Resultaat
         * Deze property heeft enkel een getter en controleert of het punt kleiner of groter is dan 50.
         * Als het punt kleiner is dan 50 krijgt de gebruiker "Niet geslaagd!" te zien.
         * Als het punt groter dan of gelijk is aan 50, krijgt de gebruiker "Geslaagd!" te zien.
        */
        public string Resultaat
        {
            get
            {
                if (Punten < 50)
                {
                    return "Niet geslaagd!";
                }
                else
                {
                    return "Geslaagd!";
                }
            }
        }

        public ResultaatStudent(string naam, double punten)
        {
            Naam = naam;
            Punten = punten;
        }

        public ResultaatStudent() : this("", 0) { }

        public override string ToString()
        {
            return $"{Naam} {Punten:N2} {Resultaat}";
        }
    }
}
