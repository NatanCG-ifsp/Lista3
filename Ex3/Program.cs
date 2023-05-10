using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sexo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string S;

            Console.WriteLine("qual é o seu sexo?" );
            S = Console.ReadLine();

            while (S != "f" && S != "m")
            {
                Console.WriteLine("Invalido! use apenas f para feminino e m para masculino");
                S = Console.ReadLine();
            }
            Console.WriteLine($"seu sexo é: {S}");
        }
    }
}
