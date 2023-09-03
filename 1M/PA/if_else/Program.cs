using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else
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
            else 
            {
                Console.WriteLine("Você é menor de idade");
                int falta = 18 - idade;
                Console.WriteLine("Faltam " + falta + " anos para a maioridade");
            }
             
            Console.Write("Você gosta de programação? (S/N): ");
            String resposta = Console.ReadLine().ToUpper();

            if (resposta == "S")
            {
                Console.WriteLine("SIM");
            }
            else
            {
                Console.WriteLine("NÃO");
            }
             
            Console.ReadKey();
        }
    }
}
