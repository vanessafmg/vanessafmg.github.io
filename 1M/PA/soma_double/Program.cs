using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soma_double
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Criar variáveis
            double transporte, xerox, cantina, apm, total;

            //Entrada de dados
            Console.WriteLine("Digite o valor gasto em transporte:");
            transporte = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor gasto em xerox:");
            xerox = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor gasto em cantina:");
            cantina = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor gasto em apm:");
            apm = double.Parse(Console.ReadLine());

            //Processamento
            total = transporte + xerox + cantina + apm;

            //Saída de dados
            Console.WriteLine("O valor total gasto no mês foi: " + total);

            Console.ReadKey();            

        }
    }
}
