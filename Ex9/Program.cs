using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N1 = 0;
            int N2 = 1;
            Console.WriteLine(N1);
            Console.WriteLine(N2);
            for (int i = 3; i <= 30; i++)
            {
                int res = N1 + N2;
                Console.WriteLine(res);
                N1 = N2;
                N2 = res;
            }
        }
    }
}
