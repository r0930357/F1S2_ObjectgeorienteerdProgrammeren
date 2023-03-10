using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class Rijksregisternummer
    {

        /* Regels in verband met geldigheid rijksregisternummer:
         * Een rijksregisternummer is als volgt opgebouwd: yy mm dd xxx zz
         * met yy: geboortejaar
         * mm: geboortemaand
         * dd: geboortedag
         * xxx: willekeurige getallen
         * zz: controlegetal
         */
     
        /* Voor rijksregisternummers met een even jaartal:
         * Neem de eerste 9 getallen van het nummer en deel deze door 97.
         * Van deze deling heb je de rest nodig. Trek nu die rest af van 97.
         * Het verschil (dus 97 - rest) moet overeenkomen met het controlegetal.
         * 
         * Vb: rijksregisternummer 65041523034
         * 650415230 / 97 = 6705311 rest 63
         * 97-63 = 34 -> komt overeen met het controlegetal -> geldig rijksregisternummer
         */
        public static string RijksregisternummerEvenJaartal(string rijksregisterNummer)
        {

            // 650415230 34 = voorbeeld rijksregisternummer
            // 012345678 9a = array voor de prefix-substring (0 tot 9) en het controlegetal (vanaf 9 tot en met 10 (of a in dit voorbeeld))
            long rijksregisterNummerPrefix = long.Parse(rijksregisterNummer.Substring(0, 9));
            long controleGetal = long.Parse(rijksregisterNummer.Substring(9, 2));

            // Restwaarde verkrijgen aan de hand van de validatieberekening
            long validatie = (rijksregisterNummerPrefix / 97);
            long restwaarde = (rijksregisterNummerPrefix % validatie);

            // If-statement in een ternary operator
            rijksregisterNummer = (97 - restwaarde == controleGetal) ? "(gelding)" : "(ongeldig)";
            return rijksregisterNummer;
        }

        /* Voor rijksregisternummer met een oneven jaartal:
         * Neem de cijfers op de plaats xxx (dus tussen de geboortedag en het controlegetal).
         * Plaats voor deze getallen een 2. Deel nu dit getal door 20 en neem de rest hiervan.
         * Het rijksregisternummer is geldig als deze rest gelijk is aan het controlegetal.
         * 
         * Vb. rijksregisternummer 93051822303
         * 2223 / 20 = 111 rest 3
         * 3 = 03 -> komt overeen met het controlegetal -> geldig rijksregisternummer
         */
        public static string RijksregisternummerOnevenJaartal(string rijksregisterNummer)
        {

            // 930518 223 03 = voorbeeld rijksregisternummer
            // 012345 678 9a = array voor de prefix-substring (positie 6 tot 9) en het controlegetal (vanaf 9 tot en met 10 (of a in dit voorbeeld))
            long rijksregisterNummerPrefix = long.Parse(rijksregisterNummer.Substring(6, 3));
            long controleGetal = long.Parse(rijksregisterNummer.Substring(9, 2));

            // Voeg 2 toe voor het prefix-getal door de rijksregisterNummerPrefix te converteren naar een stringwaarde, 2 toe te voegen en terug te converteren naar long.
            string rijksregisterNummerPrefixToString = rijksregisterNummerPrefix.ToString();
            rijksregisterNummerPrefixToString = "2" + rijksregisterNummerPrefix;
            long.TryParse(rijksregisterNummerPrefixToString, out rijksregisterNummerPrefix);

            // Restwaarde verkrijgen aan de hand van de validatieberekening
            long validatie = rijksregisterNummerPrefix / 20;
            long restwaarde = (rijksregisterNummerPrefix % validatie);

            // If-statement in een ternary operator
            rijksregisterNummer = (restwaarde == controleGetal) ? "(gelding)" : "(ongeldig)";
            return rijksregisterNummer;
        }
    }
}
