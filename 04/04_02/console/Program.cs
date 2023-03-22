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
             *
             * 0. Rekening
             * 1. Spaarekening
             * 2. Zichtrekening
             * Maak uw keuze: 0
             * Geef een IBAN: BE12
             * Geef een saldo: 1500
             * Rekening BE12 met saldo 1500
             */

            int keuze, ibanNummer;
            string invoer;
            double saldo;

            Console.WriteLine("0. Rekening\n" +
                "1. Spaarrekening\n" +
                "2. Zichtrekening");

            do
            {
                Console.Write("Maak uw keuze: ");
                invoer = Console.ReadLine();
            } while (!int.TryParse(invoer, out keuze) || keuze < 0 || keuze > 2);

            switch (keuze)
            {
                case 0:
                    // Rekening
                    // Geef een IBAN: BE12
                    // Geef een saldo: 1500
                    // Rekening BE12 met saldo 1500

                    break;
                case 1:
                    //Spaarrekening
                    //Rekening met saldo 0 (percentage 5)

                    break;
                case 2:
                    //Zichtrekening
                    //Geef een IBAN: BE12
                    //Geef een saldo: 250
                    //Rekening BE12 met saldo 250(Minimum - 100)

                    break;
            }

            /* Bij het aanmaken van een spaarrekening, zal standaard een percentage voorzien worden van 5%.
             * Bij het aanmaken van een zichtrekening, zal er standaard een minimum voorzien worden van -100.
             */



            Console.WriteLine("Hello World!");
        }
    }
}
