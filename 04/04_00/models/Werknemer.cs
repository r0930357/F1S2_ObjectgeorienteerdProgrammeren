using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class Werknemer : Persoon
    {
        /* Werknemer
         * ------------------------------------------------
         * +Loon : double
         * +Werknemer(voornaam: string, achternaam: string)
         * ------------------------------------------------
         * +ToonGegevens() : string
         *
         * # Klasse Werknemer
         * Methode ToonGegevens()
         * Geeft de tekstuele voorstelling van het object als volgt:
         * Mijn naam is <Voornaam> <Achternaam> mijn loon bedraagt: <Loon> euro/uur.
         * Constructor
         * Het loon wordt bij een nieuwe werknemer ingesteld op 10,20 euro
         */

        // Attribuut
        private double _loon;

        //Property
        public double Loon
        {
            get { return _loon; }
            set { _loon = value; }
        }

        // Constructor
        public Werknemer(string voornaam, string achternaam) : base(voornaam, achternaam)
        {
            Loon = 10.20;
        }

        // Methode
        public override string ToonGegevens()
        {
            return base.ToonGegevens() + $"Mijn loon bedraagt: {Loon} euro/uur";
        }
    }
}
