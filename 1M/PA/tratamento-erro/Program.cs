using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tratamento_erro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Digite o primeiro número: ");
                int n1 = int.Parse(Console.ReadLine());

                Console.Write("Digite o segundo número: ");
                int n2 = int.Parse(Console.ReadLine());

                double resultado = n1 / n2;

                Console.WriteLine("O resultado da divisão é: " + resultado);
            }
            catch (FormatException)
            {
                Console.WriteLine("Valor digitado inválido");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Não existe divisão por zero");
            }

            catch (Exception erro)
            { 
                Console.WriteLine(erro.Message);
            }

            finally
            {
                Console.WriteLine("Final da execução");
            }

            Console.ReadKey();


        }
    }
}
