using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heranca_poo
{
    class Professor: Pessoa
    {
        String disciplina { get; set; }
        String formacao { get; set; }

        public void cadastrar()
        {
            Console.Write("Informe o ID do professor: ");
            id = int.Parse(Console.ReadLine());
            Console.Write("Informe o nome do professor: ");
            nome = Console.ReadLine();
            Console.Write("Informe a disciplina do professor ");
            disciplina = Console.ReadLine();
            Console.Write("Informe a formação do professor: ");
            formacao = Console.ReadLine();
        }

        public void exibir()
        {
            Console.WriteLine("ID do professor: " + id + "\nNome do professor: " + nome +
                "\nDisciplina do professor: " + disciplina + "\nFormação do professor: " + formacao);
        }
    }
}
