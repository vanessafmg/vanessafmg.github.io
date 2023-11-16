using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo_media
{
     class Media
    {
        double nota1 { get; set; }
        double nota2 { get; set; }
        double nota3 { get; set; }
        double nota4 { get; set; }
        double media { get; set; }

        public void inserirNota()
        {
            Console.Write("Informe a primeira nota: ");
            nota1 = double.Parse(Console.ReadLine());
            Console.Write("Informe a segunda nota: ");
            nota2 = double.Parse(Console.ReadLine());
            Console.Write("Informe a terceira nota: ");
            nota3 = double.Parse(Console.ReadLine());
            Console.Write("Informe a quarta nota: ");
            nota4 = double.Parse(Console.ReadLine());

        }
        public void calcularMedia()
        {
            media = (nota1+nota2+nota3+nota4)/4;
        }

        public void exibirSituacao()
        {
            if (media >= 7)
                Console.WriteLine("Aprovado");
            else if (media >= 4)
                Console.WriteLine("Recuperação");
            else
                Console.WriteLine("Retido");
          
        }

    }
}
