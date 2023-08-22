using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculo_idade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int anos, meses, dias, total;

            Console.WriteLine("Informe sua idade em anos:");
            anos= int.Parse(Console.ReadLine());

            Console.WriteLine("Informe sua idade em meses:");
            meses= int.Parse(Console.ReadLine());

            Console.WriteLine("Informe sua idade em dias:");
            dias= int.Parse(Console.ReadLine());

            total = anos * 365 + meses * 30 + dias;
            Console.WriteLine("O total de dias vividos é: " + total);

            Console.ReadKey();
        }
    }
}
