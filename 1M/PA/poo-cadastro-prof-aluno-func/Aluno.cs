using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo_cadastro_prof_aluno_func
{
    class Aluno
    {
        int id { get; set; }
        String nome { get; set; }
        String curso { get; set; }
        String cidade { get; set; }

        public void cadastrar()
        {
            Console.Write("Informe o id do aluno: ");
            id = int.Parse(Console.ReadLine());
            Console.Write("Informe o nome do aluno: ");
            nome = Console.ReadLine();
            Console.Write("insira a curso: ");
            curso = Console.ReadLine();
            Console.Write("Informe a cidade do aluno: ");
            cidade = Console.ReadLine();
        }

        public void exibir()
        {
            Console.WriteLine("Id do aluno: " + id + "\nNome do aluno: " + nome + "\nCurso: " + curso + "\nCidade do aluno: " + cidade);
        }
    }
}
