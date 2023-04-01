using System;
using models;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Globalization;
using System.Diagnostics.CodeAnalysis;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {

            // Laad de lijsten uit de textbestanden in
            List<string> siroop = FileOperations.LeesOpties(FileOperations.BestandSiropen);
            List<string> topping = FileOperations.LeesOpties(FileOperations.BestandToppings);
            List<string> smaken = FileOperations.LeesOpties(FileOperations.BestandSmaken);
            List<string> glazuur = FileOperations.LeesOpties(FileOperations.BestandGlazuren);
            List<string> vullingen = FileOperations.LeesOpties(FileOperations.BestandVullingen);

            // Declaratie van de variabele "keuze"
            int keuze;

            // Keuzemenu => Donut of koffie
            Console.WriteLine("0. Donut\n" +
                              "1. Koffie\n");
            keuze = KeuzeMenu();
            Console.WriteLine($"Uw keuze is {keuze}");

            if (keuze == 0)
            {
                // Indien donut
                // Vraag de gebruiker om hun keuzes te maken voor de donut
                // Geef de opties weer en vraag om een keuze voor elk van de opties
                int keuzeSiroop = KeuzeSelectie(siroop, "siroop");
                int keuzeTopping = KeuzeSelectie(topping, "topping");
                int keuzeGlazuur = KeuzeSelectie(glazuur, "glazuur");
                int keuzeVulling = KeuzeSelectie(vullingen, "vulling");

                // Maak een nieuwe Donut instantie met de gekozen siroop, topping, glazuur en vulling
                // Constructor = public Donut(string siroop, string topping, string glazuur, string vulling) : base(siroop, topping)
                Donut donut = new Donut(siroop[keuzeSiroop], topping[keuzeTopping], glazuur[keuzeGlazuur], vullingen[keuzeVulling]);

                // Druk het overzicht van de bestelling in de console
                ToonBestelling(donut.ToonOverzicht());
            }
            else if (keuze == 1)
            {
                // Indien koffie
                // Vraag de gebruiker om hun keuzes te maken voor de koffie
                // Geef de opties weer en vraag om een keuze voor elk van de opties
                int keuzeSiroop = KeuzeSelectie(siroop, "siroop");
                int keuzeTopping = KeuzeSelectie(topping, "topping");
                int keuzeGlazuur = KeuzeSelectie(smaken, "smaak");
                bool keuzeSlagroom = metSlagroom();

                // Maak een nieuwe Koffie instantie met de gekozen siroop, toppings, smaken en metSlagroom
                // Constructor = public Koffie(string siroop, string topping, string smaak, bool metSlagroom) : base(siroop, topping)
                Koffie koffie = new Koffie(siroop[keuzeSiroop], topping[keuzeTopping], glazuur[keuzeGlazuur], keuzeSlagroom);

                // Druk het overzicht van de bestelling in de console
                ToonBestelling(koffie.ToonOverzicht());
            }
        }

        public static int KeuzeMenu()
        {
            int keuze;
            string invoer;
            do
            {
                Console.Write("Geef een optie op: ");
                invoer = Console.ReadLine();
            } while (!int.TryParse(invoer, out keuze) || keuze < 0 || keuze > 1);
            return keuze;
        }

        public static int KeuzeSelectie(List<string> invoer, string type)
        {
            int keuze;
            for (int i = 0; i < invoer.Count; i++)
            {
                Console.WriteLine($"{i}. {invoer[i]}");
            }

            Console.Write($"\nKies een {type}: ");
            keuze = int.Parse(Console.ReadLine());
            return keuze;
        }

        private static bool metSlagroom()
        {
            Console.Write("Wenst u slagroom: ");
            string keuze = Console.ReadLine();

            // Tennary operater => Is de keuze "Ja" -> retrunwaarde "true", anders is de returnwaarde "false" 
            return keuze.ToLower() == "ja" ? true : false;
        }

        private static void ToonBestelling(string bestellingsoverzicht)
        {
            Console.WriteLine($"\nBedankt voor uw bestelling!\n" +
                               $"\nUw bestelling:\n" +
                               $"{bestellingsoverzicht}");
        }
    }
}
