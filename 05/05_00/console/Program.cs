using models;
using System;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Bij het opstarten van de applicatie, kan de gebruiker 1 van de auto's kiezen om acties op uit te voeren.
             * Hierna wordt gevraagt welke actie zij willen uitvoeren.
             * Hierbij worden de juiste gegevens opgevraagd om deze actie uit te voeren.
             * De applicatie blijft actief tot optie 0 gekozen word.
             */

            // Variabelen
            int keuzeAuto, keuzeActie, aantalKilometer;
            string invoer;

            // Objecten
            Audi audi = new Audi("1-lvn-568", 2500, 7500, 25);
            BMW bmw = new BMW("1-hbj-298", 500, 12500, 44);
            Volkswagen volkswagen = new Volkswagen("1-sej-454", 100000, 5500, 10);
            Auto auto = null;

            Console.Write($"Auto's\n" +
                $"{new string('*', 6)}\n" +
                $"0.Stoppen\n" +
                $"1.Audi(1-lvn-568)\n" +
                $"2.Volkswagen(1-sej-454)\n" +
                $"3.BMW(1-hbj-298)\n");

            do
            {
                Console.Write("Kies een auto: ");
                invoer = Console.ReadLine();
            } while (!int.TryParse(invoer, out keuzeAuto) || keuzeAuto < 0 || keuzeAuto > 3);

            while (keuzeAuto != 0)
            {
                // Stap 3: Herhalende taken
                switch (keuzeAuto)
                {
                    case 1:
                        auto = audi;
                        break;
                    case 2:
                        auto = volkswagen;
                        break;
                    case 3:
                        auto = bmw;
                        break;
                }

                Console.WriteLine($"Acties\n" +
                    $"{new string('*', 6)}\n" +
                    $"0. Testrit maken" +
                    $"\n1. Details tonen");

                do
                {
                    Console.Write("Kies een actie: ");
                    invoer = Console.ReadLine();
                } while (!int.TryParse(invoer, out keuzeActie) || keuzeActie < 0 || keuzeActie > 1);

                switch(keuzeActie)
                {
                    case 0:
                        do
                        {
                            Console.Write("Geef aantal kilometer: ");
                            invoer = Console.ReadLine();
                        } while (!int.TryParse(invoer, out aantalKilometer) || aantalKilometer < 0);
;                       auto.Rijden(aantalKilometer);
                        break;
                    case 1:
                        Console.WriteLine(auto.ToString());
                        break;
                }
                Console.Write($"Auto's\n" +
                    $"{new string('*', 6)}\n" +
                    $"0.Stoppen\n" +
                    $"1.Audi(1-lvn-568)\n" +
                    $"2.Volkswagen(1-sej-454)\n" +
                    $"3.BMW(1-hbj-298)\n");

                do
                {
                    Console.Write("Kies een actie: ");
                    invoer = Console.ReadLine();
                } while (!int.TryParse(invoer, out keuzeActie) || keuzeActie < 0 || keuzeActie > 1);
            }
        }
    }
}
