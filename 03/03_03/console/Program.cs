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

            // Declaratie van de variabelen
            string voornaam, familienaam, rijksregisternummer, iban, rijksregisternummerString, ibanString;

            // Voornaam opvragen
            Console.Write("Geef een voornaam: ");
            voornaam = Console.ReadLine();

            // Familienaam opvragen
            Console.Write("Geef een familienaam: ");
            familienaam = Console.ReadLine();

            // Rijksregisternummer opvragen
            // Van het rijksregisternummer een string maken voor de weergave
            Console.Write("Geef een rijksregisternummer: ");
            rijksregisternummer = Console.ReadLine();
            rijksregisternummerString = rijksregisternummer;
            // Tekens van het rijksregisternummer verwijderen met de methode "RijksregisternummerZonderTekens" zodat deze enkel bestaat uit numerike waarden
            rijksregisternummer = RijksregisterZonderTekens(rijksregisternummer);

            // Rekeningnummer opvragen
            // Van de rekeningnummer een string maken voor de weergave
            Console.Write("Geef een Iban: ");
            iban = Console.ReadLine();
            ibanString = iban;
            // Tekens van de rekeningnummer verwijderen met de methode "RekeningZonderTekens" zodat deze enkel bestaat uit numerike waarden
            iban = RekeningZonderTekens(iban);

            // Controle van het rijksregsiternummer met behulp van de de methode "ControleRijksregisternummer" in de klasse "Controle"
            string controleerRijksregisternummer = Controle.ControleRijksregisterNummer(rijksregisternummer);
            // Controle van de rekeningnummer met behulp van de de methode "ControleRekeningnummer" in de klasse "Controle"
            string controleereRekeningnummer = Controle.ControleRekeningNummer(iban);

            // De gevraagde gegevens weergeven in de console
            Console.Write($"Persoonsgegevens" +
                $"\n------" +
                $"\n" +
                $"\nVolledige naam: {voornaam} {familienaam}" +
                $"\nRijksregisternummer: {rijksregisternummerString} {controleerRijksregisternummer}" +
                $"\nIBAN: {ibanString} {controleereRekeningnummer}");

        }

        public static string RijksregisterZonderTekens(string rijksregisterNummer)
        {
            // De opgegeven rijksregisternummer ontdoen van de typische tekens, zoals "-", "." volgens het voorbeeld of een spatie aan het begin of einde.
            // Met het while-statement wordt gecontroleerd of het opgegeven rijksregisternummer voldoet aan de wettige lengte van 11 karakters.

            do
            {
                rijksregisterNummer = rijksregisterNummer.Replace("-", "");
                rijksregisterNummer = rijksregisterNummer.Replace(".", "");
                rijksregisterNummer = rijksregisterNummer.Trim();
            } while (string.IsNullOrWhiteSpace(rijksregisterNummer) || rijksregisterNummer.Length != 11);
            return rijksregisterNummer;
        }

        public static string RekeningZonderTekens(string rekeningNummer)
        {
            // De opgegeven rijksregisternummer ontdoen van de typische tekens, zoals "-" volgens het voorbeeld of een spatie aan het begin of einde.
            // Met het while-statement wordt gecontroleerd of het opgegeven rijksregisternummer voldoet aan de wettige lengte van 12 karakters.

            do
            {
                rekeningNummer = rekeningNummer.Replace("-", "");
                rekeningNummer = rekeningNummer.Trim();
            } while (string.IsNullOrWhiteSpace(rekeningNummer) || rekeningNummer.Length != 12);
            return rekeningNummer;
        }
    }
}
