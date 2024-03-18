using System;
using System.Collections.Generic;
using System.Text;

namespace Lotteria_Verifica
{
    interface IBiglietti 
    {
        public int prezzo_biglietti { get; set; }
        public int codice_seriale { get; set; }
        public int vincita();
    }
}
