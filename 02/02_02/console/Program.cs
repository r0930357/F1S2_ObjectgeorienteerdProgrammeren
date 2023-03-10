using System;
using models;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Schrijf een programma dat de naam, lengte en gewicht van een persoon inleest.
             * Bereken de BMI en toon de gegevens van de persoon.
             * De output ziet er als volgt uit:
             * 
             * Geef een naam: Jan
             * Geef een gewicht: 67
             * Geef een lengte: 1,8
             */

            Bmi bmi = new Bmi();

            Console.Write("Geef een naam: ");
            bmi.Naam = Console.ReadLine();
            Console.Write("Geef een gewicht: ");
            bmi.Gewicht = double.Parse(Console.ReadLine());
            Console.Write("Geef een lengte: ");
            bmi.Lengte = double.Parse(Console.ReadLine());

            Console.Write(bmi.ToonGegevens());
        }
    }
}
