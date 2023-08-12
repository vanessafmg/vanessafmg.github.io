using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace media
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double aluno1, aluno2, aluno3, media;

            Console.WriteLine("Digite a idade do primeiro aluno:");
            aluno1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a idade do segundo aluno:");
            aluno2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a idade do terceiro aluno:");
            aluno3 = double.Parse(Console.ReadLine());

            media = (aluno1 + aluno2 + aluno3) / 3;

            Console.WriteLine("A idade média dos três alunos é: " + media);
            
            Console.ReadKey();
        }
    }
}
