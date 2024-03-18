using System;
using System.Collections.Generic;
using System.Text;

namespace Lotteria_Verifica
{
    class BellaPul : IBiglietti
    {
        private static int codice_base = 0;
        public int prezzo;
        public int prezzo_biglietti
        {
            get
            {
                return prezzo;
            }
            set
            {
                prezzo = 10;

            }

        }
        public int codice;
        public int codice_seriale
        {
            get
            {
                return codice;
            }
            set
            {
                codice = value;
            }
        }

        public BellaPul()
        {
            this.codice_seriale = codice_base++;
            this.prezzo_biglietti = 10;
        }

        public int vincita()
        {
            Random random = new Random(codice_seriale);
            if(random.Next(0,10000) % 4999 == 0)
                return random.Next(1000, 5001);
            if (random.Next(0, 10000) % 49 == 0)
                return random.Next(100, 501);
            if (random.Next(0, 10000) % 5 == 0)
                return random.Next(5, 11);
            return 0;
        }

    }
}
