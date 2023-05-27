using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace models
{
    public class FileOperations
    {
        public static string ContactenBestand = "contacten.txt";

        public static List<Persoon> LeesContacten()
        {
            List<Persoon> contacten = new List<Persoon>();

            using StreamReader reader = new StreamReader(ContactenBestand);
            {
                while (!reader.EndOfStream)
                {
                    string record = reader.ReadLine();
                    string[] data = record.Split(';');
                    string voornaam = data[0];
                    string familienaam = data[1];
                    string email = data[2];
                    Persoon persoon = new Persoon(voornaam, familienaam, email);
                    contacten.Add(persoon);
                }
            }
            return contacten;
        }
    }
}
