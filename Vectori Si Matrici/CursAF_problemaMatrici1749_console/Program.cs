using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbinfo_1749
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] t = Console.ReadLine().Split(' ');
            int n = int.Parse(t[0]);
            int k = int.Parse(t[1]);
            int[,] m = new int[n, n];

            int sn = 0, sv = 0, se = 0, ss = 0;

            for (int i = 0; i < n; i++)
            {
                string[] buffer = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                    m[i, j] = int.Parse(buffer[j]);
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i < j && i + j < n - 1)
                        sn += m[i, j];
                    if (i < j && i + j > n - 1)
                        se += m[i, j];
                    if (i > j && i + j > n - 1)
                        ss += m[i, j];
                    if (i > j && i + j < n - 1)
                        sv += m[i, j];
                }
            }

            switch (k)
            {
                case 1: Console.Write(sn); break;
                case 2: Console.Write(se); break;
                case 3: Console.Write(ss); break;
                case 4: Console.Write(sv); break;
                default: break;
            }
        }
    }
}

