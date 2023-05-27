using System;
using models;
using System.Collections.Generic;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int keuze, opt;
            List<string> opties = new List<string>() { "Keukenlicht", "Woonkamer", "Verwarming", "Afsluiten" };
            List<string> functies = new List<string>() { "Aan", "Uit" };
            Licht keukenlicht = new Licht();
            Licht woonkamerlicht = new Licht();
            Verwarming verwarming = new Verwarming();
            Plc Plc = new Plc(keukenlicht, woonkamerlicht, verwarming);

            Console.WriteLine($"" +
                $"WoonkamerLicht: {Plc.WoonkamerLicht.AanUit}\n" +
                $"KeukenLicht: {Plc.KeukenLicht.AanUit}\n" +
                $"Verwarming: {Plc.Verwarming.AanUit}\n" +
                $"Temperatuur: {Plc.Verwarming.Graden}\n");

            keuze = PrintOpties(opties);
            switch (keuze)
            {
                case 0:
                    opt = PrintOpties(functies);
                    switch (opt)
                    {
                        case 0: Plc.DoeKeukenLichtAan(); break;
                        case 1: Plc.DoeKeukenLichtUit(); break;
                    }
                    break;
                case 1:
                    opt = PrintOpties(functies);
                    switch (opt)
                    {
                        case 0: Plc.DoeWoonkamerLichtAan(); break;
                        case 1: Plc.DoeWoonkamerLichtUit(); break;
                    }
                    break;
                case 2:
                    functies.Add("Temperatuur aanpassen");
                    opt = PrintOpties(functies);
                    switch (opt)
                    {
                        case 0: Plc.ZetVerwarmingAan(); break;
                        case 1: Plc.ZetVerwarmingUit(); break;
                        case 2:
                            Console.Write("Geef een temperatuur: ");
                            Plc.PasTemperatuurAan(double.Parse(Console.ReadLine()));
                            break;
                    }
                    break;
                case 3: break;
            }

            Console.WriteLine($"" +
                $"WoonkamerLicht: {Plc.WoonkamerLicht.AanUit}\n" +
                $"KeukenLicht: {Plc.KeukenLicht.AanUit}\n" +
                $"Verwarming: {Plc.Verwarming.AanUit}\n" +
                $"Temperatuur: {Plc.Verwarming.Graden}\n");
        }
        private static int VraagGetal(int min, int max)
        {
            string input;
            int getal;
            do
            {
                Console.Write("\nMaak een keuze: ");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out getal) || getal < min || getal > max);
            return getal;
        }
        private static int PrintOpties(List<string> opties)
        {
            for (int i = 0; i < opties.Count; i++)
            {
                Console.WriteLine($"{i}. {opties[i]}");
            }

            int keuze = VraagGetal(0, opties.Count - 1);
            return keuze;
        }
    }
}
