using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class Klant
    {
        /* Klant
         * -----------------------------------------------------------------------------------------
         * +Adres : string
         * +Naam : string
         * +Postcode : string
         * +Gemeente : string
         * +Klantnummer : int
         * -----------------------------------------------------------------------------------------
         * +Klant(klantnummer: int, naam: string, adres: string, gemeente: string, postcode: string)
         * +ToString() : string
         * +Equals(obj: object) : bool
         * +GetHashCode() : int
         */

        private string _adres;
        private string _naam;
        private string _postcode;
        private string _gemeente;
        private int _klantnummer;

        public string Adres
        {
            get { return _adres; }
            set { _adres = value; }
        }

        public string Naam
        {
            get { return _naam; }
            set { _naam = value; }
        }

        public string Postcode
        {
            get { return _postcode; }
            set { _postcode = value; }
        }

        public string Gemeente
        {
            get { return _gemeente; }
            set { _gemeente = value; }
        }

        public int Klantnummer
        {
            get { return _klantnummer; }
            set { _klantnummer = value; }
        }

        public Klant(int klantnummer, string naam, string adres, string gemeente, string postcode)
        {
            Klantnummer = klantnummer;
            Naam = naam;
            Adres = adres;
            Gemeente = gemeente;
            Postcode = postcode;
        }

        /* Methode ToString
         * Geeft een tekstuele voorstelling van het object als volgt:
         * <Klantnummer>
         * <Naam>
         * <Adres>
         * <Postcode> <Gemeente>
         */

        public override string ToString()
        {
            return $"{Klantnummer}\n" +
                $"{Naam}\n" +
                $"{Adres}\n" +
                $"{Postcode} {Gemeente}";
        }

        /* Methode Equals
         * 2 klanten zijn hetzelde indien ze beide hetzelfde klantnummer bevatten.        
         */
        public override bool Equals(object obj)
        {
            if (obj is Klant klant)
            {
                return this.Klantnummer == klant.Klantnummer;
            }
            else
            {
                return false;
            }
        }

        /* Methode GetHashCode
         * Genereer de HashCode op basis van de klantnummer.        
         */
        public override int GetHashCode()
        {
            return HashCode.Combine(Klantnummer);
        }
    }
}