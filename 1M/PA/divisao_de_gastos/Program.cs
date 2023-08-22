using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace divisao_de_gastos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o valor gasto em comida:");
            double comida = double.Parse(Console.ReadLine());
            Console.Write("Informe o valor gasto em bebida:");
            double bebida = double.Parse(Console.ReadLine());
            Console.Write("Informe o valor gasto em sobremesa:");
            double sobremesa = double.Parse(Console.ReadLine());

            double total = comida+bebida+sobremesa;
            Console.WriteLine("O total gasto foi:" + total.ToString("C"));

            Console.Write("Informe o número de pessoas:");
            int npessoas = int.Parse(Console.ReadLine());

            double gasto_pessoa = total / npessoas;

            Console.Write("O total gasto por pessoa foi:" + gasto_pessoa.ToString("C"));

            Console.ReadKey();

        }
    }
}
