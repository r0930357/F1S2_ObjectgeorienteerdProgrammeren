using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class Persoon
    {
        /* Persoon
         * ----------------------------------------------
         * +Voornaam : string
         * +Achternaam : string
         * ----------------------------------------------
         * #Persoon(voornaam: string, achternaam: string)
         * +ToonGegevens() : string
         */

        // Attributen
        private string _voornaam;
        private string _achternaam;

        //Properties
        public string Voornaam
        {
            get { return _voornaam; }
            set { _voornaam = value; }
        }
        public string Achternaam
        {
            get { return _achternaam; }
            set { _achternaam = value; }
        }

        // Constructor
        protected Persoon(string voornaam, string achternaam)
        {
            Voornaam = voornaam;
            Achternaam = achternaam;
        }

        //Methodes
        /* Methode ToonGegevens()
         * Geeft de tekstuele voorstelling van het object als volgt
         * Mijn naam is <Voornaam> <Achternaam>
         */
        public virtual string ToonGegevens()
        {
            return $"Mijn naam is {Voornaam} {Achternaam}";
        }
    }
}
