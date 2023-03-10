using System;
using models;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Maak een applicatie die het mogelijk maakt om geldigheid te controleren van persoonsgegevens.
             * Allereerst word er geveraagd om een voor- en familienaam op te geven.
             * Gevolgd door een rijksregisternummer en een Iban.
             * Deze worden beide gecontroleerd op geldigheid.
             * Hierna wordt een overzicht getoond van de persoonsgegevens.
             */

            string voornaam = "", familienaam = "", rijksregisternummer = "", iban = "", controleRijksregisternummer = "", controleRekeningnummer = "";
            Persoonsgegevens persoonesgegevens = new Persoonsgegevens();

            Console.Write("Geef een voornaam: ");
            voornaam = Console.ReadLine();

            Console.Write("Geef een familienaam: ");
            voornaam = Console.ReadLine();

            Console.Write("Geef een rijksregisternummer: ");
            voornaam = Console.ReadLine();

            Console.Write("Geef een Iban: ");
            voornaam = Console.ReadLine();

            controleRijksregisternummer = persoonesgegevens.Rijksregisternummer();
            controleRekeningnummer = persoonesgegevens.Rekeningnummer();

            Console.Write($"Persoonsgegevens\r\n------\r\n\r\nVolledige naam: {voornaam} {familienaam}\r\nRijksregisternummer: {rijksregisternummer} {controleRijksregisternummer}\r\nIBAN: {iban} {controleRekeningnummer}");

        }
    }
}
