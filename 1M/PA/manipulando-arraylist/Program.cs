using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manipulando_arraylist
{
    internal class Program
    {   static ArrayList lista = new ArrayList();
        static void Main(string[] args)
        {
            int op;
            do
            {
                Console.Clear();
                Console.WriteLine("(1) Incluir \n(2) Excluir \n(3) Consultar \n(4) Listar \n(5) Alterar \n(9) Sair");
                Console.Write("Informe uma das opções: ");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Aluno a = new Aluno();
                        a.cadastrar();
                        lista.Add(a);
                        break;
                    case 2:
                        excluir();
                        break;
                    case 3:
                        consultar();
                        break;
                    case 4:
                        listar();
                        break;
                    case 5:
                        alterar();
                        break;
                }

            }
            while (op != 9);
        }
        static void excluir()
        {
            Console.Write("Digite o RM para a exclusão: ");
            int rm = int.Parse(Console.ReadLine());
            foreach (Aluno a in lista)
            {
                if (rm == a.rm)
                {
                    lista.Remove(a);
                    return;
                }
            }
        }

        static void consultar()
        {
            Console.Write("Digite o RM para a consulta: ");
            int rm = int.Parse(Console.ReadLine());
            foreach (Aluno a in lista) if (rm == a.rm) a.exibir();
            Console.ReadKey();          
        }

        static void listar()
        {
            foreach (Aluno a in lista) a.exibir();
            Console.WriteLine("Total de alunos cadastrados: " + lista.Count);
            Console.ReadKey();
        }

        static void alterar()
        {
            Console.Write("Digite o RM do aluno que deseja alterar: ");
            int rm = int.Parse(Console.ReadLine());
            foreach (Aluno a in lista) if (rm == a.rm) a.alterar();
            Console.ReadKey();
        }
    }
}
