using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salario_liquido
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Salário bruto: ");
            double sal_bruto = double.Parse(Console.ReadLine());
            Console.Write("Vale alimentação: ");
            double vale = double.Parse(Console.ReadLine());
            Console.Write("Quantidade de filhos: ");
            int filhos = int.Parse(Console.ReadLine());
            Console.Write("Valor por filho: ");
            double valor_filho = double.Parse(Console.ReadLine());
            Console.Write("Quantidade de horas extras: ");
            int horas = int.Parse(Console.ReadLine());
            Console.Write("Valor por hora extra: ");
            double valor_hora = double.Parse(Console.ReadLine());
            Console.Write("Descontos de INSS: ");
            double inss = double.Parse(Console.ReadLine());
            Console.Write("Descontos de IRPF: ");
            double irpf = double.Parse(Console.ReadLine());

            double sal_liquido = sal_bruto + vale + filhos * valor_filho + horas * valor_hora -inss -irpf;

            Console.WriteLine("O salário líquido é: " + sal_liquido.ToString("C"));

            Console.ReadKey();

        }
    }
}
