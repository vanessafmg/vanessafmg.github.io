using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraylist_assalariado_comissionado_horista
{
    class Horista
    {
        String nome { get; set; }
        double salario { get; set; }
        double valorHora { get; set; }
        int horas { get; set; }


        public void cadastrar()
        {
            Console.Write("Informe o nome: ");
            nome = Console.ReadLine();
            Console.Write("Informe o salário: ");
            salario = double.Parse(Console.ReadLine());
            Console.Write("informe o valor da hora: ");
            valorHora = double.Parse(Console.ReadLine());
            Console.Write("informe as horas: ");
            horas = int.Parse(Console.ReadLine());

        }

        public void exibir()
        {
            Console.WriteLine("Nome: " + nome + "\nSalário: " + salario.ToString("C") + "\nValor da hora : " + valorHora.ToString("C") + 
                "\nHoras: " + horas);
        }
    }
}
