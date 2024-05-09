using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ClasseEMetodo
{
    public class Produto {
        public string Nome;
        public double Preco;
        public double Desconto = 0.1;
        //public static double Desconto = 0.1; faria com que todos produtos tivessem o mesmo desconto, tirado do contrutor e inserido na linha 40

        public Produto(string nome, double preco, double desconto) {
            Nome = nome;
            Preco = preco;
            Desconto = desconto;
            //Nao precisa da palavra "this." na frente pois usa no contrutor o nome com letra minuscula
        }

        public Produto() { }
        //para criar o produto2
        public double CalcularDesconto() { 
            return Preco - Preco * Desconto; 
        }
    }

    class AtribustosEstaticos
    {
        public static void Executar() { 
            var produto1 = new Produto("Caderno", 3.2, 0.1);
            var produto2 = new Produto()
            {
                Nome = "Borracha",
                Preco = 5.3,
                Desconto = 0.1
            };

            //Produto.Desconto = 0.5 (linha 13)
            Console.WriteLine("Preco com desconto: {0}",
                produto1.CalcularDesconto());
            Console.WriteLine("Preco com desconto: {0}",
                produto2.CalcularDesconto());
        }
    }
}
