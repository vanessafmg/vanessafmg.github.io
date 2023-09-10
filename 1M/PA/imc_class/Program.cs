using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imc_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o peso: ");
            double peso = double.Parse(Console.ReadLine());
            Console.Write("Informe a altura: ");
            double altura = double.Parse(Console.ReadLine());

            double imc = peso / (altura * altura);

            if (imc < 22)             
                Console.WriteLine("O IMC é: " + imc.ToString("F2") + "\nClassificação: Magreza");            
            else if (imc > 27)
                Console.WriteLine("O IMC é: " + imc.ToString("F2") + "\nClassificação: Excesso de peso");
            else
                Console.WriteLine("O IMC é: " + imc.ToString("F2") + "\nClassificação: Eutofria (peso adequado)");

            Console.ReadKey();
        }
    }
}
