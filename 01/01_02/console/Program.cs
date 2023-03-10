using models;
using System;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Maak een console applicatie waar de gebruiker een tv kan configureren.
             * Bij het starten van de applicatie wordt er een televisie-object aangemaakt.
             * De gebruiker kan nu kiezen om het kanaal of volume te verhogen of te verlagen adhv volgende opties:
             * 
             *    1: Kanaal verhogen
             *    2: Kanaal verlagen
             *    3: Volume verhogen
             *    4: Volume verlagen
             *    5: Stoppen
             *    
             * Hij kan keuzes blijven maken tot hij 5 kiest.
             * Wanneer de gebruiker 5 kiest, toon je de huidige configuratie van de televisie en sluit je de applicatie af.
            */

            // Declaratie van het object Televisie.
            Televisie televisie = new Televisie();


            // Declaratie van variabelen invoer en keuze.
            string invoer = "";
            int keuze = 0;

            // De gebruiker kan nu kiezen om het kanaal of volume te verhogen of te verlagen aan de hand van de opties in het menu.
            do
            {
                Console.WriteLine($"\nMENU\n----\nMaak uw keuze:\n\t1: Kanaal verhogen\n\t2: Kanaal verlagen\n\t3: Volume verhogen\n\t4: Volume verlagen\n\t5: Stoppen");
                invoer = Console.ReadLine();
            } while (!int.TryParse(invoer, out keuze) && keuze <= 1 || keuze > 5);

            // Zolang de gebruiker niet de optie "5: Stoppen" selecteert.
            while (keuze != 5)
            {
                // De gebruiker kan volgende opties selecteren:
                switch (keuze)
                {
                    // Menu optie 1: Kanaal verhogen.
                    case 1:
                        televisie.VermeerderKanaal();
                        break;
                    // Menu optie 2: Kanaal verlagen.
                    case 2:
                        televisie.VerminderKanaal();
                        break;
                    // Menu optie 3: Volume verhogen.
                    case 3:
                        televisie.VermeerderVolume();
                        break;
                    // Menu optie 4: Volume verlagen.
                    case 4:
                        televisie.VerminderVolume();
                        break;
                }

                // De actuele gegevens, kanaal en volume, worden weergegeven op de console.
                Console.Write(televisie.ToonGegevens());

                // De gebruiker kan terug kiezen om het kanaal of volume te verhogen of te verlagen aan de hand van de opties in het menu.
                do
                {
                    Console.WriteLine($"\nMENU\n----\nMaak uw keuze:\n\t1: Kanaal verhogen\n\t2: Kanaal verlagen\n\t3: Volume verhogen\n\t4: Volume verlagen\n\t5: Stoppen");
                    invoer = Console.ReadLine();
                } while (!int.TryParse(invoer, out keuze) && keuze <= 1 || keuze > 5);
            }

            // De gebruiker dient op enter te drukken om het consolevenster af te sluiten.
            DrukOpEnter();
        }

        public static void DrukOpEnter()
        {
            Console.WriteLine("Druk op enter om verder te gaan.");
            Console.ReadLine();
        }
    }
}
