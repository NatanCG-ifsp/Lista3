using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomaNum1_a_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;

            for (int i = 1; i < 101; i++)
            {
                soma += i;
            }
            Console.WriteLine($"o resultado da soma é: {soma}");
        }
    }
}
