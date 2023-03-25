using System;
using models;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            int keuze, blz = 0, blzPerDag = 0, speelminuten = 0, speelminutenPerDag = 0;
            string titel, auteur, verteller, output = "";
            Audioboek audio;
            Paperback paper;

            GeefKeuzeBoek();
            keuze = GeefInt("Maak een keuze: ", 1, 2);
            titel = GeefString("Titel: ");
            auteur = GeefString("Auteur: ");

            switch (keuze)
            {
                case 1:
                    blz = GeefInt("Bladzijden: ");
                    blzPerDag = GeefInt("\nBladzijden per dag: ");
                    paper = new Paperback(titel, auteur, blz, blzPerDag);
                    output = paper.ToonGegevens();
                    break;
                case 2:
                    verteller = GeefString("Verteller: ");
                    speelminuten = GeefInt("Speelminuten: ");
                    speelminutenPerDag = GeefInt("\nSpeelminuten per dag: ");
                    audio = new Audioboek(titel, auteur, verteller, speelminuten, speelminutenPerDag);
                    output = audio.ToonGegevens();
                    break;
            }
            Console.WriteLine($"\n{output}");
        }
        private static int GeefInt(string message, int min, int max)
        {
            string input;
            int nummer;
            do
            {
                Console.Write(message);
                input = Console.ReadLine();
            } while (!int.TryParse(input, out nummer) || nummer < min || nummer > max);
            return nummer;
        }
        private static int GeefInt(string message)
        {
            string input;
            int nummer;
            do
            {
                Console.Write(message);
                input = Console.ReadLine();
            } while (!int.TryParse(input, out nummer));
            return nummer;
        }
        private static string GeefString(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }
        private static void GeefKeuzeBoek()
        {
            Console.WriteLine("" +
                "1. Paperback\n" +
                "2. Audioboek\n");
        }
    }
}