using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_compras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] produto = new String[4];
            int[] quantidade = new int[4];
            double[] valor = new double[4];
            double total = 0;
            double t_final = 0;

            for (int i = 0; i <= 3; i++)
            {
                Console.Write("Digite o produto: ");
                produto[i] = Console.ReadLine();
                Console.Write("Digite a quantidade: ");
                quantidade[i] = int.Parse(Console.ReadLine());
                Console.Write("Digite o valor unitário: ");
                valor[i] = double.Parse(Console.ReadLine());
            }

            for (int j = 0; j <= 3; j++)
            {
                total = quantidade[j] * valor[j];
                t_final += total;
                Console.WriteLine("Produto: " + produto[j] + " Quantidade: " + quantidade[j] + " Valor unitário: " + valor[j].ToString("C") + 
                    " Valor Total: " + total.ToString("C"));
            }

            Console.WriteLine("Total final da venda: " + t_final.ToString("C"));

            Console.ReadKey();
        }
    }
}
