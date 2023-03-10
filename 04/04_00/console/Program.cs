using System;
using System.Dynamic;
using models;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Maak een nieuwe werknemer en klant aan.
             * Geef de werknemer en klant een voor-/achternaam.
             * Print de gegevens van de werknemer en de klant in console via de methode ToonGegevens().
             */

            string voornaam, achternaam;
            Klant klant;
            Werknemer werknemer;

            // Werknemer aanmaken
            voornaam = LeesStringNietLeeg("Beste werknemer, geef je voornaam: ");
            achternaam = LeesStringNietLeeg("Beste werknemer, geef je achternaam: ");

            werknemer = new Werknemer(voornaam, achternaam);

            Console.WriteLine(werknemer.ToonGegevens());

            // Klant aanmaken

            voornaam = LeesStringNietLeeg("Beste klant, geef je voornaam: ");
            achternaam = LeesStringNietLeeg("Beste klant, geef je achternaam: ");

            klant = new Klant(voornaam, achternaam);

            Console.WriteLine(klant.ToonGegevens());
        }

        static string LeesStringNietLeeg(string vraag)
        {
            string invoer;

            do
            {
                Console.Write(vraag);
                invoer = Console.ReadLine();
            } while (string.IsNullOrEmpty(invoer));
            return invoer;
        }

    }
}
