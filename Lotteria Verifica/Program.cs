using System;

namespace Lotteria_Verifica
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for (int i=0; i<5000; i++)
            {
                GestioneLotteria.genera_biglietti<BellaPul>();
                GestioneLotteria.genera_biglietti<BottinoArl>();
            }

            Console.WriteLine("SPESA BELLAPUL");
            Console.WriteLine(GestioneLotteria.spesa<BellaPul>());
            Console.WriteLine("SPESA BOTTINOARL");
            Console.WriteLine(GestioneLotteria.spesa<BottinoArl>());

            Console.WriteLine("RICAVO BELLAPUL");
            Console.WriteLine(GestioneLotteria.ricavo<BellaPul>());
            Console.WriteLine("RICAVO BOTTINOARL");
            Console.WriteLine(GestioneLotteria.ricavo<BottinoArl>());

            Console.WriteLine(GestioneLotteria.ricavo<BellaPul>() - GestioneLotteria.spesa<BellaPul>());
            Console.WriteLine(GestioneLotteria.ricavo<BottinoArl>() - GestioneLotteria.spesa<BottinoArl>());
        }
    }
}
