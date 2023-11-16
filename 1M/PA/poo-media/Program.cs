using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace poo_media
{
    internal class Program
    {
        static void Main(string[] args) //void só retorna valores
        {
           Media m = new Media();
            m.inserirNota();
            m.calcularMedia();
            m.exibirSituacao();

            Console.ReadKey();
        }
    }
}
