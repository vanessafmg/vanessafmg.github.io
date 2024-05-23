using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heranca_poo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String resp;
            do
            {
                Console.Clear();
                Console.Write("Informe o cadastro a ser realizado (P/A): ");
                String op = Console.ReadLine().ToUpper();
                switch (op)
                {
                    case "P":
                        Professor p = new Professor();
                        p.cadastrar();
                        p.exibir();
                        break;
                    case "A":
                        Aluno a = new Aluno();
                        a.cadastrar();
                        a.exibir();
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;

                }
                Console.Write("Deseja realizar outro cadastro: ");
                resp = Console.ReadLine().ToUpper();
            }
            while (resp == "S");
        
        }
    }
}
