using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursAFStackAndQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue A = new Queue();

            //A.Push(1);
            //A.Push(2);
            //A.Push(3);
            //A.Pop();
            //A.View();
            //Console.WriteLine();

            Stack B = new Stack();

            //B.Push(1);
            //B.Push(2);
            //B.Push(3);
            //B.Pop();
            //B.View();
            //Console.WriteLine();

            /////////////////////////////////////////////////////////////////////////////////

            string S = "2 1 + 3 * 7 1 * - 5 10 - 2 * +";
            string[] D = S.Split(' ');
            Stack C = new Stack();

            for (int i = 0; i < D.Length; i++)
            {
                if ((D[i])[0] >= '0' && (D[i])[0] <= '9')
                {
                    int t = int.Parse(D[i]);
                    // Console.Write(t + " ");
                    C.Push(t);
                }
                else
                {
                    int t1 = C.Pop();
                    int t2 = C.Pop();

                    switch ((D[i])[0])
                    {
                        case '+':
                            C.Push(t2 + t1);
                            break;
                        case '-':
                            C.Push(t2 - t1);
                            break;
                        case '*':
                            C.Push(t2 * t1);
                            break;
                        case '/':
                            C.Push(t2 / t1);
                            break;
                    }
                }
            }
            Console.WriteLine();
            // C.View();

            /////////////////////////////////////////////////////////////////////////////////

            Queue A1 = new Queue();
            A1.Push(new TriData(1, 2, 3));
            A1.Push(new TriData(4, 5, 6));
            A1.Push(new TriData(5, 5, 5));
            A1.View();
        }
    }
}
