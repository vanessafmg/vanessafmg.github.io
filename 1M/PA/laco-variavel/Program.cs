using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laco_variavel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String resp = "S";
            double valor, total = 0;

            while (resp == "S")
            {
                Console.WriteLine("Informe o valor do produto: ");
                valor = double.Parse(Console.ReadLine());

                total += valor;

                Console.WriteLine("Deseja inserir um novo produto?");
                resp = Console.ReadLine().ToUpper();
             }
            Console.WriteLine("O valor final da venda é: " + total.ToString("C"));
            Console.ReadKey();

        }
    }
}
