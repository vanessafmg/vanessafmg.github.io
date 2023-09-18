using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tres_diferentes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o primeiro número: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Informe o segundo número: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.Write("Informe o terceiro número: ");
            int n3 = int.Parse(Console.ReadLine());
            Console.Write("Informe o quarto número: ");
            int n4 = int.Parse(Console.ReadLine());

            if (n1 > n2 && n1 > n3 && n1>n4 )
                Console.WriteLine("O primeiro número é o maior: " + n1);
            else if (n2 > n3 && n2 > n4)
                Console.WriteLine("O segundo número é o maior: " + n2);
            else if (n3 > n4)
                Console.WriteLine("O terceiro número é o maior: " + n3);
            else
                Console.WriteLine("O quarto número é o maior: " + n4);
            
            Console.ReadKey();
            
        }
    }
}
