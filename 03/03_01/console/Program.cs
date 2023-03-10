using System;
using models;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Bij het opstarten van de applicatie krijgt de gebruiker een menu met opties waaruit deze kan kiezen.
             * Bij het ingeven van de optie worden vervolgens de juiste benodigde gegevens gevraagd.
             * Hierna word het resultaat getoond.
             */

            // Variabelen

            int optie;

            optie = VraagOptieOp();

            switch (optie)
            {
                case 0:
                    Opp_Rechthoek();
                    break;
                case 1:
                    Opp_Cirkel();
                    break;
                case 2:
                    Vol_Balk();
                    break;
                case 3:
                    Vol_Cilinder();
                    break;
            }
        }

        private static int VraagOptieOp()
        {
            int optie;
            string invoer;

            do
            {
                Console.WriteLine("0. Oppervlakte rechthoek\n1. Oppervlakte cirkel\n2. Volume balk\n3. Volume cilinder\n");
                Console.Write("Geef een optie: ");
                invoer = Console.ReadLine();
            } while (!int.TryParse(invoer, out optie) || optie < 0 || optie > 3);
            return optie;
        }

        private static void Opp_Rechthoek()
        {
            double lengte = 0, breedte = 0, oppervlakte = 0;

            Console.Write("\nGeef een lengte: ");
            lengte = double.Parse(Console.ReadLine());
            Console.Write("Geef een breedte: ");
            breedte = double.Parse(Console.ReadLine());

            oppervlakte = MeetkundigeFormules.OppervlakteRechthoek(lengte, breedte);
            Console.WriteLine($"De oppervlakte van de rechthoek is {(oppervlakte.ToString("0.0"))}");
        }

        private static void Opp_Cirkel()
        {
            double straal = 0, oppervlakte = 0;

            Console.Write("\nGeef een straal: ");
            straal = double.Parse(Console.ReadLine());

            oppervlakte = MeetkundigeFormules.OppervlakteCirkel(straal);
            Console.WriteLine($"De oppervlakte van de cirkel is {(oppervlakte.ToString("0.0"))} cm²");
        }

        private static void Vol_Balk()
        {
            double lengte = 0, breedte = 0, hoogte = 0, volume = 0;

            Console.Write("\nGeef een lengte: ");
            lengte = double.Parse(Console.ReadLine());
            Console.Write("Geef een breedte: ");
            breedte = double.Parse(Console.ReadLine());
            Console.Write("Geef een hoogte: ");
            hoogte = double.Parse(Console.ReadLine());

            volume = MeetkundigeFormules.VolumeBalk(lengte, breedte, hoogte);
            Console.WriteLine($"De volume van de balk is {(volume.ToString("0"))} cm²");
        }

        private static void Vol_Cilinder()
        {
            double straal = 0, hoogte = 0, volume = 0;

            Console.Write("\nGeef een lengte: ");
            straal = double.Parse(Console.ReadLine());
            Console.Write("Geef een hoogte: ");
            hoogte = double.Parse(Console.ReadLine());

            volume = MeetkundigeFormules.VolumeCilinder(straal, hoogte);
            Console.WriteLine($"De volume van de cilinder is {(volume.ToString("0"))} cm²");
        }
    }
}