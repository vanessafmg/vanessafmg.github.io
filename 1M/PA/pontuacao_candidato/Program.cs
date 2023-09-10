using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pontuacao_candidato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o nome do candidato: ");
            String nome = Console.ReadLine();
            Console.Write("Informe a pontuação do candidato: ");
            double pontos = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a situação do candidato\nP - Escolaridade Pública 15% \nA - Afrodescendência 10%" +
                " \nD - Deficiente 5% \nN - Não se enquadra nas situações");
            String situacao = Console.ReadLine().ToUpper();

            if (situacao == "P")
                Console.WriteLine("Nome do candidato: " + nome + "\nPontuação Final do Candidato: " + (pontos + (pontos * (15.0 / 100.0))));
            else if (situacao == "A")
                Console.WriteLine("Nome do candidato: " + nome + "\nPontuação Final do Candidato: " + (pontos + (pontos * .1)));
            else if (situacao == "D")
                Console.WriteLine("Nome do candidato: " + nome + "\nPontuação Final do Candidato: " + (pontos + (pontos * .05)));
            else if (situacao == "N")
                Console.WriteLine("Nome do candidato: " + nome + "\nPontuação Final do Candidato: " + pontos);
            else
                Console.WriteLine("Escolha uma opção válida.");

            Console.ReadKey(); 

        }
    }
}
