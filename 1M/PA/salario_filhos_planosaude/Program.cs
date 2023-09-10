using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salario_filhos_planosaude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o salário bruto do funcionário: ");
            double salario = double.Parse(Console.ReadLine());
            Console.WriteLine("O funcionário possui filhos (S/N)?");
            String filhos = Console.ReadLine().ToUpper();

            if (filhos == "S")
            {
                Console.Write("Informe a quantidade de filhos:");
                int qtd_filhos = int.Parse(Console.ReadLine());

                salario += (qtd_filhos * 200);
            }
           
            Console.Write("O funcionário optou por plano de saúde(S/N)?");
            String saude = Console.ReadLine().ToUpper();

            if (saude == "S")
            {
                salario -= 300;
            }

            if (salario <= 4000)
                salario -= (salario * .11);
            else
                salario -= (salario * .15);

            Console.WriteLine("Salário final: " + salario.ToString("C"));

            Console.ReadKey();
        }
    }
}
