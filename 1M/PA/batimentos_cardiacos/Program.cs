using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batimentos_cardiacos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a idade: ");
            long idade = long.Parse(Console.ReadLine());
            Console.Write("Informe os batimentos cardíacos/minuto: ");
            int bat_min = int.Parse(Console.ReadLine());

            int bat_hr = bat_min * 60;
            Console.WriteLine("Batimentos/hora: " + bat_hr);
            int bat_dia = bat_hr * 24;
            Console.WriteLine("Batimentos/dia: " + bat_dia);
            int bat_mes = bat_dia * 30;
            Console.WriteLine("Batimentos/mês: " + bat_mes);
            int bat_sem = bat_mes * 6;
            Console.WriteLine("Batimentos/semestre: " + bat_sem);
            int bat_ano = bat_sem * 2;
            Console.WriteLine("Batimentos/ano: " + bat_ano);
            long bat_total = bat_ano * idade;
            Console.WriteLine("O total de batimentos cardíacos conforme a idade é:" + bat_total);

            Console.ReadKey();



        }
    }
}
