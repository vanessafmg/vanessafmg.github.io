using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_nomes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] nome = { "João", "Pedro", "Maria" };
            
            Console.WriteLine("Primeiro nome: " + nome[0]);
            Console.WriteLine("Segundo nome: " + nome[1]);
            Console.WriteLine("Terceiro nome: " + nome[2]);

            Console.ReadKey();
        }
    }
}
