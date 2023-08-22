using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace converter_moedas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dolar, euro, ouro, valor_investido, valor_dolar, valor_euro, valor_ouro;

            Console.WriteLine("Informe a cotação do Dólar:");
            dolar = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a cotação do Euro:");
            euro = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a cotação do Ouro:");
            ouro = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor a ser investido:");
            valor_investido = double.Parse(Console.ReadLine());

            valor_dolar = valor_investido / dolar;
            valor_euro = valor_investido / euro;
            valor_ouro = valor_investido / ouro;

            Console.WriteLine("Valor em Dólar: " + valor_dolar.ToString("F2"));
            Console.WriteLine("Valor em Euro: " + valor_euro.ToString("F2"));
            Console.WriteLine("Valor em Ouro: " + valor_ouro.ToString("F2"));

            Console.ReadKey();



                
         }
    }
}
