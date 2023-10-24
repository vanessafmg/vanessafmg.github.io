using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_maior_menor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int menor = 0;
            int maior = 0;

            for (int i=1; i <=10; i++)
            {
                Console.Write("Informe um número: ");
                int n = int.Parse(Console.ReadLine());

                if (i == 1)
                {
                    menor = n;
                    maior = n;
                }

                if (n < menor)
                    menor = n;
                if (n>maior) 
                    maior = n;
            }

            Console.WriteLine("Maior: " + maior);
            Console.WriteLine("Menor: " + menor);

            Console.ReadKey();
        }
    }
}
