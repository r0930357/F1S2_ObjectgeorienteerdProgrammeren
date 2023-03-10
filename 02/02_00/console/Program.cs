using models;
using System;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaratie van de variabelen en objecten

            string naam, invoer;
            int scoreProgrammeren, scoreNetwerken;
            Student student;

            // Initialisatie van de object
            student = new Student();

            // Opvragen van de naam
            do
            {
                Console.Write("Geef de naam van de student: ");
                naam = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(naam));

            // Naam student toekennen aan object

            student.Naam = naam;

            //Opvragen van de score voor programmeren
            do
            {
                Console.Write("Geef de score voor programmeren: ");
                invoer = Console.ReadLine();
            } while (!int.TryParse(invoer, out scoreProgrammeren));

            // Score programmeren toekennen aan object -> (VoerScoreIn(int keuze, int score) -> Keuze = 0 (programmeren)
            student.VoerScoreIn(0, scoreProgrammeren);

            //Opvragen van de score voor netwerken
            do
            {
                Console.Write("Geef de score voor netwerken: ");
                invoer = Console.ReadLine();
            } while (!int.TryParse(invoer, out scoreNetwerken));

            // Score netwerken toekennen aan object -> (VoerScoreIn(int keuze, int score) -> Keuze = 1 (netwerken)
            student.VoerScoreIn(1, scoreNetwerken);

            // Rapport afdrukken
            Console.WriteLine(student.ToonRapport());
        }
    }
}
