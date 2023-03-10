using System;
using System.Net;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using models;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Bij het opstarten van de applicatie krijgt de gebruiker een menu met de volgende opties:
             * - 0. Punt
             * - 1. Cirkel
             * - 2. Cilinder
             * 
             * Afhankelijk van de keuze, worden de benodigde gegevens opgevraagd.
             * Ingegeven waardes moeten numeriek zijn en groter dan 0.
             * Hierna word een object aangemaakt met opgevraagde waardes en word deze vervolgens getoond.
             */

            int keuze;
            double omtrek, oppervlakte, volume;

            Punt punt = new Punt();
            Cirkel cirkel = new Cirkel();
            Cilinder cilinder = new Cilinder();

            Console.Write($"0. Punt\n1. Cirkel\n2. Cilinder\n");
            keuze = Keuze();
            
            switch (keuze)
            {
                // Punt
                case 0:
                    punt.X = VraagX();
                    punt.Y = VraagY();
                    Console.WriteLine(punt.ToonGegevens());
                    break;
                // Cirkel
                case 1:
                    cirkel.X = VraagX();
                    cirkel.Y = VraagY();
                    cirkel.R = VraagR();
                    omtrek = cirkel.Omtrek();
                    oppervlakte = cirkel.Oppervlakte();
                    Console.WriteLine(cirkel.ToonGegevens()); 
                    break;
                // Cilinder
                case 2:
                    cilinder.X = VraagX();
                    cilinder.Y = VraagY();
                    cilinder.R = VraagR();
                    cilinder.H = VraagH();
                    omtrek = cilinder.Omtrek();
                    oppervlakte = cilinder.Oppervlakte();
                    volume = cilinder.Volume();
                    Console.WriteLine(cilinder.ToonGegevens());
                    break;
            }
        }

        public static int Keuze()
        {
            int keuze;
            string invoer;

            do
            {
                Console.Write("\nGeef een optie: ");
                invoer = Console.ReadLine();
            } while (!int.TryParse(invoer, out keuze) || keuze < 0 || keuze > 2);
            return keuze;
        }

        public static double VraagX()
        {
            double x;
            
            Console.Write("X: ");
            x = double.Parse(Console.ReadLine());
            return x;
        }
        public static double VraagY()
        {
            double y;

            Console.Write("Y: ");
            y = double.Parse(Console.ReadLine());
            return y;
        }
        public static double VraagR()
        {
            double r;

            Console.Write("Straal: ");
            r = double.Parse(Console.ReadLine());
            return r;
        }

        public static double VraagH()
        {
            double h;

            Console.Write("Hoogte: ");
            h = double.Parse(Console.ReadLine());
            return h;
        }
    }
}
