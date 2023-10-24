using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace despesas_do_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String resp;
            double total = 0;
            do
            {
                Console.Write("Informe a despesa: ");
                String desp = Console.ReadLine();
                Console.Write("Informe o valor: ");
                double despesa = double.Parse(Console.ReadLine());
                total+= despesa;
                Console.WriteLine("Deseja inserir uma nova despesa? ");
                resp = Console.ReadLine().ToUpper();
            }

            while (resp == "S");

            Console.WriteLine("O valor total de despesas é: " + total.ToString("C"));
            Console.Write("Informe o número de pessoas: ");
            int pessoas = int.Parse(Console.ReadLine());
            Console.WriteLine("O gasto médio por pessoa é: " + (total/pessoas).ToString("C"));
            Console.ReadKey();
        }
       
    }
}
