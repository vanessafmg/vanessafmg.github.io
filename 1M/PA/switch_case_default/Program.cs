using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_case_default
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int teste;
                Console.Write("Digite ou 1 ou 2: ");
            teste = int.Parse(Console.ReadLine());

            switch (teste)
            {
                case 1:
                    Console.WriteLine("UM");
                    break;
                case 2:
                    Console.WriteLine("DOIS");
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
            Console.ReadKey();
        }
    }
}
