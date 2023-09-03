using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ident_genero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o sexo do usuário");
            String sexo = Console.ReadLine().ToUpper();

            if (sexo == "M")
                Console.WriteLine("O usuário é do sexo masculino");
            else if (sexo == "F")
                Console.WriteLine("O usuário é do sexo feminino");
            else
                Console.WriteLine("Opção inválida");

            Console.ReadKey();
        }
    }
}
