using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Colecoes
{
    class DictionaryExemplo {
        public static void Executar() {
            var filmes = new Dictionary<int, string>();

            filmes.Add(2000, "Gladiador");
            filmes.Add(2002, "Homem-aranha");
            filmes.Add(2004, "Os Incriveis");
            filmes.Add(2006, "O Grande Truque");

            if (filmes.ContainsKey(2004)){//seria um array q vc pega pela chave(ano)
                Console.WriteLine("2004: " + filmes[2004]);
                //Console.WriteLine("2004: " + filmes.TryGetValueOrDefault(2008)); Neste caso, ele insere o valor padrao, no caso, null.
            }

            Console.WriteLine(filmes.ContainsValue("Amnesia"));

            Console.WriteLine($"Removeu? {filmes.Remove(2004)}");

            filmes.TryGetValue(2006, out string filme2006);
            Console.WriteLine($"Filme, {filme2006}!");

            foreach (var chave in filmes.Keys) {
                Console.WriteLine(chave); //chave - ano
            }

            foreach(var valor in filmes.Values){ 
                Console.WriteLine(valor);//valor - nome filme
            }

            foreach (KeyValuePair<int, string> filme in filmes) {//executa a chave e valor ao mesmo tempo
                Console.WriteLine($"{filme.Value} e de {filme.Key}.");
            }

            foreach (var filme in filmes){
                Console.WriteLine($"{filme.Value} e de {filme.Key}.");
            }
        }
    }
}
