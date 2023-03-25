using System;
using models;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            Medewerker medewerker = null;
            string voornaam, familienaam;
            int keuze, uurloon, vastInkomen;

            Console.WriteLine("Kies een medewerker:\n" +
                "1. Medewerker\n" +
                "2. Eigenaar");

            keuze = int.Parse(Console.ReadLine());
            voornaam = GeefNaam("Geef de voornaam: ");
            familienaam = GeefNaam("Geef de familienaam: ");
            uurloon = GeefBedrag("Geef het uurloon: ");

            switch (keuze)
            {
                case 1:
                    medewerker = new Medewerker(voornaam, familienaam, uurloon);
                    break;
                case 2:
                    vastInkomen = GeefBedrag("Geef het vast inkomen: ");
                    medewerker = new Eigenaar(voornaam, familienaam, uurloon, vastInkomen);
                    break;
            }
            Console.WriteLine(medewerker.ToonGegevens());
        }
        private static string GeefNaam(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }
        private static int GeefBedrag(string message)
        {
            string input;
            int bedrag;
            do
            {
                Console.Write(message);
                input = Console.ReadLine();
            } while (!int.TryParse(input, out bedrag));

            return bedrag;
        }
    }
}