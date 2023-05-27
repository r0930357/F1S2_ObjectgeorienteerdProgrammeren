using models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            int menuKeuze, klantnummer;
            List<Klant> klanten = FileOperations.KlantenInlezen();

            Console.WriteLine("0. Alle klanten" +
            "\n1. Klant zoeken");
            Console.Write("Uw keuze: ");
            menuKeuze = int.Parse(Console.ReadLine());

            if (menuKeuze == 0)
            {
                // Lijst van klanten weergeven
                foreach (Klant k in klanten)
                {
                    Console.WriteLine($"{k.ToString()}\n");
                }
            }
            else if (menuKeuze == 1)
            {

                Console.Write("Geef klantnummer: ");
                klantnummer = int.Parse(Console.ReadLine());

                try
                {
                    // Selecteer klant met behulp van de klantnummer
                    Klant klant = FileOperations.ZoekKlantViaNummer(klantnummer);
                    Console.WriteLine(klant);
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    FileOperations.FoutLoggen(ex);
                }
            }
        }
    }
}
