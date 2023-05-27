using System;
using models;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Collections;

namespace models
{
    public class FileOperations
    {
        public static string BestandPersoneel = "personeel.txt";
        public static string BestandDieren = "dieren.txt";

        public static List<Personeelslid> LeesPersoneelslid()
        {
            List<Personeelslid> persoon = new List<Personeelslid>();

            using StreamReader reader = new StreamReader(BestandPersoneel);
            {
                while (!reader.EndOfStream)
                {
                    string record = reader.ReadLine();
                    string[] data = record.Split(';');
                    string voornaam = data[0];
                    string familienaam = data[1];
                    bool.TryParse(data[2], out bool isStagair);
                    Personeelslid personeelslid = new Personeelslid(voornaam, familienaam, isStagair);
                    persoon.Add(personeelslid);
                }
            }
            return persoon;
        }

        public static List<Dier> LeesDier()
        {
            List<Dier> dier = new List<Dier>();

            using StreamReader reader = new StreamReader(BestandDieren);
            {
                while (!reader.EndOfStream)
                {
                    string record = reader.ReadLine();
                    string[] data = record.Split(';');
                    string naam = data[0];
                    string diersoort = data[1];
                    bool.TryParse(data[2], out bool isGevaarlijk);
                    Dier dieren = new Dier(naam, diersoort, isGevaarlijk);
                    dier.Add(dieren);
                }
            }
            return dier;
        }
    }
}