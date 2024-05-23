using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _232017
{
    class Assalariado : Empregado
    {
        double salarioBruto { get; set; }
        double desconto { get; set; }

        public void cadastrar()
        {
            Console.Write("Informe o nome do assalariado: ");
            nome = Console.ReadLine();
            Console.Write("Informe o CPF do assalariado: ");
            cpf = Console.ReadLine();
            Console.Write("Informe o salário bruto: ");
            salarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Informe o desconto: ");
            desconto = double.Parse(Console.ReadLine());
        }

        public void calcularSalario()
        {
            salarioFinal = salarioBruto - desconto;
        }

        public void exibirDados()
        {
            Console.WriteLine("Nome do assalariado: " + nome + "\nCPF do assalariado: " + cpf + "\nSalário Final: " + salarioFinal.ToString("C"));
        }
    }
}
