using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo_cadastro_prof_aluno_func
{
    class Funcionario
    {
        int id { get; set; }
        String nome { get; set; }
        String funcao { get; set; }
        double salario { get; set; }

        public void cadastrar()
        {
            Console.Write("Informe o id do funcionário: ");
            id = int.Parse(Console.ReadLine());
            Console.Write("Informe o nome do funcionário: ");
            nome = Console.ReadLine();
            Console.Write("insira a função: ");
            funcao = Console.ReadLine();
            Console.Write("Informe o salário: ");
            salario = double.Parse(Console.ReadLine());
        }

        public void exibir()
        {
            Console.WriteLine("Id do funcionário: " + id + "\nNome do funcionário: " + nome + "\nFunção: " + funcao + "\nSalário " + salario.ToString("C"));
        }
    }
}
