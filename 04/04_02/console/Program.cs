using models;
using System;


namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Bij het opstarten van het programma krijgt de gebruiker een menu met soorten rekeningen waaruit deze kan kiezen.
             * Bij het ingeven van een optie worden vervolgens benodigde gegevens gevraagd.
             */
             
            // Declaratie van de variabelen
            int keuze;
            string invoer = "", iban, weergave = "";
            double saldo;
            
            // Objecten initialiseren
            Bankrekening bankrekening;
            Zichtrekening zichtrekening;
            Spaarrekening spaarrekening;

            // Het keuzemenu weergeven
            Console.WriteLine("0. Rekening\n" +
                              "1. Spaarrekening\n" +
                              "2. Zichtrekening");

            // Uitvoeren van het keuzemenu aan de hand van de methode "MenuKeuze"
            keuze = MenuKeuze(invoer, 0, 2);

            // Selectie op basis van het keuzemenu:
            switch (keuze)
            {
                case 0:
                    // Bankrekening
                    Console.Write("Geef een IBAN: ");
                    iban = Console.ReadLine();
                    Console.Write("Geef een saldo: ");
                    saldo = int.Parse(Console.ReadLine());
                    bankrekening = new Bankrekening(iban, saldo) ;
                    weergave = bankrekening.ToonGegevens();
                    break;
                case 1:
                    // Spaarrekening
                    spaarrekening = new Spaarrekening();
                    weergave = spaarrekening.ToonGegevens();
                    break;
                case 2:
                    // Zichtrekening
                    Console.Write("Geef een IBAN: ");
                    iban = Console.ReadLine();
                    Console.Write("Geef een saldo: ");
                    saldo = int.Parse(Console.ReadLine());
                    zichtrekening = new Zichtrekening(iban, saldo);
                    weergave = zichtrekening.ToonGegevens();
                    break;
            }

            // Resultaat weergeven in de console
            Console.WriteLine(weergave);

        }

        // Methode: Menukeuze
        private static int MenuKeuze(string invoer, int min, int max)
        {
            int keuze;
            do
            {
                Console.Write("Maak uw keuze: ");
                invoer = Console.ReadLine();
            } while (!int.TryParse(invoer, out keuze) || keuze < min || keuze > max);
            return keuze;
        }
    }
}
