using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gasto_combustivel
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            double valor_litro, distancia, consumo, gasto_total;

            Console.WriteLine("Digite o valor do litro de combustível:");
            valor_litro = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a distância da viagem em km: ");
            distancia = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o consumo do veículo (km/litro):");
            consumo = double.Parse(Console.ReadLine());

            gasto_total = distancia / consumo * valor_litro;

            Console.WriteLine("O gasto total da viagem foi:" + gasto_total);

            Console.ReadKey();
          
        }
    }
}
