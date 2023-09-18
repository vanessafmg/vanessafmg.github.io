using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace requisitos_ou
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("O candidato é afrodescendente (S/N)?");
            String afro = Console.ReadLine().ToUpper();
            Console.Write("O candidato tem renda familiar inferior a 2 salários mínimos (S/N)?");
            String renda = Console.ReadLine().ToUpper();
            Console.Write("O candidato estudou somente em escola pública (S/N)?");
            String publica = Console.ReadLine().ToUpper();

            if (afro == "S" || renda == "S" || publica == "S")
                Console.WriteLine("O candidado tem direito a pontuação.");
            else
                Console.WriteLine("O candidado não tem direito a pontuação.");

            Console.ReadKey();
        }
    }
}
