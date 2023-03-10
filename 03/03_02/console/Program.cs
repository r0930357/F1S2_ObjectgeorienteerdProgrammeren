using System;
using models;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Bij het opstarten van het programma, worden respectievelijk het tijdstip, graden in Celsius en graden in Fahrenheit opgevraagd voor een meting.
             * Bij het tijdstip en graden in Fahrenheit kan een lege waarde ingevuld worden.
             * Bij graden in Celsius blijft de applicatie naar een waarde vragen tot een correct kommagetal ingevoerd word.
             * Afhankelijk van de ingevulde gegevens word via de correcte contstructor een instantie van meting aangemaakt.
             * Daarna worden de gegevens van de meting getoond.
             */

            double gradenCelsius = 0;
            DateTime tijdstip = DateTime.Now;
            string gradenFahrenheitToString, tijdstipToString;

            Meting meting;

            gradenCelsius = GradenCelsius();

            //Console.Write("Geef aantal graden Fahrenheit: ");
            gradenFahrenheitToString = Console.ReadLine();

            //Console.Write("Geef een tijdstip: ");
            tijdstipToString = Console.ReadLine();

            if (gradenFahrenheitToString != "")
            {
                double.TryParse(gradenFahrenheitToString, out double gradenFahrenheit);
                meting = new Meting(tijdstip, gradenFahrenheit, gradenCelsius);
                meting.GradenCelsius = gradenCelsius;
                meting.GradenFahrenheit = gradenFahrenheit;
                meting.Tijdstip = tijdstip;
            }
            else if (tijdstipToString != "")
            {
                DateTime.TryParse(tijdstipToString, out tijdstip);
                meting = new Meting(tijdstip, gradenCelsius);
                meting.GradenCelsius = gradenCelsius;
                meting.Tijdstip = tijdstip;
            }
            else
            {
                meting = new Meting(gradenCelsius);
                meting.GradenCelsius = gradenCelsius;
            }

            Console.WriteLine(meting.ToonGegevens());
        }

        public static double GradenCelsius()
        {

            string invoer;
            double gradenCelsius;

            do
            {
                //Console.Write("Geef aantal graden Celsius: ");
                invoer = Console.ReadLine();
            } while (!double.TryParse(invoer, out gradenCelsius));
            return gradenCelsius;
        }

    }
}
