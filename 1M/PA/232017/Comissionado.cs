using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _232017
{
    class Comissionado : Empregado
    {
        double qtde { get; set; }
        double valorPeca { get; set; }

        public void cadastrar()
        {
            Console.Write("Informe o nome do comissionado: ");
            nome = Console.ReadLine();
            Console.Write("Informe o CPF do comissionado: ");
            cpf = Console.ReadLine();
            Console.Write("Informe a quantidade de peças: ");
            qtde = double.Parse(Console.ReadLine());
            Console.Write("Informe o valor da peça: ");
            valorPeca = double.Parse(Console.ReadLine());
        }

        public void calcularSalario()
        {
            salarioFinal = qtde * valorPeca;
        }

        public void exibirDados()
        {
            Console.WriteLine("Nome do comissionado: " + nome + "\nCPF do comissionado: " + cpf + "\nSalário Final: " + salarioFinal.ToString("C"));
        }
    }
}
