using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10Valores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, soma = 0, maior = 0, contador = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"Digite o {i}º número positivo: ");
                num = int.Parse(Console.ReadLine());
                if (num > 0)
                {
                    soma += num;
                    contador++;
                    if (num > maior)
                    {
                        maior = num;
                    }
                }
                else
                {
                    Console.WriteLine("Número inválido! Digite um número positivo.");
                    i--;
                }
            }
            double media = (double)soma / contador;
            Console.WriteLine($"A soma dos números positivos é {soma}.");
            Console.WriteLine($"O maior número digitado foi {maior}.");
            Console.WriteLine($"A média aritmética dos números positivos é {media:F2}.");
        }
    }
}
