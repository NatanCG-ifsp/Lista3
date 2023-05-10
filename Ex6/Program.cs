using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabuadaPos2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A,B, X;

            do
            {
                Console.Write("Digite o valor da tabuada: ");
                X = int.Parse(Console.ReadLine());
                if (X <= 0)
                {
                    Console.WriteLine("Valor inválido! Digite um valor positivo.");
                }

            } while (X <= 0);

            do
            {
                Console.WriteLine("intervalo da tabuada(digite um valor para A e em seguida um para B): ");
                A = int.Parse(Console.ReadLine());
                B = int.Parse(Console.ReadLine());
                if (B < A)
                {
                    Console.WriteLine("Valor inválido! o segundo valor deve ser maior.");
                    do
                    {
                        Console.Write("Digite o segundo número novamente: ");
                        B = int.Parse(Console.ReadLine());
                    } while (B <= A);
                }

            } while (B < A);

            for (int i = A; i <= B; i++)
            {
                int resultado = X * i;
                Console.WriteLine(X + " x " + i + " = " + resultado);
            }

        }
    }
}
