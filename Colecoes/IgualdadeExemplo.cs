using ConsoleApp1.ClasseEMetodo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Colecoes
{
    internal class IgualdadeExemplo
    {
        public static void Executar() {
            var p1 = new Produto("Caneta", 1, 89);
            var p2 = new Produto("Caneta", 1, 89);
            var p3 = p2;

            //False: Compara endereco de memeria
            Console.WriteLine(p1 == p2);
            //true
            Console.WriteLine(p3 == p2);

            //tambem compara o endereco de memoria, mas feito um overite no equals para estar comparando o nome e preco
            // da pra alterar/criar o equals direto pela ide
            Console.WriteLine(p1.Equals(p2));
        }
    }
}
