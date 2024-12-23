using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursAF_Palindrom_console
{
    // Afiseaza decat numerele palindrom dintr-un vector de numere
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] data = Console.ReadLine().Split(' ');

            int[] v = new int[n];

            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(data[i]);
                if (IsPalindrome(v[i]))
                    Console.Write(v[i] + " ");
            }
        }

        public static bool IsPalindrome(int n)
        {
            int oglindit = 0, copie_n = n;

            while (n != 0)
            {
                oglindit = oglindit * 10 + n % 10;
                n = n / 10;
            }

            if (oglindit == copie_n)
                return true;
            return false;
        }
    }
}
