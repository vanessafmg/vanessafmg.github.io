using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_for_mes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] mes = { "JAN", "FEV", "MAR", "ABR", "MAI", "JUN", "JUL", "AGO", "SET", "OUT", "NOV", "DEZ" };

            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine("Mês: " + i + " Nome: " + mes[i-1]);
            }
            Console.ReadKey();
        }
    }
}
