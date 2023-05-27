using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using models;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            string voornaam, familienaam, e_mail, titel, bericht;
            int keuze;
            List<Persoon> contacten = FileOperations.LeesContacten();
            
            Console.Write("Geef voornaam: ");
            voornaam = Console.ReadLine();
            Console.Write("Geef familienaam: ");
            familienaam = Console.ReadLine();
            Console.Write("Geef emailadres: ");
            e_mail = Console.ReadLine();
            Persoon verzender = new Persoon(voornaam, familienaam, e_mail);

            // Hoe kan ik de persoonsgegevens van de opgevraagde parameters uit het bestand "contacten" in het objct "ontvanger" krijgen?
            keuze = ContactLijst(contacten);
            Persoon ontvanger = new Persoon(contacten[keuze - 1].Voornaam, contacten[keuze - 1].Familienaam, contacten[keuze - 1].Email);

            Console.Write("Geef titel: ");
            titel = Console.ReadLine();
            Console.Write("Geef bericht: ");
            bericht = Console.ReadLine();
            Email email = new Email(verzender, ontvanger, titel, bericht);
            Console.WriteLine(email.ToString());
        }

        private static int VraagGetal(int min, int max)
        {
            string input;
            int getal;
            do
            {
                Console.Write("\nKies ontvanger: ");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out getal) || getal < min || getal > max);
            return getal;
        }

        private static int ContactLijst(List<Persoon> contacten)
        {
            for (int i = 0; i < contacten.Count; i++)
            {
                    Console.WriteLine($"{i + 1}. {contacten[i].ToString()}");
            }

            int keuze = VraagGetal(0, contacten.Count);
            return keuze;
        }
    }
}
