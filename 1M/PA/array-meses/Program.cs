using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_meses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] mes = {"JAN", "FEV", "MAR", "ABR", "MAI", "JUN", "JUL", "AGO", "SET", "OUT", "NOV", "DEZ" };
            Console.Write("Digite o número de um mês: ");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine("O mês escolhido foi: " + mes[i-1]);
            Console.ReadKey();
        }
    }
}
