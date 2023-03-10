using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace models
{
    public class Klant : Persoon
    {
        /* Klant
         * --------------------------------------------
         * -KlantenCode : string
         * --------------------------------------------
         * +Klant(voornaam: string, achternaam: string)
         * -MaakRandomKlantenCode() : void
         * +ToonGegevens() : string
         * 
         * #Klasse Klant
         * Methode ToonGegevens()
         * Geeft de tekstuele voorstelling van het object als volgt
         * Mijn naam is <Voornaam> <Achternaam> mijn klanten code: <KlantenCode>.
         * Methode MaakRandomKlantenCode
         * Deze methode zal KlantenCode opvullen met een random string van 16 characters
         * Constructor
         * De klantencode wordt ingevuld met een willekeurige klantencode.
         * Maak gebruik van de methode MaakRandomKlantenCode().
        */

        // Attribuut
        private string _klantcode;

        //Property
        private string Klantcode
        {
            get { return _klantcode; }
            set { _klantcode = value; }
        }

        // Constructor
        public Klant(string voornaam, string achternaam) : base(voornaam, achternaam)
        {
            MaakRandomKlantCode();
        }

        //Methode
        private void MaakRandomKlantCode()
        {
            string toegelatenKarakters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            char[] klantencode = new char[16];

            Random random = new Random();

            for (int i = 0; i < klantencode.Length; i++)
            {
                klantencode[i] = toegelatenKarakters[random.Next(toegelatenKarakters.Length)];
            }
            Klantcode = new string(klantencode);
        }

        // Methode
        public override string ToonGegevens()
        {
            return base.ToonGegevens() + $" mijn klantencode: {Klantcode}";
        }
    }
}
