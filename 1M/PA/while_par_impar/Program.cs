using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_par_impar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Números pares (0) ou ímpares (1)? ");
            int n = int.Parse(Console.ReadLine());

            int cont = n;
            while (cont <= 20)
            {
                Console.WriteLine(cont);
                cont += 2;
            }
            Console.ReadKey();
                      
        }
    }
}
