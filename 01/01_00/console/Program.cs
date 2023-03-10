using models;
using System;

namespace console
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Declaratie Gebruiker object (gebruiker1).
            Gebruiker gebruiker1;
            
            // Instantiatie Gebruiker object (gebruiker1).
            gebruiker1 = new Gebruiker();
            
            // Attributen voorzien van waardes (gebruiker1).
            // Aan de attributen van gebruiker1 wordt een vaste waarde toegewezen -> Nummer = 1, Voornaam = "Joeri", Familienaam = "Verlooy".
            gebruiker1.Nummer = 1;
            gebruiker1.Voornaam = "Joeri";
            gebruiker1.Familienaam = "Verlooy";
            
            // Waardes gebruiker opvragen door middel van methode ToonAlles() in Gebruiker.cs.
            Console.WriteLine(gebruiker1.ToonAlles());


            // Nieuwe gegevens opvragen in het consolevenster.
            Console.Write("Geef een nummer: ");
            int nummer = int.Parse(Console.ReadLine());
            Console.Write("Geef een voornaam: ");
            string voornaam = Console.ReadLine();
            Console.Write("Geef een familienaam: ");
            string familienaam = Console.ReadLine();
            
                     
            // Declaratie en initalisatie van object (gebruiker2).
            Gebruiker gebruiker2 = new Gebruiker();

            // Gegevens toekennen aan object (gebruiker2).
            gebruiker2.Nummer = nummer;
            gebruiker2.Voornaam = voornaam;
            gebruiker2.Familienaam = familienaam;
            
            // Waardes gebruiker2 tonen in het consolevenster.
            Console.WriteLine($"#{gebruiker2.Nummer} - {gebruiker2.VolledigeNaam}");

            // Nummer voor gebruiker2 terugzetten naar de standaardwaarde.
            int opgevraagdNummer = gebruiker2.Nummer;
            
            // Alle gegevens van gebruiker2 wissen.
            gebruiker2.Wissen();
            
            // Gegevens van gebruiker2 tonen.
            Console.WriteLine($"#{gebruiker2.Nummer} - {gebruiker2.VolledigeNaam}");
        }
    }
}
