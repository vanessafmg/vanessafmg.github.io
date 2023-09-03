using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_idade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade;

            Console.Write("Informe a sua idade: ");
            idade = int.Parse(Console.ReadLine());

            if (idade >= 18)
            {
                Console.WriteLine("Você é maior de idade");                              
            }
            Console.ReadKey();
        }

               
    }
}
