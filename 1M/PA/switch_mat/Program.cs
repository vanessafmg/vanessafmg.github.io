using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_mat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro número: ");
            double n1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            double n2 = double.Parse(Console.ReadLine());
            Console.Write("Escolha uma operação matemática: (1:+) (2:-) (3:*) (4:/)");
            int operacao = int.Parse(Console.ReadLine());

            switch (operacao)
            { 
                case 1: 
                    double resultado = n1 + n2;
                    Console.WriteLine("O resutado da adição é: " + resultado); 
                    break;

                case 2:
                    resultado = n1 - n2;
                    Console.WriteLine("O resutado da subtração é: " + resultado);
                    break;

                case 3:
                    resultado = n1 * n2;
                    Console.WriteLine("O resutado da multiplicação é: " + resultado);
                    break;

                case 4:
                    resultado = n1 / n2;
                    Console.WriteLine("O resutado da divisão é: " + resultado);
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
                Console.ReadKey();
        }
    }
}
