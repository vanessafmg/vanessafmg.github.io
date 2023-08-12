using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fahrenheit_celsius
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double f, c;

            Console.WriteLine("Informe a temperatura em Fahrenheit:");
            f = double.Parse(Console.ReadLine());

            c = (f - 32) / 1.8;

            Console.WriteLine("A temperatura em celsius é: " + c);

            Console.ReadKey();




           
        }
    }
}
