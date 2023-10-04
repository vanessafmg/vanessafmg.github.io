using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuada_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o número que quer a tabuada: ");
            int tabuada = int.Parse(Console.ReadLine());
            Console.Write("Informe o número de vezes: ");
            int vezes = int.Parse(Console.ReadLine());

            int cont = 1;
            
            while (cont <= vezes)
            {
                int resultado = tabuada * cont;
                Console.WriteLine(tabuada + "*" + cont + "=" + resultado);
                cont++;
            }
            Console.ReadKey();


        }
    }
}
