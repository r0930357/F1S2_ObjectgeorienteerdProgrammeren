using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class Plc
    {
        /* Plc
         * -----------------------------------------------------------------------
         * +KeukenLicht : Licht
         * +WoonkamerLicht : Licht
         * +Verwarming : Verwarming
         * -----------------------------------------------------------------------
         * +Plc(keukenLicht: Licht, woonkamerLicht: Licht, verwarming: Verwarming)
         * +DoeKeukenLichtAan() : void
         * +DoeKeukenLichtUit() : void
         * +DoeWoonkamerLichtAan() : void
         * +DoeWoonkamerLichtUit() : void
         * +ZetVerwarmingAan() : void
         * +ZetVerwarmingUit() : void
         * +PasTemperatuurAan(temperatuur: double) : void
         */

        private Licht _keukenlicht;
        private Licht _woonkamerlicht;
        private Verwarming _verwarming;

        public Licht KeukenLicht
        {
            get { return _keukenlicht; }
            set { _keukenlicht = value; }
        }
        
        public Licht WoonkamerLicht
        {
            get { return _woonkamerlicht; }
            set { _woonkamerlicht = value; }
        }

        public Verwarming Verwarming
        {
            get { return _verwarming; }
            set { _verwarming = value; }
        }

        public Plc(Licht keukenLicht, Licht woonkamerLicht, Verwarming verwarming)
        {
            KeukenLicht = keukenLicht;
            WoonkamerLicht = woonkamerLicht;
            Verwarming = verwarming;
        }

        public void DoeKeukenLichtAan()
        {
            KeukenLicht.AanUit = true;
        }

        public void DoeKeukenLichtUit()
        {
            KeukenLicht.AanUit = false;
        }

        public void DoeWoonkamerLichtAan()
        {
            WoonkamerLicht.AanUit = true;
        }

        public void DoeWoonkamerLichtUit()
        {
            WoonkamerLicht.AanUit = false;
        }

        public void ZetVerwarmingAan()
        {
            Verwarming.AanUit = true;
        }

        public void ZetVerwarmingUit()
        {
            Verwarming.AanUit = false;
        }

        public void PasTemperatuurAan(double temperatuur)
        {
            Verwarming.Graden = temperatuur;
        }
    }
}
