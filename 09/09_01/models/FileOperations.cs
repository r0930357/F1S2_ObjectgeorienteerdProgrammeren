using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace models
{
    public class FileOperations
    {
        public static string BestandKlanten = "klanten.txt";

        /* Methode KlantenInlezen
         * Lees alle klanten uit het txt-bestand.
         * Fouten die zich hier voordoen, worden gelogd via de FoutLoggen methdode.
         */

        public static List<Klant> KlantenInlezen()
        {
            List<Klant> klant = new List<Klant>();

            using StreamReader reader = new StreamReader(BestandKlanten);
            {
                while (!reader.EndOfStream)
                {
                    string record = reader.ReadLine();
                    string[] data = record.Split(';');
                    int.TryParse(data[0], out int klantnummer);
                    string naam = data[1];
                    string adres = data[2];
                    string gemeente = data[3];
                    string postcode = data[4];
                    Klant personeelslid = new Klant(klantnummer, naam, adres, gemeente, postcode);
                    klant.Add(personeelslid);
                }
            }
            return klant;
        }

        /* Methode ZoekKlantViaNummer
         * Zoek een klant aan de hand van Nummer uit het txt-bestand.
         */

        public static Klant ZoekKlantViaNummer(int klantnummer)
        {
            List<Klant> klanten = KlantenInlezen();
            foreach (Klant klant in klanten)
            {
                if (klant.Klantnummer == klantnummer)
                {
                    // Indien het klantnummer bestaat => geef klant terug
                    return klant;
                }
            }
            // Indien het klantnummer niet bestaat => geef niets terug
            throw new KlantNietGevondenException(klantnummer, $"De klantnummer {klantnummer} bestaat niet");
        }

        /* Methode FoutLoggen
         * Schrijf een Exception weg in een txt-bestand genaamd "foutenbestand.txt"
         * Volgende zaken van de Exception worden weggeschreven:
         * <Type>
         * <Message>
         * <Stacktrace>
        */
        public static void FoutLoggen(Exception exception)
        {
            using (StreamWriter writer = new StreamWriter("foutenbestand.txt"))
            {
                writer.WriteLine($"Type: {exception.GetType().Name}\n");
                writer.WriteLine($"Message: {exception.Message}\n");
                writer.WriteLine($"Stacktrace: {exception.StackTrace}");
            }
        }
    }
}
