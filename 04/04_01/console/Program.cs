using System;
using models;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Bij het opstarten van de applicatie krijgt de gebruiker een menu met de volgende opties:
             * - 0. Punt
             * - 1. Cirkel
             * - 2. Cilinder
             * 
             * Afhankelijk van de keuze, worden de benodigde gegevens opgevraagd.
             * Ingegeven waardes moeten numeriek zijn en groter dan 0.
             * Hierna word een object aangemaakt met opgevraagde waardes en word deze vervolgens getoond.
             */

            // Declaratie van de variabelen
            int keuze;
            double X, Y, straal, hoogte;
            string invoer = "", weergave = "";

            // Initiatie van de objecten
            Punt punt;
            Cirkel cirkel;
            Cilinder cilinder;

            // Keuzemenu
            Console.Write($"0. Punt\n1. Cirkel\n2. Cilinder\n");

            // Keuze controleren
            keuze = MenuKeuze(invoer, 0, 2);

            // Selectie op basis van keuze
            switch (keuze)
            {
                case 0:
                    // Punt
                    Console.Write("X: ");
                    X = double.Parse(Console.ReadLine());
                    Console.Write("Y: ");
                    Y = double.Parse(Console.ReadLine());
                    punt = new Punt(X, Y);
                    weergave = punt.ToonGegevens();
                    break;
                case 1:
                    // Cirkel
                    Console.Write("X: ");
                    X = double.Parse(Console.ReadLine());
                    Console.Write("Y: ");
                    Y = double.Parse(Console.ReadLine());
                    Console.Write("Straal: ");
                    straal = double.Parse(Console.ReadLine());
                    cirkel = new Cirkel(X, Y, straal);
                    weergave = cirkel.ToonGegevens();
                    break;
                case 2:
                    // Cilinder
                    Console.Write("X: ");
                    X = double.Parse(Console.ReadLine());
                    Console.Write("Y: ");
                    Y = double.Parse(Console.ReadLine());
                    Console.Write("Straal: ");
                    straal = double.Parse(Console.ReadLine());
                    Console.Write("Hoogte: ");
                    hoogte = double.Parse(Console.ReadLine());
                    cilinder = new Cilinder(X, Y, straal, hoogte);
                    weergave = cilinder.ToonGegevens();
                    break;
            }

            //Weergave van het resultaat in de console
            Console.WriteLine(weergave);
        }

        // Methode: Menukeuze
        private static int MenuKeuze(string invoer, int min, int max)
        {
            int keuze;
            do
            {
                Console.Write("Maak uw keuze: ");
                invoer = Console.ReadLine();
            } while (!int.TryParse(invoer, out keuze) || keuze < min || keuze > max);
            return keuze;

        }
    }
}
