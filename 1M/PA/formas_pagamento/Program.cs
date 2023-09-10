using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formas_pagamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o valor da venda: ");
            double venda = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o tipo de pagamento: \nDinheiro (DI): 10% de desconto\nCartão (CA): 7,5% de desconto \nCheque (CH): 5% de desconto");
            String pgto = Console.ReadLine().ToUpper();

            if (pgto == "DI")
            {
                double desconto = venda * (10.0/100.0);
                
                Console.WriteLine("O desconto será de: " + desconto.ToString("C"));
            }
            else if (pgto == "CA")
            {
                double desconto = venda * .075;
                Console.WriteLine("O desconto será de: " + desconto.ToString("C"));
            }
            else if (pgto == "CH")
            {
                double desconto = venda * .05;
                Console.WriteLine("O desconto será de: " + desconto.ToString("C"));
            }
            else
            {
                Console.WriteLine("Opção inválida");
            }

            Console.ReadKey();
        }
    }
}
