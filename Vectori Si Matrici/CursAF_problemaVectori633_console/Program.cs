using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursAF_ProblemeVectori633_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Se dă un șir cu n elemente, numere naturale. 
            // Determinați diferența în valoare absolută dintre numărul de valori pare din șir 
            // și numărul de valori impare din șir.

            int n = int.Parse(Console.ReadLine());
            string[] data = Console.ReadLine().Split(' ');

            int[] v = new int[n];

            int pare = 0, impare = 0;

            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(data[i]);
                if (v[i] % 2 == 0)
                    pare++;
                else
                    impare++;
            }

            Console.WriteLine((int)Math.Abs(pare - impare)); // abs ne returneaza double
        }
    }
}