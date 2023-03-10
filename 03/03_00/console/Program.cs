using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using models;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Bij het opstarten van de applicatie krijgt de gebruiker een menu met opties waaruit deze kan kiezen.
             * Bij het ingeven van een 0 of 1 krijgt de gebruiker een lijst met de studenten of scores die uit de respectievelijke bestanden gehaald worden door de methodes van FileOperations.
             * Bij het ingeven van een 2 krijgt de gebruiker een lijst te zien waarbij de studenten en scores gecombineerd worden.
             * Je kan hier dezelfde index voor gebruiken in beide lijsten.
             * Een regel ziet er als volgt uit: <student> (<score>)
             */

            // Variabelen

            int optie;
            List<string> studenten;
            List<int> scores;

            optie = VraagOptieOp();

            studenten = FileOperations.StudentenLezen();
            scores = FileOperations.ScoresLezen();

            switch (optie)
            {
                case 0:
                    DrukStudentenAf(studenten);
                    break;
                case 1:
                    DrukScoresAf(scores);
                    break;
                case 2:
                    DrukStudentenMetScoresAf(studenten, scores);
                    break;
            }
        }

        private static int VraagOptieOp()
        {
            int optie;
            string invoer;

            do
            {
                Console.WriteLine("0. Studenten\n1. Scores\n2. Studenten met scores");
                invoer = Console.ReadLine();
            } while (!int.TryParse(invoer, out optie) || optie < 0 || optie > 2);
            return optie;
        }

        private static void DrukStudentenAf(List<string> studenten)
        {
            string uitvoer = "";
            foreach(string student in studenten)
            {
                uitvoer += $"{student}\n";
            }
            Console.WriteLine(uitvoer);
        }

        private static void DrukScoresAf(List<int> scores)
        {
            string uitvoer = "";
            foreach (int score in scores)
            {
                uitvoer += $"{score}\n";
            }
            Console.WriteLine(uitvoer);
        }

        private static void DrukStudentenMetScoresAf(List<string> studenten, List<int> scores)
        {
            string uitvoer = "";
            for (int i = 0; i < studenten.Count; i++)
            {
                uitvoer += $"{studenten[i]} {scores[i]}\n";
            }
        Console.WriteLine(uitvoer);
        }
    }
}
