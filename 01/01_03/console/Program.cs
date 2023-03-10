using models;
using System;
using System.ComponentModel;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Maak een applicatie die het mogelijk maakt om te berekenen hoeveel dagen het zou duren om een boek uit te lezen.
             * Er wordt de gebruiker de vraag gesteld om een boek toe te voegen.
             * Van een boek willen we de titel, auteur en aantal bladzijden bijhouden.
             * Vraag nu aan de gebruiker hoeveel bladzijden hij per dag leest.
             * Het programma toont als resultaat de info van het boek en hoeveel dagen het zou duren om het boek uit te lezen.
             */

            // Declaratie van de variabelen "titel", "auteur", "paginas" en "bladzijdenPerDag".
            Boek boek = new Boek();

            int bladzijden, dagen, bladzijdenPerDag = 0;

            // Vraag aan de gebruiker om de titel van het boek in te geven.
            Console.Write("Geef de titel van het boek:");
            boek.Titel = Console.ReadLine();
            Console.Write("Geef de auteur van het boek:");
            boek.Auteur = Console.ReadLine();
            Console.Write("Hoeveel pagina's telt het boek?");
            boek.Paginas = int.Parse(Console.ReadLine());
            Console.Write("Hoeveel pagina's leest u per dag?");
            bladzijdenPerDag = int.Parse(Console.ReadLine());

            // Berekenen van de variabelen "bladzijden" en "dagen".
            bladzijden = boek.Paginas * 2;
            dagen = bladzijden / bladzijdenPerDag;

            // Toon de informatie van het boek en hoeveel dagen het zou duren om het boek uit te lezen.           
            Console.WriteLine($"Titel: {boek.Titel}");
            Console.WriteLine($"Auteur: {boek.Auteur}");
            Console.WriteLine($"Paginas: {boek.Paginas}");
            Console.WriteLine($"Het boek telt {bladzijden} bladzijden.");
            Console.WriteLine($"Aantal dagen om het boek uit te lezen: {dagen} dagen.");

            DrukOpEnter();
        }

        private static void DrukOpEnter()
        {
            Console.WriteLine("Druk op een toets om het programma te beëindigen.");
            Console.ReadLine();
        }
    }
}
