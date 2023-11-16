using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo_cadastro_prof_aluno_func
{
    class Professor
    {
        int id { get; set; }  
        String nome { get; set; }
        String disciplina { get; set; }
        String formacao { get; set; }

        public void cadastrar()
        {   
            Console.Write("Informe o id do professor: ");
            id = int.Parse(Console.ReadLine());
            Console.Write("Informe o nome do professor: ");
            nome = Console.ReadLine();
            Console.Write("insira a disciplina: ");
            disciplina = Console.ReadLine();
            Console.Write("Insira a formação: ");
            formacao = Console.ReadLine();
        }

        public void exibir()
        {
            Console.WriteLine("Id do professor: " + id + "\nNome do professor: " + nome + "\nDisciplina: " + disciplina + "\nFormação: " + formacao);
        }

    }

    
}
