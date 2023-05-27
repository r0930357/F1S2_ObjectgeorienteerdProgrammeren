using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
//using System.Text;
//using System.Text.Json;

namespace models
{
    public class Dierenverblijf
    {

        /* Dierenverblijf
         * -------------------------------------------------------
         * +Hoofdverzorger : Personeelslid
         * +Hulpverzorger : Personeelslid
         * +Mannetjesdier : Dier
         * +Vrouwtjesdier : Dier
         * -------------------------------------------------------
         * +MeldHoofdverzorgerAan(verzorger: Personeelslid) : bool
         * +MeldHulpverzorgerAan(verzorger: Personeelslid) : bool
         * +VoegMannetjeToe(dier: Dier) : bool
         * +VoegVrouwtjeToe(dier: Dier) : bool
         * +DierenVoeren(moment: DateTime) : void
         * +ToString() : string
         */

        private Personeelslid _hoofdverzorger;
        private Personeelslid _hulpverzorger;
        private Dier _mannetjesdier;
        private Dier _vrouwtjesdier;

        public Personeelslid Hoofdverzorger
        {
            get { return _hoofdverzorger; }
            set { _hoofdverzorger = value; }
        }

        public Personeelslid Hulpverzorger
        {
            get { return _hulpverzorger; }
            set { _hulpverzorger = value; }
        }

        public Dier Mannetjesdier
        {
            get { return _mannetjesdier; }
            set { _mannetjesdier = value; }
        }

        public Dier Vrouwtjesdier
        {
            get { return _vrouwtjesdier; }
            set { _vrouwtjesdier = value; }
        }

        public bool MeldHoofdverzorgerAan(Personeelslid verzorger)
        {
            /* Deze methode kent de hoofdverzorger toe aan het verblijf.
             * Een hoofdverzorger kan enkel toegekend worden als er minstens 1 dier aanwezig is in het verblijf.
             * Daarnaast mag een stagair nooit worden toegekend aan een dierenverblijf waar een gevaarlijk dier verblijft.
             * Returnwaarde van deze methode is true als de hoofdverzorger werd toegekend, false indien dit niet het geval is (om wille van de voorwaarden).
             */

            if ((Mannetjesdier != null || Vrouwtjesdier != null) && (!verzorger.IsStagair || (!Mannetjesdier.IsGevaarlijk && !Vrouwtjesdier.IsGevaarlijk)))
            {
                Hoofdverzorger = verzorger;
                return true;
            }
            return false;
        }

        public bool MeldHulpverzorgerAan(Personeelslid verzorger)
        {
            /* Deze methode kent de hulpverzorger toe aan het verblijf.
             * Een hulpverzorger kan enkel toegekend worden als er minstens 1 dier aanwezig is in het verblijf.
             * Returnwaarde van deze methode is true als de hoofdverzorger werd toegekend, false indien dit niet het geval is (om wille van de voorwaarden).
             */
            if (Hoofdverzorger != null)
            {
                Hulpverzorger = verzorger;
                return true;
            }
            else if (Mannetjesdier != null || Vrouwtjesdier != null)
            {
                verzorger = Hulpverzorger;
                return true;
            }
            return false;
        }

        public bool VoegMannetjeToe(Dier dier)
        {
            /* Deze methode kent het mannetje toe aan het verblijf.
             * Een mannetje kan enkel worden toegevoegd als er nog geen vrouwtje aanwezig is OF als het aanwezige vrouwtje van dezelfde soort is.
             * Returnwaarde van deze methode is true als het mannetje werd toegekend, false indien dit niet het geval is (om wille van de voorwaarden).
             */
            if (Vrouwtjesdier == null || Vrouwtjesdier.Diersoort == dier.Diersoort)
            {
                Mannetjesdier = dier;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool VoegVrouwtjeToe(Dier dier)
        {
            /* Deze methode kent het vrouwtje toe aan het verblijf.
             * Een vrouwtje kan enkel worden toegevoegd als er nog geen mannetje aanwezig is OF als het aanwezige mannetje van dezelfde soort is.
             * Returnwaarde van deze methode is true als het vrouwtje werd toegekend, false indien dit niet het geval is (om wille van de voorwaarden).
             */
            if (Mannetjesdier == null || Mannetjesdier.Diersoort == dier.Diersoort)
            {
                Vrouwtjesdier = dier;
                return true;
            }
            else
            {
                return false;
            }
        }

        /* Methode DierenVoeren
         * Beide dieren in het verblijf worden gevoerd.
         * Gebruik bijhorende methode van de dieren.
         */
        public void DierenVoeren(DateTime moment)
        {
            Mannetjesdier.LaatstGevoerd = moment;
            Vrouwtjesdier.LaatstGevoerd = moment;
        }

        /* Deze methode geeft een tekstuele weergave van het object als volgt:
         * 
         * Verzorgers
         * ==========
         * Hoofdverzorger: Claes Jan (Vaste medewerker)
         * Hulpverzorger: D'hondt Nelly (Stagair)
         * 
         * Dieren
         * ======
         * Mannetjesdier: Clyde (Gele pijlgifkikker) (Laatst gevoerd: 18:00)
         * Vrouwtjesdier: Bonnie (Gele pijlgifkikker) (Laatst gevoerd: 18:00)
         * 
         * Maak voor de tijd gebruik van ToShortTimeString.
         * In CodeGrade zal dit automatisch worden aangepast naar de juiste tijdszone van de machine.
         */
        public override string ToString()
        {
            return $"Verzorgers\n" +
                $"==========\n" +
                $"Hoofdverzorger: {Hoofdverzorger}\n" +
                $"Hulpverzorger: {Hulpverzorger}\n" +
                $"\n" +
                $"Dieren\n" +
                $"======\n" +
                $"Mannetjesdier: {Mannetjesdier} (Laatst gevoerd: {Mannetjesdier.LaatstGevoerd.ToShortTimeString()})\n" +
                $"Vrouwtjesdier: {Vrouwtjesdier} (Laatst gevoerd: {Vrouwtjesdier.LaatstGevoerd.ToShortTimeString()})";
        }
    }
}
