using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_new
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String [] nome = new String[3];

            Console.Write("Digite o primeiro nome: ");
            nome[0] = Console.ReadLine();
            Console.Write("Digite o segundo nome: ");
            nome[1] = Console.ReadLine();
            Console.Write("Digite o terceiro nome: ");
            nome[2] = Console.ReadLine();

            Console.WriteLine("Primeiro nome: " + nome[0]);
            Console.WriteLine("Segundo nome: " + nome[1]);
            Console.WriteLine("Terceiro nome: " + nome[2]);

            Console.ReadKey();

        }
    }
}
