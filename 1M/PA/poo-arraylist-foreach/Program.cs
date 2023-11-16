using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo_arraylist_foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList lista = new ArrayList();

            String resp;
            do
            {
                Console.Clear();
                Pessoa p = new Pessoa();
                p.cadastrarPessoa();
                lista.Add(p);
                Console.Write("Deseja cadastrar outra pessoa? ");
                resp = Console.ReadLine().ToUpper();

            }
            while (resp == "S");

            foreach (Pessoa p in lista)
            {
                p.exibirPessoa();
            }

            Console.ReadKey();
        }
    }
}
