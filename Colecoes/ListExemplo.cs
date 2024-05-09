using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Colecoes
{
    class ListExemplo
    {
        public class Produto {
            public string Nome;
            public double Preco;

            public Produto(string nome, double preco){
                Nome = nome;
                Preco = preco;
            }

            public override bool Equals(object obj){
                Produto outroProduto = (Produto)obj;
                bool mesmoNome = Nome == outroProduto.Nome;
                bool mesmoPreco = Preco == outroProduto.Preco;
                return mesmoNome && mesmoPreco;
            }
        }
        public static void Executar() {
            var livro = new Produto("Senhor dos aneis", 10);

            var carrinho = new List<Produto>();
            carrinho.Add(livro);

            var combo = new List<Produto> {
                new Produto("Camisa", 29.9),
                new Produto("Shorts", 10),
                new Produto("Casaco", 99.9)
            };

            carrinho.AddRange(combo); // Adiciona as coisas do carrinho a lista combo
            Console.WriteLine(carrinho.Count);
            carrinho.RemoveAt(3); //Remove o elemente de indice 3

            foreach (var item in carrinho){
                Console.WriteLine(carrinho.IndexOf(item));
                Console.WriteLine($" {item.Nome} {item.Preco}");
            }

            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro);
            Console.WriteLine(carrinho.Count);
            //Adiciona e conta logo em seguida
            Console.WriteLine(carrinho.LastIndexOf(livro));
        }
    }
}
