using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//valor imutavel, somenta para leitura
namespace ConsoleApp1.ClasseEMetodo
{
    public class cliente {
        public string Nome;
        public readonly DateTime Nascimento; //para usar "const DateTime Nascimento;" precisa dar um valor, no caso, basta declarar igual a zero

        public cliente(string nome, DateTime nascimento) { 
            Nome = nome;
            Nascimento = nascimento;
        }

        public string GetDataDeNascimento() {
            return String.Format("{0}/{1}/{2}", 
                   Nascimento.Day, Nascimento.Month, Nascimento.Year);
        }
    }
    class ReadOnly
    {
        static public void Executar() {
            var novoCliente = new cliente("Ana Silva", 
                new DateTime(1987, 5, 22));

            Console.WriteLine(novoCliente.Nome);
            Console.WriteLine(novoCliente.GetDataDeNascimento());
         }
    }
}
