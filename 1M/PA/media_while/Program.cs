using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace media_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cont = 1;
            double resultado = 0;
            while (cont<=4)
            {
                Console.Write("Informe a nota: ");
                double nota = double.Parse(Console.ReadLine());
                resultado += nota;
                cont++;
            
            }
            Console.WriteLine("A média é: " + resultado / 4);
            Console.ReadKey();
        }
    }
}
