using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_for_despesas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] despesa = { "Água", "Energia", "Telefone", "Internet" };
            Double[] valor = { 115.5,225,98.55,100.25 };
            Double total = 0;

            for (int i = 0; i <= 3; i++)
            {
                total += valor[i];
                Console.WriteLine("Despesa: " + despesa[i] + " - Valor: " + valor[i].ToString("C"));
            }
            Console.WriteLine("O valor total das despesas é: " +total.ToString("C"));
            Console.ReadKey();
        }
    }
}
