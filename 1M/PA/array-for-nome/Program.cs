using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_for_nome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] nome = { "João", "Pedro", "Maria", "Jose" };

            for (int i =0; i<=3; i++)
            {
                Console.WriteLine("Posição: " + i + " Nome: " + nome[i]);
            }
            Console.ReadKey();
        }
    }
}
