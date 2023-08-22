using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculo_salario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario, npecas, comissao, km, valor_km, salario_total;

            Console.WriteLine("Informe o salário fixo:");
            salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de peças vendidas:");
            npecas = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor da comissão por peça:");
            comissao = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a kilometragem percorrida:");
            km = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor por km percorrido:");
            valor_km = double.Parse(Console.ReadLine());

            salario_total = salario + npecas*comissao + km*valor_km;

            Console.WriteLine("Salário final do vendedor: " + salario_total.ToString("C"));

            Console.ReadKey();

            



        }
    }
}
