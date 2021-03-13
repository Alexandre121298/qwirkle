using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QwirkleLibrary
{
    public static class Echange
    {
        public static Tuile[] Swap = new Tuile[6];
        static int numecase = 0;

        //Methode - Getter et Setter

        public static int GetNumeCase()
        {
            return numecase;
        }
        public static void SetSwap(Tuile tuile)
        {
            Swap[numecase] = tuile;
            numecase++;
        }

        public static Tuile GetSwap(int coord)
        {
            return Swap[coord];
        }

        //Methode - Autre
        public static void ValiderSwap()
        {
            numecase = 0 ;
        }
    }
}
