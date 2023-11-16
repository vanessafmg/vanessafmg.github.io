using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo_arraylist_foreach
{
    class Pessoa
    {
        String nome { get; set; }
        int idade { get; set; }
        double peso { get; set; }

        public void cadastrarPessoa()
        {
            Console.Write("Informe o nome da pessoa: ");
            nome = Console.ReadLine();
            Console.Write("Informe a idade da pessoa: ");
            idade = int.Parse(Console.ReadLine());
            Console.Write("informe o peso da pessoa: ");
            peso = double.Parse(Console.ReadLine());

        }

        public void exibirPessoa()
        {
            Console.WriteLine("Nome da pessoa: " + nome + "\nIdade da pessoa: " + idade + "\nPeso da pessoa: " + peso);
        }
    }
}
