using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursAFStackAndQueue
{
    public class TriData
    {
        int l, c, v;
        public TriData(int l, int c, int v)
        {
            this.l = l;
            this.c = c;
            this.v = v;

        }
        public void View()
        {
            Console.Write($"({l}, {c}, {v})");
        }
    }
}
