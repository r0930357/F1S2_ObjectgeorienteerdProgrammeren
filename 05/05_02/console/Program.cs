using System;
using System.Collections.Generic;
using models;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            Dier dier = null;
            int katTeller = 0;
            int olifantTeller = 0;
            int papegaaiTeller = 0;
            string naam;

            PrintMenu();
            int keuze = GeefGetal("Maak uw keuze: ", 0, 3);

            while (keuze != 0)
            {
                switch (keuze)
                {
                    case 1:
                        Console.Write("Naam: ");
                        naam = Console.ReadLine();
                        dier = new Kat(naam);
                        katTeller++;
                        break;
                    case 2:
                        Console.Write("Naam: ");
                        naam = Console.ReadLine();
                        dier = new Olifant(naam);
                        olifantTeller++;
                        break;
                    case 3:
                        Console.Write("Naam: ");
                        naam = Console.ReadLine();
                        dier = new Papegaai(naam);
                        papegaaiTeller++;
                        break;
                }
                PrintOptie();
                int optie = GeefGetal("Maak uw keuze: ", 0, 2);
                string optieBericht = "";

                switch (optie)
                {
                    case 0:
                        optieBericht = dier.ToString(); ;
                        break;
                    case 1:
                        optieBericht = dier.Strelen(); ;
                        break;
                    case 2:
                        optieBericht = dier.Praten(""); ;
                        break;
                }
                Console.WriteLine(optieBericht);
                PrintMenu();
                keuze = GeefGetal("Maak uw keuze: ", 0, 3);
            }
            // resultaat afdrukken
            Console.Clear();

            Console.WriteLine("OVERZICHT DIERENTUIN");
            Console.WriteLine("--------------------");
            Console.WriteLine($"" +
                $"Dieren: {katTeller + olifantTeller + papegaaiTeller}\n" +
                $"Katten: {katTeller}\n" +
                $"Olifanten: {olifantTeller}\n" +
                $"Papegaaien: {papegaaiTeller}\n");
        }
        private static void PrintMenu()
        {
            Console.WriteLine("" +
                "0. Afsluiten\n" +
                "1. Kat\n" +
                "2. Olifant\n" +
                "3. Papegaai\n");
        }
        private static void PrintOptie()
        {
            Console.WriteLine("" +
                "0. Gegevens\n" +
                "1. Strelen\n" +
                "2. Praten\n");
        }
        private static int GeefGetal(string message, int min, int max)
        {
            string input;
            int output;
            do
            {
                Console.Write(message);
                input = Console.ReadLine();
            } while (!int.TryParse(input, out output) || output < min || output > max);
            return output;
        }
    }
}