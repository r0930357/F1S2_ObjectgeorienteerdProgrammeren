using models;
using System;
using System.Collections.Generic;
using System.Net.WebSockets;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {

            Dierenverblijf dierenverblijf = new Dierenverblijf();
            List<Personeelslid> personeelslijst = FileOperations.LeesPersoneelslid();
            List<Dier> dierenlijst = FileOperations.LeesDier();
            DateTime voertijd = DateTime.Today;

            DrukDierLijst(dierenlijst);
            Dier mannetjesdier = null;
            do
            {
                int keuze = VraagGetal(0, dierenlijst.Count - 1, "\nWelk mannetjesdier wil je toevoegen? ");
                mannetjesdier = dierenlijst[keuze];
            } while (!dierenverblijf.VoegMannetjeToe(mannetjesdier));

            DrukDierLijst(dierenlijst);
            Dier vrouwtjesdier = null;
            do
            {
                int keuze = VraagGetal(0, dierenlijst.Count - 1, "\nWelk vrouwtjesdier wil je toevoegen? ");
                vrouwtjesdier = dierenlijst[keuze];
            } while (!dierenverblijf.VoegVrouwtjeToe(vrouwtjesdier));

            DrukPersoneelslijst(personeelslijst);
            Personeelslid hoofdverzorger = null;
            do
            {
                int keuze = VraagGetal(0, personeelslijst.Count - 1, "\nWelk personeelslid wil je aanmelden als hoofdverzorger? ");
                hoofdverzorger = personeelslijst[keuze];
            } while (!dierenverblijf.MeldHoofdverzorgerAan(hoofdverzorger));


            DrukPersoneelslijst(personeelslijst);
            Personeelslid hulpverzorger = null;
            do
            {
                int keuze = VraagGetal(0, personeelslijst.Count - 1, "\nWelk personeelslid wil je aanmelden als hulpverzorger? ");
                hulpverzorger = personeelslijst[keuze];
            } while (!dierenverblijf.MeldHulpverzorgerAan(hulpverzorger));

            Console.Write("Om hoelaat wil je de dieren voeren(hh)? ");
            int i = int.Parse(Console.ReadLine());
            voertijd = voertijd.AddHours(i);
            dierenverblijf.DierenVoeren(voertijd);

            Console.WriteLine("\nDe dieren worden gevoerd!\n");

            Console.Clear();
            Console.WriteLine(dierenverblijf.ToString());
        }

        private static int VraagGetal(int min, int max, string vraag)
        {
            string input;
            int getal;
            do
            {
                Console.Write(vraag);
                input = Console.ReadLine();
            } while (!int.TryParse(input, out getal) || getal < min || getal > max);
            return getal;
        }

        private static void DrukPersoneelslijst(List<Personeelslid> personeelslijst)
        {
            for (int i = 0; i < personeelslijst.Count; i++)
            {
                Console.WriteLine($"{i}. {personeelslijst[i]}");
            }
        }
        private static void DrukDierLijst(List<Dier> dierenlijst)
        {
            for (int i = 0; i < dierenlijst.Count; i++)
            {
                Console.WriteLine($"{i}. {dierenlijst[i]}");
            }
        }
    }
}
