using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_pares_impares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numero = new int[10];
            int pares = 0;
            int impares = 0;
            for (int i = 0; i<=9; i++)
            {
                Console.Write("Digite um número: ");
                numero[i] = int.Parse(Console.ReadLine());
                if (numero[i] %2 == 0)
                {
                    pares++;
                }
                else
                    impares++;
            }
            Console.WriteLine("Números pares: " + pares);
            Console.WriteLine("Números ímpares: " + impares);
            Console.ReadKey();
        }
    }
}
