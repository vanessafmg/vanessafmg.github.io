using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acumulativo_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escolha o número: ");
            int numero = int.Parse(Console.ReadLine());

            int cont = 1;
            int resultado = 0;
            
            while (cont <= numero)
            {                  
                resultado += cont;
                cont++;
            }

            Console.WriteLine(resultado);
            Console.ReadKey();
        }
    }
}
