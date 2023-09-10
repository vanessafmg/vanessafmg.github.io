using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imposto_renda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor do salário: ");
            double salario = double.Parse(Console.ReadLine());

            if (salario <= 2000)
            {
                double imposto = salario * 7.5 / 100;
                Console.WriteLine("O valor do imposto é: " + imposto);
            }

            else if (salario > 4000)
            { 
                double imposto = salario * 12 / 100;
                Console.WriteLine("O valor do imposto é: " + imposto);
            }
            else
            { 
                double imposto = salario * 15 / 100;
                Console.WriteLine("O valor do imposto é: " + imposto);
            }

            Console.ReadKey();

        }
    }
}
