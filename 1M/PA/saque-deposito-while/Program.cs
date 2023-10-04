using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saque_deposito_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o saldo da conta: ");
            double saldo = double.Parse(Console.ReadLine());
            String resp = "S";

            while (resp == "S")

            {
                Console.Write("Deseja realizar um saque ou um depósito (S/D)? ");
                String operacao = Console.ReadLine().ToUpper();
                if (operacao == "S")
                {
                    Console.Write("Informe o valor que deseja sacar: ");
                    double saque = double.Parse(Console.ReadLine());
                    if (saque <= saldo)
                    {
                        saldo -= saque;
                    }
                    else
                    {
                        Console.WriteLine("Saldo indisponível");
                    }
                }
                else
                {  
                Console.Write("Informe o valor que deseja depositar: ");
                double deposito = double.Parse(Console.ReadLine());
                saldo += deposito;
                }

                Console.Write("Deseja realizar outra operação? (S/N) ");
                resp = Console.ReadLine().ToUpper();
             }
            
            
            Console.WriteLine("Saldo atual da conta: " + saldo.ToString("C"));
            Console.ReadKey();
        }
    }
}
