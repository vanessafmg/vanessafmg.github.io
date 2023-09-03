using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decisao_operacao_mat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro número: ");
            double n1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a operação matemática desejada (+-/*): ");
            String operacao = Console.ReadLine();

            if (operacao == "+")
                Console.WriteLine("O resultado é: " + (n1 + n2));

            else if (operacao == "-")
                Console.WriteLine("O resultado é: " + (n1 - n2));

            else if (operacao == "*")
                Console.WriteLine("O resultado é: " + n1 * n2);

            else if (operacao == "/")
                Console.WriteLine("O resultado é:" + n1 / n2);
            else
                Console.WriteLine("Opção inválida");

            Console.ReadKey();

        }
    }
}
