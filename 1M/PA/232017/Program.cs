using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _232017
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String resp;
            do
            {
                Console.Clear();
                Console.WriteLine("Informe o cadastro a ser realizado: \n(A) Assalariado \n(C) Comissionado \n(H) Horista ");
                String op = Console.ReadLine().ToUpper();
                switch (op)
                {
                    case "A":
                        Assalariado a = new Assalariado();
                        a.cadastrar();
                        a.calcularSalario();
                        a.exibirDados();
                        break;

                    case "C":
                        Comissionado c = new Comissionado();
                        c.cadastrar();
                        c.calcularSalario();
                        c.exibirDados();
                        break;

                    case "H":
                        Horista h = new Horista();
                        h.cadastrar();
                        h.calcularSalario();
                        h.exibirDados();
                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        break;

                }
                Console.Write("Deseja realizar outro cadastro? (S/N)");
                resp = Console.ReadLine().ToUpper();
            }
            while (resp == "S");

        }
    }
}
