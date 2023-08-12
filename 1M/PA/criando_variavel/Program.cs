using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace criando_variavel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String nome; //cria uma variável do tipo texto (todas as variáveis do mesmo tipo podem ser criadas juntas)

            Console.WriteLine("Digite o seu nome:"); //informa a ação ao usuário
            nome = Console.ReadLine(); //abre o cursor para o usuário e armazena a variável

            Console.WriteLine("Digite o seu curso:");
            String curso = Console.ReadLine(); //cria a variável e mostra o cursor na mesma linha

            Console.WriteLine("Digite a sua cidade:");
            String cidade = Console.ReadLine();

            Console.WriteLine("O nome digitado foi: " + nome); //concatena a variável nome com o texto e mostra ao usuário

            Console.WriteLine("O curso digitado foi: " + curso +
                "\nA cidade digitada foi: " + cidade); //concatena duas variáveis \n quebra a linha

            Console.ReadKey();
        }
    }
}
