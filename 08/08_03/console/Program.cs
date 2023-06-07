using models;
using System;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            string naam, invoer;
            int keuze, voeden = 0;
            Tamagotchi tamagotchi = null;


            Console.Write("Tamagochi\n" +
                "*********\n\n");

            Console.Write("Geef je brokje ellende een naam: ");
            naam = Console.ReadLine();

            tamagotchi = new Tamagotchi(naam);

            Console.WriteLine("\n0. Status\n" +
                "1. Voeden\n" +
                "2. Liefkozen\n" +
                "3. Straffen\n" +
                "4. Afsluiten");

            do
            {
                Console.Write("Maak een keuze: ");
                invoer = Console.ReadLine();
            } while (!int.TryParse(invoer, out keuze) || keuze < 0 || keuze > 5);

            while (keuze != 4)
            {
                switch (keuze)
                {
                    case 0:
                        Console.WriteLine(tamagotchi.Gevoel());
                        break;
                    case 1: // voeden
                        tamagotchi.Eten(voeden);
                        break;
                    case 2: // liefkozen
                        tamagotchi.Liefkozen();
                        break;
                    case 3: // straffen
                        int goedGevoel = tamagotchi.GoedGevoel;
                        tamagotchi.Straffen(goedGevoel);
                        break;
                }
                do
                {
                    Console.Write("Maak een keuze: ");
                    invoer = Console.ReadLine();
                } while (!int.TryParse(invoer, out keuze) || keuze < 0 || keuze > 5);
            }
        }
    }
}
