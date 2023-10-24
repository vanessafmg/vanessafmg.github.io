using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_new_for_nome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String [] nome = new String[5];

            for (int i = 0; i<=4; i++)
            {
                Console.Write("Digite o nome do aluno: ");
                nome[i] = Console.ReadLine(); 
            }
            
            for (int j=0; j<=4; j++)
            {
                Console.WriteLine("Aluno: " + nome[j]);
            }
            Console.ReadKey();

        }
    }
}
