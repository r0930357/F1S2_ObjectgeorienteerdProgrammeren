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

            int keuze;
            string invoer;

            Punt punt = new Punt();
            Cirkel cirkel = new Cirkel();
            Cilinder cilinder = new Cilinder();

            Console.Write($"0. Punt\n1. Cirkel\n2. Cilinder\n");
            
            do
            {
                Console.Write("\nGeef een optie: ");
                invoer = Console.ReadLine();
            } while (!int.TryParse(invoer, out keuze) || keuze < 0 || keuze > 2);

            switch (keuze)
            {
                case 0:
                    // Punt
                    Console.Write("X: ");
                    punt.X = double.Parse(Console.ReadLine());
                    Console.Write("Y: ");
                    punt.Y = double.Parse(Console.ReadLine());
                    Console.WriteLine(punt.ToonGegevens());
                    break;
                case 1:
                    // Cirkel
                    Console.Write("X: ");
                    cirkel.X = double.Parse(Console.ReadLine());
                    Console.Write("Y: ");
                    cirkel.Y = double.Parse(Console.ReadLine());
                    Console.Write("Straal: ");
                    cirkel.R = double.Parse(Console.ReadLine());
                    Console.WriteLine(cirkel.ToonGegevens()); 
                    break;
                case 2:
                    // Cilinder
                    Console.Write("X: ");
                    cilinder.X = double.Parse(Console.ReadLine());
                    Console.Write("Y: ");
                    cilinder.Y = double.Parse(Console.ReadLine());
                    Console.Write("Straal: ");
                    cilinder.R = double.Parse(Console.ReadLine());
                    Console.Write("Hoogte: ");
                    cilinder.H = double.Parse(Console.ReadLine());
                    Console.WriteLine(cilinder.ToonGegevens());
                    break;
            }
        }
    }
}
