using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decisao_combustivel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o valor a ser abastecido (R$): ");
            double reais = double.Parse(Console.ReadLine());
            Console.Write("Informe o combustível (ETANOL:E/GASOLINA:G/DIESEL:D): ");
            String combustivel = Console.ReadLine().ToUpper();

            double litros;

            if (combustivel == "E")
            {
                litros = reais / 2.69;
                Console.WriteLine("Foram abastecidos " + litros.ToString("F2") + " litros de etanol."); 
            }

            else if (combustivel == "G")
            {
                litros = reais / 3.59;
                Console.WriteLine("Foram abastecidos " + litros.ToString("F2") + " litros de gasolina.");

            }
                //direto
            else if (combustivel == "D")
                Console.WriteLine("Foram abastecidos " + (reais / 3.29).ToString("F2") + " litros de diesel.");

            else
                Console.WriteLine("Opção inválida");

            Console.ReadKey();

        }
    }
}
