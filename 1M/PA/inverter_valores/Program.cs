using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inverter_valores
{
    internal class Program
    {
        static void Main(string[] args)
        {  
            String a, b, c;

            Console.Write("Informe o valor de a:");
            a = Console.ReadLine();
            Console.Write("Informe o valor de b:");
            b= Console.ReadLine();

            c = a;
            a = b;
            b = c;

            Console.WriteLine("O novo valor de a é: " + a + "\nO novo valor de b é: " + b);

            Console.ReadKey();



            
        }
    }
}
