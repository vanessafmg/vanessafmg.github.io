using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_geometricas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o número correspondente a forma geométrica escolhida:\n1: Quadrado\n2: Retângulo\n3: Losango\n4: Trapézio");
            int forma = int.Parse(Console.ReadLine());

            switch (forma)
            {
                case 1:
                    Console.Write("Informe a medida do lado do quadrado: ");
                    double lado = double.Parse(Console.ReadLine());
                    double area = lado * lado;
                    Console.WriteLine("A área do quadrado é: " + area);
                    break;
                case 2:
                    Console.Write("Informe a medida da base do retângulo: ");
                    double base_ = double.Parse(Console.ReadLine());
                    Console.Write("Informe a medida da altura do retângulo: ");
                    double altura = double.Parse(Console.ReadLine());
                    area = base_ * altura;
                    Console.WriteLine("A área do retângulo é: " + area);
                    break;

                case 3:
                    Console.Write("Informe a diagonal maior do losango: ");
                    double D = double.Parse(Console.ReadLine());
                    Console.Write("Informe a diagonal menor do losango: ");
                    double d = double.Parse(Console.ReadLine());
                    area = (D * d) / 2;
                    Console.WriteLine("A área do losango é: " + area);
                    break;

                case 4:
                    Console.Write("Informe a primeira base do trapézio: ");
                    double base1 = double.Parse(Console.ReadLine());
                    Console.Write("Informe a segunda base do trapézio: ");
                    double base2 = double.Parse(Console.ReadLine());
                    Console.Write("Informe a altura do trapézio: ");
                    altura = double.Parse(Console.ReadLine());
                    area = ((base1 + base2) * altura) / 2;
                    Console.WriteLine("A área do trapézio é: " + area);
                    break;

                default:
                    Console.Write("Informe uma opção válida.");
                    break;
            }

                Console.ReadKey();
        }  
    }
}
