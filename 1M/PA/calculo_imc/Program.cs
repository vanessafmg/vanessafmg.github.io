using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculo_imc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double altura, peso, imc;

            Console.WriteLine("Digite o peso:");
            peso = double.Parse (Console.ReadLine ());

            Console.WriteLine("Digite a altura:");
            altura = double.Parse (Console.ReadLine ());

            imc = peso / (altura * altura);

            Console.WriteLine("O IMC é: " + imc);

            Console.ReadKey();

        }
    }
}
