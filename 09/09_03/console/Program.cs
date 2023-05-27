using System;
using System.Collections;
using System.Collections.Generic;
using models;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            int keuzeGeheugen, keuzeMoederbord, keuzeProcessor = 0;
            PC pc = new PC();
            List<Moederbord> moederbord = FileOperations.FilterMoederborden();
            List<Processor> processor = FileOperations.FilterProcessor();
            List<Geheugen> geheugen = FileOperations.FilterGeheugen();

            Processor processor1 = new Processor(processor[keuzeProcessor].Merk, processor[keuzeProcessor].Socket, processor[keuzeProcessor].AantalCores, processor[keuzeProcessor].AantalThreads, processor[keuzeProcessor].KlokFrequentie, processor[keuzeProcessor].Prijs);
            pc.Processor = processor1;
            Console.WriteLine("Kies een processor");
            keuzeProcessor = ProcessorLijst(processor);
            Console.WriteLine();

            Console.WriteLine("Kies een moederbord");
            keuzeMoederbord = MoederbordenLijst(moederbord);
            Console.WriteLine();
            Moederbord moederbord1 = new Moederbord(moederbord[keuzeMoederbord].Socket, moederbord[keuzeMoederbord].Chipset, moederbord[keuzeMoederbord].Formfactor, moederbord[keuzeMoederbord].GeheugenType, moederbord[keuzeMoederbord].Prijs);
            pc.Moederbord = moederbord1;

            Console.WriteLine("Kies een geheugen");
            keuzeGeheugen = GeheugenLijst(geheugen);
            Console.WriteLine();
            Geheugen geheugen1 = new Geheugen(geheugen[keuzeGeheugen].Type, geheugen[keuzeGeheugen].ModuleGrootte, geheugen[keuzeGeheugen].Prijs);
            pc.Geheugen = geheugen1;


            // Hierna wordt de Pc gecontroleerd op compabiliteit.
            // -> correcte aanpak?

            // Indien deze in orde is, zal het overzicht van de Pc getoont worden.
            Console.WriteLine(pc.ToString());

            // Indien er fouten zijn, zullen deze getoond worden en start het programma opnieuw.
            // -> correcte aanpak?

        }
        private static int VraagGetal(int min, int max)
        {
            string input;
            int getal;
            do
            {
                Console.Write("Uw keuze: ");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out getal) || getal < min || getal > max);
            return getal;
        }

        private static int GeheugenLijst(List<Geheugen> geheugen)
        {
            for (int i = 0; i < geheugen.Count; i++)
            {
                Console.WriteLine($"{i}. {geheugen[i]}");
            }

            int keuze = VraagGetal(0, geheugen.Count - 1);
            return keuze;
        }

        private static int MoederbordenLijst(List<Moederbord> moederbord)
        {
            for (int i = 0; i < moederbord.Count; i++)
            {
                Console.WriteLine($"{i}. {moederbord[i]}");
            }

            int keuze = VraagGetal(0, moederbord.Count - 1);
            return keuze;
        }
        private static int ProcessorLijst(List<Processor> processor)
        {
            for (int i = 0; i < processor.Count; i++)
            {
                Console.WriteLine($"{i}. {processor[i]}");
            }

            int keuze = VraagGetal(0, processor.Count - 1);
            return keuze;
        }
    }
}
