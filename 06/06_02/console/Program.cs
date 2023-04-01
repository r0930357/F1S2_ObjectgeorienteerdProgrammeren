using models;
using System;
using System.Collections.Generic;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Cursist> cursisten = FileOperations.LeesCursisten();
            int keuze;

            Console.WriteLine("Cursisten\n" +
                              "---------\n");
            PrintCursisten(cursisten);

            keuze = PrintOptions();

            if (keuze == 0)
            {
                // Cursist toevoegen
                AddCursist(cursisten);
            }
            else
            {
                // Cursist verwijderen
                DeleteCursist(cursisten);
            }

            Console.Clear();
            Console.WriteLine("Nieuwe lijst van cursisten\n" +
                              "--------------------------\n");
            PrintCursisten(cursisten);
        }

        /* Deze methode toont de 2 opties aan de gebruiker, namelijk 'Toevoegen' en 'Verwijderen'.
         * Deze methode geeft een int terug met daarin de keuze die de gebruiker gemaakt heeft (0 of 1).
         * Voorzie hier ook dat er gecontroleerd wordt of er effectief een getal ingegeven wordt.
         */
        private static int PrintOptions()
        {
            string invoer;
            int keuze;
            do
            {
                Console.Write("\n0. Toevoegen\n" +
                              "1. Verwijderen\n\n" +
                              "Maak een keuze: ");
                invoer = Console.ReadLine();
            } while (!int.TryParse(invoer, out keuze) || keuze < 0 || keuze > 1);
            return keuze;
        }

        /* Deze methode bevat de logica om een cursist toe te voegen.
         * De gebruiker kan hier een voornaam en familenaam ingeven, en vervolgens wordt er een nieuw object van de klasse Cursist aangemaakt.
         * Zorg er ook voor dat cursisten niet dezelfde cursistId hebben!
         */
        private static void AddCursist(List<Cursist> cursisten)
        {
            string voornaam, familienaam;
            int cursistID;

            cursistID = cursisten.Count + 1;

            Console.Write("Geef de voornaam van de nieuwe cursist: ");
            voornaam = Console.ReadLine();

            Console.Write("Geef de familienaam van de nieuwe cursist: ");
            familienaam = Console.ReadLine();

            // Nieuw leeg object maken
            Cursist cursist = null;

            // Ingevoerde gegevens bij de lijst "cursisten" voegen.
            cursisten.Add(cursist = new Cursist(cursistID, voornaam, familienaam));
        }

        /* Deze methode bevat de logica om een cursist te verwijderen.
         * De gebruiker moet hier een getal ingeven, dat overeenkomt met de cursistId van een cursist.
         * Zorg er ook voor dat de cursistId van de resterende cursisten wordt bijgewerkt.
         * Enkel de cursist met cursistId 1 mag niet aangepast worden.
         * Tip: gebruik voor de cursist te verwijderen for (int i = 0; i < cursisten.Count; i++) { ... }.
         * In deze lus controleer je of de cursistId van de huidige cursist overeenkomt met de ingegeven cursistId.
         */
        private static void DeleteCursist(List<Cursist> cursisten)
        {
            string invoer;
            int keuze;

            do
            {
                Console.Write("Geef de cursistId van de cursist die je wil verwijderen: ");
                invoer = Console.ReadLine();
            } while (!int.TryParse(invoer, out keuze) || keuze < 1 || keuze > cursisten.Count);

            // Cursist verwijderen (--keuze) => positie i + 1
            cursisten.RemoveAt(--keuze);

            // lijst Cursisten doorlopen en hernummeren
            for (int i = 0; i < cursisten.Count; i++)
            {
                cursisten[i].CursistID = i + 1;
            }
        }

        /* Deze methode print alle cursisten af.
         * Aangezien we dit meerdere keren doen in onze applicatie, is het handig om deze code in een methode te steken.
         */
        private static void PrintCursisten(List<Cursist> cursisten)
        {
            foreach (Cursist cursist in cursisten)
            {
                Console.WriteLine(cursist.ToString());
            }
        }
    }
}
