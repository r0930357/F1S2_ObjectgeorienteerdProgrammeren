using System;
using System.Collections.Generic;
//using System.Text;

namespace models
{
    public class Personeelslid
    {

        /* Personeelslid
         * ----------------------------------------------------------------------
         * +Familienaam : string
         * +Voornaam : string
         * +IsStagair : bool
         * ----------------------------------------------------------------------
         * +Personeelslid(voornaam: string, familienaam: string, isStagair: bool)
         * +ToString() : string
         * +Equals(obj: object) : bool
         * +GetHashCode() : int
         */

        private string _familienaam;
        private string _voornaam;
        private bool _isStagair;

        public string Familienaam
        {
            get { return _familienaam; }
            set { _familienaam = value; }
        }

        public string Voornaam
        {
            get { return _voornaam; }
            set { _voornaam = value; }
        }

        public bool IsStagair
        {
            get { return _isStagair; }
            set { _isStagair = value; }
        }

        public Personeelslid(string voornaam, string familienaam, bool isStagair)
        {
            Voornaam = voornaam;
            Familienaam = familienaam;
            IsStagair = isStagair;
        }

        /* Methode ToString
         * Deze methode geeft een tekstuele weergave van het object als volgt: <Voornaam> <Familienaam> (<Functie>)
         * waarbij de functie "Stagair" of "Vaste medewerker" is obv van de bijhorende property.
         */
        public override string ToString()
        {
            string stagair = (IsStagair == true) ? "Stagair" : "Vaste medewerker";
            return $"{Voornaam} {Familienaam} ({stagair})";
        }

        /* Methode Equals en GetHashCode
         * Deze methodes controleren of twee objecten hetzelfde zijn.
         * Twee objecten zijn hetzelfde als ze dezelfde voornaam en familienaam hebben.
         */
        public override bool Equals(object obj)
        {
            if (obj is Personeelslid personeelslid)
            {
                return this.Voornaam == personeelslid.Voornaam &&
                    this.Familienaam == personeelslid.Familienaam;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Voornaam, Familienaam);
        }
    }
}
