using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo_cadastro_prof_aluno_func
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();
            Aluno a = new Aluno();
            Professor p = new Professor();
            String resp;

            do            
               
            {
                Console.Write("Você deseja cadastrar um Professor (P), um aluno (A), ou um Funcionário (F)? ");
                String escolha = Console.ReadLine().ToUpper();

                switch (escolha)
                {
                    case "P":
                        p.cadastrar();
                        p.exibir();
                        break;

                    case "A":
                        a.cadastrar();
                        a.exibir();
                        break;

                    default:
                        f.cadastrar();
                        f.exibir();
                        break;
                }

                Console.WriteLine("Deseja realizar outro cadastro? (S/N) ");
                resp = Console.ReadLine().ToUpper();
            }
            while (resp == "S");

        }
    }
}
