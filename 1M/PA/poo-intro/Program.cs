using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo_intro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();
            p.cadastrarPessoa();
            p.exibirPessoa();

            Console.ReadKey();
        }
    }
}
