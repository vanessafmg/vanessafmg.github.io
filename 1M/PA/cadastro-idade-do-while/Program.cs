using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace cadastro_idade_do_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cont_crianca = 0;
            int cont_adolecente = 0;
            int cont_jovem = 0;
            int cont_adulto = 0;
            int cont_idoso = 0;
            String resp;

            do
            {
                Console.Write("Informe o nome do paciente: ");
                string paciente = Console.ReadLine();
                Console.Write("Informe a idade a idade do paciente: ");
                int idade = int.Parse(Console.ReadLine());
                if (idade <= 12)
                    cont_crianca++;
                else if (idade <= 18)
                    cont_adolecente++;
                else if (idade <= 29)
                    cont_jovem++;
                else if (idade <= 59)
                    cont_adulto++;
                else
                    cont_idoso++;
                Console.WriteLine("Deseja cadastrar outro paciente? ");
                resp = Console.ReadLine().ToUpper();
            }
            while (resp == "S");
            Console.WriteLine("Crianças: " + cont_crianca);
            Console.WriteLine("Adolescentes: " + cont_adolecente);
            Console.WriteLine("Jovens: " + cont_jovem);
            Console.WriteLine("Adultos: " + cont_adulto);
            Console.WriteLine("Idosos: " + cont_idoso);
            Console.ReadKey();


        }
    }
}
