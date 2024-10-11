using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primzahlen_Prüfung
{
    public static class PrimzahlenRechner
    {
        public static bool IstPrimzahl(int ein)
        {
            int e = ein;
            for (int i = 2; i < ein; i++)
            {
                e = ein;

                while (e > 0)
                {
                    e = e - i;
                }

                if (e == 0)
                { i = ein; }
            }

            if (e == 0)
                return false;
            else
                return true;
        }
    }
}
