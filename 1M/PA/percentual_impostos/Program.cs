using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace percentual_impostos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o valor de venda do produto: ");
            double valor_venda = double.Parse(Console.ReadLine());
            Console.Write("Informe o % de ICMS: ");
            double icms = double.Parse(Console.ReadLine());
            Console.Write("Informe o % de IPI: ");
            double ipi = double.Parse(Console.ReadLine());
            Console.Write("Informe o % de PIS: ");
            double pis = double.Parse(Console.ReadLine());
            Console.Write("Informe o % de COFINS: ");
            double cofins = double.Parse(Console.ReadLine());

            double vlr_icms = (valor_venda * icms / 100);
            double vlr_ipi = (valor_venda * ipi / 100);
            double vlr_pis = (valor_venda * pis/ 100);
            double vlr_cofins = (valor_venda * cofins / 100);


            Console.WriteLine("Valor do ICMS: " + vlr_icms.ToString("C") +
                              "\nValor do IPI: " + vlr_ipi.ToString("C") +
                              "\nValor do PIS: " + vlr_pis.ToString("C") +
                              "\nValor do COFINS: " + vlr_cofins.ToString("C"));

            Console.WriteLine("Valor final do produto: " + (valor_venda + vlr_icms + vlr_ipi+ vlr_pis+ vlr_cofins).ToString("C"));

            Console.ReadKey();


        }
    }
}
