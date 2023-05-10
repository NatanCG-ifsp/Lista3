using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabuadaPos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N1;

            do
            {
                Console.Write("Digite um valor: ");
                N1 = int.Parse(Console.ReadLine());
                if (N1 <= 0)
                {
                    Console.WriteLine("Valor inválido! Digite um valor positivo.");
                }

            } while (N1 <= 0);
            Console.WriteLine($"O valor é: {N1}");

            for (int i = 0; i <= 10; i++)
            {
                float res = i * N1;
                Console.WriteLine($" {N1} X {i} = {res}");

            }
        }
    }
}
