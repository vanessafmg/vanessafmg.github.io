using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anuidade_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a anuidade: ");
            double anuidade = double.Parse(Console.ReadLine());
            Console.Write("Informe o valor da matrícula: ");
            double matricula = double.Parse(Console.ReadLine());
            Console.Write("Informe o valor do material: ");
            double material = double.Parse(Console.ReadLine());
            double mensalidade = anuidade / 12;
            
            int cont = 1;
            
            while (cont <=12)
            {
                if (cont==1)
                Console.WriteLine("Mensalidade: "+ cont + " valor: " + (mensalidade+material+matricula).ToString("C"));
                else
                    Console.WriteLine("Mensalidade: " + cont + " valor: " + mensalidade.ToString("C"));
                cont++;
            }
            Console.ReadKey();

        }
    }
}
