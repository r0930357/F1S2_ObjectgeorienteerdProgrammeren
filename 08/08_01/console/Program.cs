using models;
using System;
using System.Numerics;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Maak een console applicatie die de zijde van een vierkant inleest.
             * Zorg voor een output die er als volgt uit ziet:
             * 
             * Input:
             * Geef een zijde: 5
             * 
             * Output:
             * Teken:
             * * * * * *
             * * * * * *
             * * * * * *
             * * * * * *
             * * * * * *
             * 
             * Omtrek: 20
             * Oppervlakte: 25
             * Diagonaal: 7,07
             */

            Vierkant vierkant = new Vierkant();

            int geefZijde = 0;

            //Console.Write("Input:\nGeef een zijde: ");
            geefZijde = int.Parse(Console.ReadLine());

            vierkant.Zijde = geefZijde;

            //Console.WriteLine("Output:");
            Console.WriteLine($"Teken:\n{vierkant.Teken()}");
            Console.WriteLine($"Omtrek: {vierkant.Omtrek()}");
            Console.WriteLine($"Oppervlakte: {vierkant.Oppervlakte()}");
            Console.WriteLine($"Diagonaal: {Math.Round(vierkant.Diagonaal(), 0)}"); 
        }
    }
}
