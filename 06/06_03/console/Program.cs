using models;
using System;
using System.Collections.Generic;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Memory> spel = FileOperations.LeesBestand(KiesSpel());
            if (spel.Count == 0)
            {
                return;
            }

            Memory beurt = null;
            int puntenSpeler = 0, puntenComputer = 0;
            string goed = "";
            for (int i = 0; i < spel.Count; i++)
            {
                beurt = Speel();
                if (Memory.Equals(spel[i], beurt))
                {
                    goed = "goed";
                    puntenSpeler++;
                }
                else
                {
                    goed = "niet goed";
                    puntenComputer++;
                }

                Console.WriteLine($"\nU heeft {goed} gegokt! " +
                $"De kaart was van de kleur {spel[i].Kleur} met een waarde van {spel[i].Waarde} en {spel[i].Soort} als soort.");
                Console.WriteLine($"\nComputer: {puntenComputer} - Speler: {puntenSpeler}\n");

                string winnaar = "";
                if (puntenSpeler == 3)
                {
                    Console.WriteLine($"Einde spel. De speler is de winnaar!");
                    return;
                }
                else if (puntenComputer == 3)
                {
                    Console.WriteLine($"Einde spel. De computer is de winnaar!");
                    return;
                }

            }
        }
        private static string KiesSpel()
        {
            Console.Write("Kies een spel (spel-1.txt, spel-2.txt, of spel-3.txt): ");
            return Console.ReadLine();
        }
        private static Memory Speel()
        {
            Memory gok = null;
            string input;
            int waarde;

            do
            {
                Console.Write("Geef een waarde: ");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out waarde));

            Console.Write("Geef een soort: ");
            string soort = Console.ReadLine();

            Console.Write("Geef een kleur: ");
            string kleur = Console.ReadLine();

            return gok = new Memory(waarde, soort, kleur);
        }

    }
}