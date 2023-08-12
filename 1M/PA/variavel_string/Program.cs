using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variavel_string
{
    internal class Program
    {
        static void Main(string[] args)          

        {
            String modelo, marca, cor, ano, quilometragem;

            Console.WriteLine("Digite o modelo do veículo:");
            modelo = Console.ReadLine();
            Console.WriteLine("Digite a marca do veículo:");
            marca = Console.ReadLine();
            Console.WriteLine("Digite a cor do veículo:");
            cor = Console.ReadLine();
            Console.WriteLine("Digite o ano do veículo:");
            ano = Console.ReadLine();
            Console.WriteLine("Digite a quilometragem do veículo:");

            quilometragem = Console.ReadLine();

            Console.WriteLine("Modelo do veículo: " + modelo +
                "\nMarca do veículo: " + marca +
                "\nCor do veículo: " + cor +
                "\nAno do veículo: " + ano +
                "\nQuilometragem do veículo: " + quilometragem);

            Console.ReadKey();

        }
    }
}
