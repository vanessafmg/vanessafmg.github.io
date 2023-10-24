using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_int
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] nome = { "João", "Pedro", "Maria" };
            Console.Write("Digite um número de 0 a 2: ");
            int i = int.Parse(Console.ReadLine());
            Console.Write("O nome selecionado foi: " + nome[i]);
            Console.ReadKey();
        }
    }
}
