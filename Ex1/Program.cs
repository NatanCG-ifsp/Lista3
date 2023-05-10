using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValorPos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float N1;

            do
            {
                Console.Write("Digite um valor positivo: ");
                N1 = float.Parse(Console.ReadLine());
                if (N1 <=0)
                {
                    Console.WriteLine("Valor inválido! Digite um valor positivo.");
                }
                    
            } while (N1 <= 0);
            Console.WriteLine($"O valor é: {N1}");
        }
    }
}
