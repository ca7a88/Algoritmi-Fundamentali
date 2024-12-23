using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursAFStackAndQueue
{
    public class Queue
    {
        TriData[] val;
        int n;

        public Queue()
        {
            val = new TriData[0];
        }

        public void Push(TriData v)
        {
            TriData[] T = new TriData[val.Length + 1];
            for (int i = 0; i < val.Length; i++)
                T[i + 1] = val[i];
            T[0] = v;
            val = T;
        }
        public TriData Pop()
        {
            TriData toR = val[val.Length - 1];
            TriData[] T = new TriData[val.Length - 1];
            for (int i = 0; i < val.Length - 1; i++)
                T[i] = val[i];
            val = T;
            return toR;
        }
        public void View()
        {
            for (int i = 0; i < val.Length; i++)
                val[i].View();
        }
    }
}
