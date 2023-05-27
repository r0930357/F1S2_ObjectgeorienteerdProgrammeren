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
         * +ToString() : string
         */

        private string _voornaam;
        private string _achternaam;

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

        protected Persoon(string voornaam, string achternaam)
        {
            Voornaam = voornaam;
            Achternaam = achternaam;
        }

        public override string ToString()
        {
            return $"Mijn naam is {Voornaam} {Achternaam}.";
        }
    }
}
