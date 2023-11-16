using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraylist_assalariado_comissionado_horista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList listaA = new ArrayList();
            ArrayList listaC = new ArrayList();
            ArrayList listaH = new ArrayList();



            String resp;

            do
            {
                Console.Clear();
                Console.Write("Você deseja cadastrar um Assariado (A), um Comissionado (C), ou um Horista (H)? ");
                String escolha = Console.ReadLine().ToUpper();

                switch (escolha)
                {
                    case "A":
                        Assalariado a = new Assalariado();
                        a.cadastrar();
                        listaA.Add(a);
                        break;

                    case "C":
                        Comissionado c = new Comissionado();
                        c.cadastrar();
                        listaC.Add(c);
                        break;

                    case "H":
                        Horista h = new Horista();
                        h.cadastrar();
                        listaH.Add(h);
                        break;

                    default:
                        Console.WriteLine("Digite uma opção válida");                        
                        break;
                }

                Console.WriteLine("Deseja realizar outro cadastro? (S/N) ");
                resp = Console.ReadLine().ToUpper();
                 
            }
            while (resp == "S");

            foreach (Horista h in listaH)
            {
                h.exibir();
            }

            foreach (Comissionado c in listaC)
            {
                c.exibir();
            }

            foreach (Assalariado a in listaA)
            {
                a.exibir();
            }

            Console.ReadKey();
        }
    }
}
