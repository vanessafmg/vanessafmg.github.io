using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heranca_poo
{
    class Aluno : Pessoa
    {
        String curso { get; set; }
        String cidade { get; set; }

        public void cadastrar()
        {
            Console.Write("Informe o ID do aluno: ");
            id = int.Parse(Console.ReadLine());
            Console.Write("Informe o nome do aluno: ");
            nome = Console.ReadLine();
            Console.Write("Informe o curso do aluno ");
            curso = Console.ReadLine();
            Console.Write("Informe a cidade do aluno: ");
            cidade = Console.ReadLine();
        }

        public void exibir ()
        {
            Console.WriteLine("ID do aluno: " + id + "\nNome do aluno: " + nome +
                "\nCurso do aluno: " + curso + "\nCidade do aluno: " + cidade);
        }
    }
}
