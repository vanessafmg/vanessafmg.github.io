using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_new_for_carros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] modelo = new String[5];
            String[] cor = new String[5];
            int[] ano= new int[5];

            for (int i = 0; i <= 4; i++)
            {
                Console.Write("Digite o modelo do carro: ");
                modelo[i] = Console.ReadLine();
                Console.Write("Digite a cor do carro: ");
                cor[i] = Console.ReadLine();
                Console.Write("Digite o ano de fabricação do carro: ");
                ano[i] = int.Parse(Console.ReadLine());
            }

            for (int j = 0; j <= 4; j++)
            {
                Console.WriteLine("Modelo: " + modelo[j]);
                Console.WriteLine("Cor: " + cor[j]);
                Console.WriteLine("Ano de fabricação: " + ano[j]);
            }
            Console.ReadKey();
        }
    }
}
