using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class Controle
    {

        /* <<static>>
         * Controle
         * ------------------------------------------------------------------
         * +ControleRijksregisterNummer(rijksregisterNummer: string) : string
         * +ControleRekeningNummer(rekeningNummer : string) : string
         */

        // RIJKSREGISTERNUMMER

        /* Regels in verband met geldigheid rijksregisternummer:
         * Een rijksregisternummer is als volgt opgebouwd: yy mm dd xxx zz
         * met yy: geboortejaar
         * mm: geboortemaand
         * dd: geboortedag
         * xxx: willekeurige getallen
         * zz: controlegetal
         */

        public static string ControleRijksregisterNummer(string rijksregisterNummer)
        {
            // Neem het jaartal uit het rijksregisternummer en zet dit om naar een integer
            // Controleer of de opgegeven rijksregisternummer begint met een even of een oneven jaartal en valideer of het rijksregisternummer al dan niet gelding is
            long rijksregisterNummerJaartal = long.Parse(rijksregisterNummer.Substring(0, 2));
            if (rijksregisterNummerJaartal % 2 == 0)
            {
                /* Voor rijksregisternummers met een EVEN jaartal:
                 * Neem de eerste 9 getallen van het nummer en deel deze door 97.
                 * Van deze deling heb je de rest nodig. Trek nu die rest af van 97.
                 * Het verschil (dus 97 - rest) moet overeenkomen met het controlegetal.
                 * 
                 * Vb: rijksregisternummer 65041523034
                 * 650415230 / 97 = 6705311 rest 63
                 * 97-63 = 34 -> komt overeen met het controlegetal -> geldig rijksregisternummer
                 */

                // 650415230 34 = voorbeeld rijksregisternummer
                // 012345678 9a = array voor de prefix-substring (0 tot 9) en het controlegetal (vanaf 9 tot en met 10 (of a in dit voorbeeld))
                long rijksregisterNummerPrefix = long.Parse(rijksregisterNummer.Substring(0, 9));
                long controleGetal = long.Parse(rijksregisterNummer.Substring(9, 2));

                // Restwaarde verkrijgen aan de hand van de validatieberekening
                long validatie = rijksregisterNummerPrefix % (rijksregisterNummerPrefix / 97);

                // If-statement in een ternary operator
                rijksregisterNummer = (97 - validatie == controleGetal) ? "(geldig)" : "(ongeldig)";
            }
            else
            {
                /* Voor rijksregisternummer met een ONEVEN jaartal:
                 * Neem de cijfers op de plaats xxx (dus tussen de geboortedag en het controlegetal).
                 * Plaats voor deze getallen een 2. Deel nu dit getal door 20 en neem de rest hiervan.
                 * Het rijksregisternummer is geldig als deze rest gelijk is aan het controlegetal.
                 * 
                 * Vb. rijksregisternummer 93051822303
                 * 2223 / 20 = 111 rest 3
                 * 3 = 03 -> komt overeen met het controlegetal -> geldig rijksregisternummer
                 */

                // 930518 223 03 = voorbeeld rijksregisternummer
                // 012345 678 9a = array voor de prefix-substring (positie 6 tot 9) en het controlegetal (vanaf 9 tot en met 10 (of a in dit voorbeeld))
                long rijksregisterNummerPrefix = long.Parse(rijksregisterNummer.Substring(6, 3));
                long controleGetal = long.Parse(rijksregisterNummer.Substring(9, 2));

                // Converteer de rijksregisternummer-prefix naar een string, voeg de waarde "2" toe vooraan de string, converteer de stringwaarde naar long.
                string rijksregisterNummerPrefixToString = rijksregisterNummerPrefix.ToString();
                rijksregisterNummerPrefixToString = "2" + rijksregisterNummerPrefix;
                long.TryParse(rijksregisterNummerPrefixToString, out rijksregisterNummerPrefix);

                // Restwaarde verkrijgen aan de hand van de validatieberekening
                long validatie = rijksregisterNummerPrefix % (rijksregisterNummerPrefix / 20);

                // If-statement in een ternary operator
                rijksregisterNummer = (validatie == controleGetal) ? "(geldig)" : "(ongeldig)";
            }
            return rijksregisterNummer;
        }

        // REKENINGNUMMER

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
