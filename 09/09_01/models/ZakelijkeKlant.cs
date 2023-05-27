using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class ZakelijkeKlant : Klant
    {
        /* ZakelijkeKlant
         * ---------------------------------------------------------------------------------------------------------------------
         * +BtwNummer : string
         * ---------------------------------------------------------------------------------------------------------------------
         * +ZakelijkeKlant(klantnummer: int, naam: string, adres: string, gemeente: string, postcode: string, btwNummer: string)
         */

        private string _btwNummer;

        /* Property BtwNummer
         * Gooi een OngeldigBtwNummerException indien de eerste 2 karakters niet 'BE' zijn.
         */
        public string BtwNummer
        {
            get { return _btwNummer; }
            set
            {
                if (BtwNummer.Substring(0, 2) != "BE")
                {
                    throw new OngeldigBtwNummerException("Geen geldige BTW nummer");
                }
                else
                {
                    _btwNummer = value;
                }
            }
        }

        public ZakelijkeKlant(int klantnummer, string naam, string adres, string gemeente, string postcode, string btwNummer) : base(klantnummer, naam, adres, gemeente, postcode)
        {
            BtwNummer = btwNummer;
        }
    }
}
