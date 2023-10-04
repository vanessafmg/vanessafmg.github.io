using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _232017_correcao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario = 0;
            Console.WriteLine("Informe a forma de contratação: \n(A)ssalariado\n(C)omissionado\n(H)orista");
            String contrato = Console.ReadLine().ToUpper();

            switch (contrato)
            {
                case "A":
                    Console.Write("Informe o salário bruto: ");
                    double bruto = double.Parse(Console.ReadLine());
                    Console.Write("Informe o desconto: ");
                    double desconto = double.Parse(Console.ReadLine());
                    salario = bruto - desconto;
                    break;

                case "C":
                    Console.Write("Informe a quantidade de peças: ");
                    int pecas = int.Parse(Console.ReadLine());
                    Console.Write("Informe o valor da comissão/peça: ");
                    double comissao = double.Parse(Console.ReadLine());
                    salario = pecas * comissao;
                    break;

                case "H":
                    Console.Write("Informe o valor da hora: ");
                    double valor_hora = double.Parse(Console.ReadLine());
                    Console.Write("Informe a quantidade de horas trabalhadas: ");
                    int horas = int.Parse(Console.ReadLine());
                    salario = valor_hora * horas;
                    break;

                default:
                    Console.WriteLine("Informe uma opção válida.");
                    Console.ReadKey();
                    return;

            }
            Console.WriteLine("O salário é: " + salario.ToString("C"));

            double ir = 0;

            if (salario <= 2000)
            {
                ir = salario * .075;
            }

            else if (salario > 4000)
            {
                ir = salario * .15;
            }

            else
            {
                ir = salario * .12;
            }

            Console.WriteLine("O valor do IR é: " + ir.ToString("C"));

            Console.ReadKey();
        }
    }
}
