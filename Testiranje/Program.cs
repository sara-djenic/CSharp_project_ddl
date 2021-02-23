using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testiranje
{
    class Program
    {
        static void Main(string[] args)
        {

            Zadatak2.clsMath x = new Zadatak2.clsMath();

            long[] niz = new long[10];

            niz = x.GenFibonacci(10);

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(niz[i]);
                
            }

            Console.ReadLine();


        }
    }
}
