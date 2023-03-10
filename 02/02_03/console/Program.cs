using models;
using System;
using System.Net.Security;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Maak een applicatie die het mogelijk maakt om de gegevens bij te houden in verhouding met het onderhoud van een auto.
             * De gebruiker de mogelijkheid om te kiezen uit een menu.
             * Hierbij kan er gekozen worden om een aantal kilometers toe te voegen aan de kilometerstand.
             * Hierna word een overzicht afgedrukt waarbij de status van de auto word weergegeven.
             */

            // Declaratie van variabelen
            Auto auto = new Auto();
            double brandstof;
            int kilometers, onderhoud, keuze;
            
            // Allereerst geeft de gebruiker de hoeveelheid brandstof(in liter), huidig kilometerstand(in kilometer) en de kilometerstand(in kilometer) van het laatste onderhoud op.
            // Hoeveelheid brandstof
            Console.Write("Geef hoeveelheid branfstof: ");
            brandstof = double.Parse(Console.ReadLine());
            auto.Brandstofstand = brandstof;

            // Kilometerstand
            Console.Write("Geef huidige kilometerstand: ");
            kilometers = int.Parse(Console.ReadLine());
            auto.Kilometerstand = kilometers;

            // Onderhoud
            Console.Write("Geef kilometerstand laatste onderhoud: ");
            onderhoud = int.Parse(Console.ReadLine());
            auto.Onderhoudsstand = onderhoud;

            // Vervolgens heeft de gebruiker de mogelijkheid om te kiezen uit een menu.
            Console.WriteLine($"\nOpties\n---------------\n0. Stoppen\n1. Voeg 25 kilometer toe\n2. Voeg 100 kilometer toe\n3. Voeg 1000 kilometer toe\n4. Vul brandstof aan\n5. Voer onderhoud uit");
            keuze = VraagOptieOp();

            // Hierbij kan er gekozen worden om een aantal kilometers toe te voegen aan de kilometerstand.
            auto.KeuzeMenu(keuze);

            // Hierna word een overzicht afgedrukt waarbij de status van de auto word weergegeven.
            Console.Clear();
            Console.WriteLine(auto.ToonStatus());
        }

        private static int VraagOptieOp()
        {
            int optie;
            string invoer;

            do
            {
                Console.Write("\nGeef een keuze: ");
                invoer = Console.ReadLine();
            } while (!int.TryParse(invoer, out optie) && optie <= 0 || optie > 5);
            return optie;
        }
    }
}
