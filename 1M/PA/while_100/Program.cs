using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe até onde você quer contar: ");
            int vezes = int.Parse(Console.ReadLine());

            int cont = 1;
            while (cont <= vezes)
            {
                Console.WriteLine(cont);
                cont++;
            }
            Console.ReadKey();
        }
    }
}
