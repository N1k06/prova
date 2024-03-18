using System;
using System.Collections.Generic;
using System.Text;

namespace Lotteria_Verifica
{
    class BottinoArl: IBiglietti
    {
        private static int codice_base = 0; //attributo statico, comune a tutti 
        public int prezzo;
        public int prezzo_biglietti
        {
            get
            {
                return prezzo;
            }
            set
            {
                prezzo = 5;
                
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

        public BottinoArl()
        {
            this.codice_seriale = codice_base++; //ogni volta che creo un nuovo tipo di biglietto mi incrementa il mio codice cosi da non avere duplicati
            this.prezzo_biglietti = 5;
        }


        public int vincita()
        {
            Random random = new Random(codice_seriale); //inserisco codice seriale affinchè il numero random risulti sempre uguale se compreso nello stesso range
            int premio_biglietto = random.Next(0, 1001);//prendo il numero del range tra 0 e 1001
            if (premio_biglietto % 20 == 0)
                return random.Next(5, 501);//prendo un numero da un range differente.Utilizzando sempre l'estrazione sul codice seriale, estraendo da un altro tipo di range. Essi non si andranno a sovvrapporre
            return 0;
        }
    }
}
