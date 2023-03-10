using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class Rekeningnummer
    {

        /* Regels ivm geldigheid met geldigheid Iban:
         * 
         * Een iban is correct wanneer de laatste 2 cijfers van de Iban gelijk zijn aan de rest van volgende deling: getal gevormd door de eerste 10 cijfers van de iban / 97.
         * 
         * Vb. Iban 979-9315445-55
         * 9799315445 / 97 = 55 -> Geldige iban
         */

        public static string ControleRekeningNummer(string rekeningNummer)
        {
            // 9799315445 55 = voorbeeld rekeningnummer
            // 0123456789 ab = array voor de prefix-substring (0 tot a) en het controlegetal (vanaf a tot en met b (of a in dit voorbeeld))
            long rekeningNummerPrefix = long.Parse(rekeningNummer.Substring(0, 10));
            long controleGetal = long.Parse(rekeningNummer.Substring(10, 2));

            // Rekeningnummer valideren aan de hand van de validatieberekening
            long validatie = (rekeningNummerPrefix / 97);
            
            // If-statement in een ternary operator
            rekeningNummer = (controleGetal == rekeningNummerPrefix % validatie) ? "(geldig)" : "(ongeldig)";
            return rekeningNummer;
        }
    }
}
