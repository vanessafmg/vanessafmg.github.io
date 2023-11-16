using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraylist_assalariado_comissionado_horista
{
    class Comissionado
    {
        String nome { get; set; }
        double salario { get; set; }
        double vendas { get; set; }
        double comissao { get; set; }



        public void cadastrar()
        {
            Console.Write("Informe o nome: ");
            nome = Console.ReadLine();
            Console.Write("Informe o salário: ");
            salario = double.Parse(Console.ReadLine());
            Console.Write("informe as vendas: ");
            vendas = double.Parse(Console.ReadLine());
            Console.Write("informe a comissão: ");
            comissao = double.Parse(Console.ReadLine());

        }

        public void exibir()
        {
            Console.WriteLine("Nome: " + nome + "\nSalário: " + salario.ToString("C") + "\nVendas: " + vendas.ToString("C") + 
                "\nComissão: " + comissao.ToString("C"));
        }
    }
}

