using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace porcentagem_salario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o salário: ");
            double salario = double.Parse(Console.ReadLine());
            Console.Write("Informe a porcentagem de desconto: ");
            double porcentagem = double.Parse(Console.ReadLine());

            if (porcentagem <= 100)
            {
                double desconto = salario * (porcentagem / 100);
                Console.WriteLine("O valor do desconto é: " + desconto.ToString("C"));
                Console.WriteLine("Valor do salário: " + (salario - desconto).ToString("C"));
            }
            Console.ReadKey();
        }
    }
}
