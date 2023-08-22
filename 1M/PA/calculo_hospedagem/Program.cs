using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculo_hospedagem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o valor da diária do hotel: ");
            double diaria = double.Parse(Console.ReadLine());
            Console.Write("Informe a quantidade de adultos: ");
            int adultos = int.Parse(Console.ReadLine());
            Console.Write("Informe a quantidade de crianças: ");
            int criancas = int.Parse(Console.ReadLine());

            double diaria_familia = diaria*adultos + diaria/2 *criancas;
            Console.WriteLine("O valor por dia da família será: " + diaria_familia.ToString("C"));

            Console.Write("Informe o número de dias de hospedagem: ");
            int dias = int.Parse(Console.ReadLine());

            double total_hospedagem = diaria_familia * dias;
            Console.WriteLine("O valor total da hospedagem é: " + total_hospedagem.ToString("C"));

            Console.Write("Informe a quantidade de parcelas: ");
            int parcelas = int.Parse(Console.ReadLine());

            double cd_parcela = total_hospedagem/parcelas;

            Console.WriteLine("O valor de cada parcela é: " + cd_parcela.ToString("C"));

            Console.ReadKey();

        }
    }
}
