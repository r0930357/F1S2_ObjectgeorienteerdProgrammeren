using models;
using DAL;
using System;
using System.Collections.Generic;
using System.IO;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Bij het opstarten van de applicatie krijgt de gebruiker een menu met de volgende opties:
             * 
             * Wat wil je doen?
             * ----------------
             * 1. Resultaat afdrukken
             * 2. Afsluiten
             * 
             * Bij het ingeven van 1 krijgt de gebruiker een lijst te zien met de naam van de student, de score en of de student geslaagd is of niet.
             * Het bestand wordt ingelezen via de methode ReadFile(string filename).
             * Voorzie ook een methode die de keuze van de gebruiker gaat verwerken.
             * Deze methode noem je ReadChoice(int choice) en gaat de lijst afdrukken of de applicatie afsluiten.
             * Een regel ziet er als volgt uit: <Naam> <Score> <Resultaat>
            */

            int keuze;
            string invoer, bericht = "Wat wil je doen?";

            Console.WriteLine($"{bericht}\n" +
                $"{new string('-', bericht.Length)}\n" +
                $"1. Resultaat afdrukken\n" +
                $"2. Afluiten\n");

            do
            {
                Console.Write("Keuze: ");
                invoer = Console.ReadLine();
            } while (!int.TryParse(invoer, out keuze) || keuze < 1 || keuze > 2);

            if (keuze == 1)
            {
                List<ResultaatStudent> studenten = FileOperations.LeesStudenten();

                foreach(ResultaatStudent student in studenten)
                {
                    Console.WriteLine(student.ToString());
                }
            }
        }
    }
}
