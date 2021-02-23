using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak2
{
    public class clsMath
    {
        public long[] GenFibonacci(int brClanova)
        {
            long[] niz = new long[brClanova];

            niz[0] = 0;
            niz[1] = 1;

            for (int i = 2; i < brClanova; i++)
            {
                niz[i] = niz[i - 1] + niz[i - 2];
            }

            return niz;
        }
    }
}
