using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String resp;
            do
            {
            Console.WriteLine("Linha inserida");
            Console.Write("Deseja inserir uma nova linha? ");
            resp = Console.ReadLine().ToUpper();
            }
            while (resp == "S");
            Console.ReadKey();

            //String resp = "S";
            //while (resp == "S")
            //{
               // Console.WriteLine("Linha inserida");
               // Console.Write("Deseja inserir uma nova linha? ");
                //resp = Console.ReadLine().ToUpper();
            //}
            //Console.ReadKey(); 
        }
    }
}
