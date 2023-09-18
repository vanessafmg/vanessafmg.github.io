using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alunos_aprovados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a média do aluno: ");
            double media = double.Parse(Console.ReadLine());
            Console.Write("Informe a % de presença do aluno: ");
            double presenca = double.Parse(Console.ReadLine());

            if (media >= 7 && presenca >= 75)
                Console.WriteLine("APROVADO");
            else if (((media < 7 && media >= 4) && presenca >= 75) || (media >= 7 && presenca < 75))
                Console.WriteLine("RECUPERAÇÃO");
            else 
                Console.WriteLine("RETIDO"); 

            Console.ReadKey();
        }
    }
}
