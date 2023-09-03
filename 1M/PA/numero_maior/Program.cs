using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numero_maior
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1, n2;
            Console.Write("Digite o primeiro número: ");
            n1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            n2 = double.Parse(Console.ReadLine());

            if (n1 > n2)
            {
                Console.WriteLine("O primeiro número é o maior: " + n1);
            }
            else if (n1 == n2)
                // quando existe apenas uma linha não é necessário {}
                Console.WriteLine("Os dois números são iguais");
            else
            {
                Console.WriteLine("O segundo número é o maior: " + n2);
            }
            Console.ReadKey();
        }
    }
}
