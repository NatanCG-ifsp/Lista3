using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoisValores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N1, N2;
            
            Console.WriteLine("digite o primeiro valor");
            N1 = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o segundo valor");
            N2 = int.Parse(Console.ReadLine());
            do
            {
                if (N2 < N1)
                {
                    Console.WriteLine("Valor inválido! o segundo valor deve ser maior.");
                    do
                    {
                        Console.Write("Digite o segundo número novamente: ");
                        N2 = int.Parse(Console.ReadLine());
                    }while (N2 <= N1) ;
                };

            } while (N2 < N1);
            Console.WriteLine("o segundo valor é maior");
        }
    }
}