using models;
using System;
using System.Xml;

namespace models
{
    internal class program
    {
        static void Main(string[] args)
        {
            /* Maak een console applicatie die de gebruiker vraagt om een keuze te maken.
             * De mogelijke keuzes vind je hieronder:
             *    0: Stoppen
             *    1: Verhogen
             *    2: Verlagen
             *    3: Resetten
             * Indien de gebruiker kiest voor 1, 2 of 3 voer je de betreffende methode uit op het teller-object.
             * Indien de gebruiker kiest voor 0, stopt de applicatie en toon je de waarde van de teller.
             * Na elke keuze en actie krijgt de gebruiker opnieuw de mogelijkheid om een keuze te maken tot er 0 gekozen wordt.
            */

            // Declaratie en initalisatie van object Teller "deTeller"
            Teller deTeller = new Teller();

            // Declaratie van de variable "keuze" en initalisatie met 0
            int keuze = 0;

            // Menu weergeven en keuzegetal inlezen
            Console.WriteLine("Maak een keuze uit de volgende opties:\n\t0: stoppen\n\t1: Verhogen\n\t2: Verlagen\n\t3: Resetten");
            keuze = int.Parse(Console.ReadLine());


            // Zolang de keuze niet gelijk is aan 0, blijven we in de while-lus
            while (keuze != 0)
            {
                // Indien de keuze gelijk is aan 1, voeren we de methode "Verhoog" uit
                if (keuze == 1)
                {
                    Console.WriteLine("De waarde van de teller wordt verhoogd met 1");
                    deTeller.Verhoog();
                }
                
                // Indien de keuze gelijk is aan 2, voeren we de methode "Verlaag" uit
                else if (keuze == 2)
                {
                    Console.WriteLine("De waarde van de teller wordt verlaagd met 1");
                    deTeller.Verlaag();
                }

                // Indien de keuze gelijk is aan 3, voeren we de methode "Resetten" uit
                else if (keuze == 3)
                {
                    Console.WriteLine("De waarde van de teller wordt gereset naar 0");
                    deTeller.Resetten();
                }

                // Indien de keuze niet gelijk is aan 1, 2 of 3, geven we een foutmelding
                else
                {
                    Console.WriteLine("Deze optie bestaat niet");
                }


                // We vragen de gebruiker opnieuw om een keuze te maken uit het keuzemenu
                Console.WriteLine("Maak een keuze uit de volgende opties:\n\t0: stoppen\n\t1: Verhogen\n\t2: Verlagen\n\t3: Resetten");
                keuze = int.Parse(Console.ReadLine());
            }

            // We geven de waarde van de teller weer en vragen de gebruiker om op enter te drukken om de applicatie te stoppen
            Console.WriteLine("De applicatie stopt");
            Console.WriteLine(deTeller.ToonGegevens());
            DrukOpEnter();
        }


        // Methode DrukOpEnter -> om op enter te drukken om verder te gaan
        private static void DrukOpEnter()
        {
            Console.WriteLine("Druk op enter om verder te gaan");
            Console.ReadLine();
        }
    }
}
