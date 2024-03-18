using System;
using System.Collections.Generic;
using System.Text;

namespace Lotteria_Verifica
{
    static class GestioneBiglietti
    {
        
        public static List<BellaPul> listaP = new List<BellaPul>();
        static List<BottinoArl> listaA = new List<BottinoArl>();

        public static void genera_biglietti(bool scelta)
        {
            
            if (scelta)
            {
                listaP.Add(new BellaPul());
 
            }
            else
            {
                listaA.Add(new BottinoArl());
            }
        }

        public static int ricavo(bool tipologia)
        {
            int aux = 0;
            if(tipologia)
            {
                for(int i = 0; i <= listaP.Count; i++)
                {
                    if (i != listaP.Count)//perchè se i è uguale a count andrebbe a cercare un elemento listaP che non esiste
                    {
                        aux += listaP[i].prezzo_biglietti;
                    }
                    else
                        return aux;
                    
                }
            }
            else
            {
                for (int i = 0; i <= listaA.Count; i++)
                {
                    if (i != listaA.Count)//perchè se i è uguale a count andrebbe a cercare un elemento listaA che non esiste
                    {
                        aux += listaA[i].prezzo_biglietti;
                    }
                    else
                        return aux;

                }
            }
            return aux;
        }

        public static int spesa(bool tipologia)
        {
            int aux = 0;
            
            if (tipologia)
            {
                
                
                
                for (int i = 0; i <= listaP.Count; i++)
                {
                   
                    if (i != listaP.Count)//perchè se i è uguale a count andrebbe a cercare un elemento listaP che non esiste
                    {
                        aux += listaP[i].vincita();
                    }
                    else
                        return aux;

                }
                
            }
            else
            {
                for (int i = 0; i <= listaA.Count; i++)
                {
                    if (i != listaA.Count)//perchè se i è uguale a count andrebbe a cercare un elemento listaA che non esiste
                    {
                        aux += listaA[i].vincita();
                    }
                    else
                        return aux;

                }
            }
            return aux;
        }

        

    }
}
