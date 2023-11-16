using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manipulando_arraylist
{
    class Aluno
    {
        public int rm { get; set; }
        String nome { get; set; }
        String curso { get; set; }

        public void cadastrar()
        {
            Console.Write("Informe o RM do aluno: ");
            rm = int.Parse(Console.ReadLine());
            Console.Write("Informe o nome do aluno: ");
            nome = Console.ReadLine();
            Console.Write("Informe o curso do aluno: ");
            curso = Console.ReadLine();

        }

        public void exibir()
        {
            Console.WriteLine("RM do aluno: " + rm + "\nNome do aluno: " + nome + "\nCurso do aluno: " + curso);
        }

        public void alterar()
        {
            Console.Write("Informe o nome do aluno: ");
            nome = Console.ReadLine();
            Console.Write("Informe o curso do aluno: ");
            curso = Console.ReadLine();
        }
    }
}
