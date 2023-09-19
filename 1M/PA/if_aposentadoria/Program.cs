using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_aposentadoria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o ano corrente: ");
            int ano= int.Parse(Console.ReadLine());
            Console.Write("Informe o ano de nascimento do funcionário: ");
            int ano_nasc = int.Parse(Console.ReadLine());
            double idade = ano - ano_nasc;

            Console.Write("Informe o ano de ingresso na empresa: ");
            int ingresso = int.Parse(Console.ReadLine());
            int anos_trabalhados = ano - ingresso;

            if ((idade >= 65 || anos_trabalhados >= 30) || idade >= 60 && anos_trabalhados >= 25)
            
               Console.WriteLine("Idade: " + idade + "\nTempo de trabalho: " + anos_trabalhados + "\nTem direiro a aposentadoria."); 
            else
             Console.WriteLine("Idade: " + idade + "\nTempo de trabalho: " + anos_trabalhados + "\nNão tem direito a aposentadoria.");

            Console.ReadKey();


            
        }
    }
}
