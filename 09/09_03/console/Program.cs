using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using models;

namespace console
{
    class Program
    {
        private static void Main(string[] args)
        {
            List<Onderdeel> onderdelen = FileOperations.LeesOnderdelen();

            string titel = "PC Samenstellen";
            Console.WriteLine(titel);
            Console.WriteLine(new string('=', titel.Length));
            Console.WriteLine();

            PC pc = new PC();

            while (!pc.PcIsCompleet())
            {
                try
                {
                    pc.Moederbord = KiesMoederbord();
                    pc.Processor = KiesProcessor();
                    pc.Geheugen = KiesGeheugen();
                    pc.ControleerOnderdelen();
                }
                catch (Exception ex)
                {
                    pc.VerwijderOnderdelen();
                    Console.WriteLine(ex.Message + "\nOnderdelen werden verwijderd. Druk op enter om opnieuw te beginnen.");
                    Console.ReadLine();
                    Console.Clear();
                }
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Jouw pc:");
            Console.WriteLine(pc);
        }

        private static Moederbord KiesMoederbord()
        {
            Console.WriteLine();
            Console.WriteLine("Kies een moederbord:");
            Console.WriteLine();

            List<Moederbord> moederborden = FileOperations.FilterMoederborden();

            for (int i = 0; i < moederborden.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {moederborden[i]}");
            }

            Console.WriteLine();
            Console.Write("Uw keuze: ");
            int keuze = int.Parse(Console.ReadLine());

            return moederborden[keuze - 1];
        }

        private static Processor KiesProcessor()
        {
            Console.WriteLine();
            Console.WriteLine("Kies een processor:");
            Console.WriteLine();

            List<Processor> processoren = FileOperations.FilterProcessor();

            for (int i = 0; i < processoren.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {processoren[i]}");
            }

            Console.WriteLine();
            Console.Write("Uw keuze: ");
            int keuze = int.Parse(Console.ReadLine());

            return processoren[keuze - 1];
        }

        private static Geheugen KiesGeheugen()
        {
            Console.WriteLine();
            Console.WriteLine("Kies een geheugen:");
            Console.WriteLine();

            List<Geheugen> geheugen = FileOperations.FilterGeheugen();

            for (int i = 0; i < geheugen.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {geheugen[i]}");
            }

            Console.WriteLine();
            Console.Write("Uw keuze: ");
            int keuze = int.Parse(Console.ReadLine());

            return geheugen[keuze - 1];
        }
    }
}