using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lotteria_Verifica
{
    static class GestioneLotteria //creo la calsse statica perchè mi serve di istanziarla una volta sola
    {
        public static List<IBiglietti> listaB = new List<IBiglietti>(); //lista unica di biglietti

        public static void genera_biglietti<T>() where T : IBiglietti //limita T ad avere 2 valori possibili(o derivati)(controllo)
        {
            listaB.Add( (T)Activator.CreateInstance(typeof(T), new object[] { }));
        }

        public static int ricavo<T>() where T : IBiglietti
        {
            var totale = listaB.Sum(p => p.prezzo_biglietti);
            return totale;
        }

        public static int spesa<T>() where T : IBiglietti
        {
            var totale = listaB.Sum(p => p.vincita());
            return totale;
        }

    }
}
