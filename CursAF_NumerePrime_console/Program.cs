using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursAF_NumerePrime_console
{
    internal class Program
    {
        public static bool IsPrime(int n)
        {
            if (n < 2)
                return false;
            if (n == 2)
                return true;
            if (n % 2 == 0)
                return false;
            for (int i = 3; i * i <= n; i += 2)
            {
                if (n % i == 0)
                    return false;
            }
            return true;    // true -> nr e prim, false -> nr nu este prim
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] data = Console.ReadLine().Split(' ');

            int[] v = new int[n];

            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(data[i]);
                if (IsPrime(v[i]))
                    Console.Write(v[i] + " ");
            }
        }
    }
}
