using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace percentual_esgoto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o valor da taxa de esgoto: ");
            double esgoto = double.Parse(Console.ReadLine());
            Console.Write("Informe o valor total da conta: ");
            double conta = double.Parse(Console.ReadLine());

            Console.WriteLine("O percentual da taxa de esgoto é: " + (esgoto/conta).ToString("P"));

            Console.ReadKey();
        }
    }
}
