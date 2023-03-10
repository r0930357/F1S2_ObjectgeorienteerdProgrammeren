using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class Persoonsgegevens
    {
        /* Klassendiagram
         * ---------------------------------------
         * +rijksregisternummer : string
         * +rekeningnummer : string
         * ---------------------------------------
         * Persoonsgegevens()
         * +RekeningnummerControle() : string
         * +RijksregisterNummerControle() : string
         * ---------------------------------------
        */

        public string _rijksregisternummer;
        public string _rekeningnummer;

        public string Rijksregisternummer
        {
            get { return _rijksregisternummer; }
            set { _rekeningnummer = value; }
        }

        public string Rekeningnummer
        {
            get { return _rekeningnummer; }
            set { _rekeningnummer = value; }
        }

        public Persoonsgegevens()
        {
            Rijksregisternummer = _rijksregisternummer;
            Rekeningnummer= _rekeningnummer;
        }

        public string RekeningnummerControle()
        {
            // De opgegeven rijksregisternummer ontdoen van de typische tekens, zoals "-" of een spatie aan het begin of einde.
            // Met het while-statement wordt gecontroleerd of het opgegeven rijksregisternummer voldoet aan de wettige lengte van 12 karakters.
            do
            {
                Rekeningnummer = Rekeningnummer.Replace("-", "");
                Rekeningnummer = Rekeningnummer.Trim();
            } while (string.IsNullOrWhiteSpace(Rekeningnummer) || Rekeningnummer.Length != 12);

            Rekeningnummer = ; 
            return Rekeningnummer; // returnwaarde = (geldig) of (ongeldig)

        }

        public string RijksregisterNummerControle()
        {
            // De opgegeven rijksregisternummer ontdoen van de typische tekens, zoals "-", "." of een spatie aan het begin of einde.
            // Met het while-statement wordt gecontroleerd of het opgegeven rijksregisternummer voldoet aan de wettige lengte van 11 karakters.
            do
            {
                Rijksregisternummer = Rijksregisternummer.Replace("-", "");
                Rijksregisternummer = Rijksregisternummer.Replace(".", "");
                Rijksregisternummer = Rijksregisternummer.Trim();
            } while (string.IsNullOrWhiteSpace(Rijksregisternummer) || Rijksregisternummer.Length != 11);
           
            // Neem het jaartal uit het rijksregisternummer en zet dit om naar een integer
            int controleRijksregisterNummer = int.Parse(Rijksregisternummer.Substring(0, 1));

            // If-statement in een ternary operator

            Rijksregisternummer = (controleRijksregisterNummer % 2 == 0) ? ) Rijksregisternummer.RijksregisternummerEvenJaartal() 
            return Rijksregisternummer; // returnwaarde = (geldig) of (ongeldig)
        }
    }
}
