using System;
using models;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Bij het opstarten van de applicatie krijgt de gebruiker een menu met de volgende opties:
             * 
             * 1. Auto toevoegen
             * 2. Auto verwijderen
             * 3. Afsluiten
             * 
             * Bij het selecteren van Auto toevoegen vraagt het programma alle gegevens voor een object van een auto met een motor aan te maken (Chassisnummer, Merk, Cilinderinhoud en aantal PK).
             * Indien dit een auto is die nog niet in de lijst bestaat, zal deze toegevoegd worden aan de lijst.
             * Bij het selecteren van Auto verwijderen vraagt het programma het chassisnummer om deze in de lijst te kunnen zoeken.
             * Indien dit een auto is die in de lijst bestaat, zal deze verwijderd worden uit de lijst.
             * Na het toevoegen of verwijderen van een auto, zal een overzicht van alle auto's in de lijst getoond worden.
             * Zolang optie 3 niet geselecteerd wordt, zal het programma blijven vragen om een nieuwe keuze op te geven na het toevoegen of verwijderen van een auto.
             */

            List<Auto> autos = new List<Auto>();

            PrintOverzicht(autos);

            int keuze = LeesKeuze();

            while (keuze != 4)
            {
                switch (keuze)
                {
                    case 1:
                        Console.Write("Geef het chassisnummer: ");
                        string chassisnummer = Console.ReadLine();
                        Console.Write("Geef het merk: ");
                        string merk = Console.ReadLine();
                        Console.Write("Geef de cilinderinhoud: ");
                        int cilinderinhoud = int.Parse(Console.ReadLine());
                        Console.Write("Geef het aantal pk: ");
                        int pk = int.Parse(Console.ReadLine());
                        Motor motor = new Motor(cilinderinhoud, pk);
                        Auto auto = new Auto(chassisnummer, merk, motor);
                        if (!autos.Contains(auto))
                        {
                            autos.Add(auto);
                        }
                        break;

                    case 2:
                        Console.Write("Geef het chassisnummer: ");
                        string chassisnummer2 = Console.ReadLine();

                        foreach (Auto auto2 in autos)
                        {
                            if (auto2.Chassisnummer == chassisnummer2)
                            {
                                autos.Remove(auto2);
                                break;
                            }
                        }
                        break;
                    case 3:
                        foreach (Auto auto3 in autos)
                        {
                            Console.WriteLine(auto3);
                            break;
                        }
                        break;
                }

                PrintOverzicht(autos);
                keuze = LeesKeuze();
            }
        }

        private static int LeesKeuze()
        {
            Console.WriteLine("1. Auto toevoegen");
            Console.WriteLine("2. Auto verwijderen");
            Console.WriteLine("3. Auto's weergeven");
            Console.WriteLine("4. Aflsuiten");
            int keuze = int.Parse(Console.ReadLine());
            return keuze;
        }

        private static void PrintOverzicht(List<Auto> autos)
        {
            string titel = "Jouw auto's";
            Console.WriteLine(titel);
            Console.WriteLine(new string('-', titel.Length));

            if (autos.Count == 0)
            {
                Console.WriteLine("Er zijn nog geen auto's.\n");
                return;
            }

            for (int i = 0; i < autos.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {autos[i].ToString()}");
            }
            Console.WriteLine();
        }
    }
}
