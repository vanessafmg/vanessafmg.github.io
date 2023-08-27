using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculo_lucro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o número de peças: ");
            int pecas = int.Parse(Console.ReadLine());
            Console.Write("Informe o valor de compra das peças: ");
            double valor_compra = double.Parse(Console.ReadLine());
            Console.Write("Informe o valor de venda das peças: ");
            double valor_venda = double.Parse(Console.ReadLine());
            Console.Write("Informe os demais custos fixos da empresa: ");
            double fixo = double.Parse(Console.ReadLine());

            double faturamento = pecas * valor_venda;
            double custo = pecas * valor_compra + fixo;
            double lucro = faturamento - custo;

            Console.WriteLine("O faturamento da empresa é: " + faturamento.ToString("C") + 
                "\nO custo total da empresa é: " + custo.ToString("C") + 
                "\nO lucro da empresa é: " + lucro.ToString("C"));

            Console.ReadKey();

        }
    }
}
