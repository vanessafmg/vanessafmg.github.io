using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _232017
{
    class Horista : Empregado
    {
        double valorHora { get; set; }
        int horas { get; set; }

        public void cadastrar()
        {
            Console.Write("Informe o nome do horista: ");
            nome = Console.ReadLine();
            Console.Write("Informe o CPF do horista: ");
            cpf = Console.ReadLine();
            Console.Write("Informe o valor da hora: ");
            valorHora = double.Parse(Console.ReadLine());
            Console.Write("Informe a quantidade de horas: ");
            horas = int.Parse(Console.ReadLine());
        }

        public void calcularSalario()
        {
            salarioFinal = valorHora * horas;
        }

        public void exibirDados()
        {
            Console.WriteLine("Nome do horista: " + nome + "\nCPF do horista: " + cpf + "\nSalário Final: " + salarioFinal.ToString("C"));
        }
    }
}
