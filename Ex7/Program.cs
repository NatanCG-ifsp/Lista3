using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuadas1_ao_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 20; i++)
            {
                for (int j = 1;j < 11; j++)
                {
                    int res = i * j;
                    Console.WriteLine($"{i} x {j} = {res}");
                }
                Console.ReadLine();
            }
        }
    }
}
