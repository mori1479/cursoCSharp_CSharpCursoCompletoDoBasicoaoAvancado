using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ClasseEMetodo
{
    public class CarroOpcional {
        double desconto = 0.1;

        string nome;
        public string Nome {
            get {
                return "Opcional: " + nome;
            }set { nome = value; }
        }

        public double Preco { get; set; }

        public double PrecoComDesconto {
            get => Preco - (desconto * Preco); //lambda
        }

        public CarroOpcional() { }

        public CarroOpcional(string nome, double preco) { 
            Nome = nome;
            Preco = preco;
        }
    }
    class Props
    {
        public static void Executar() {
            var op1 = new CarroOpcional("Ar Condicionado", 3499.99);
            Console.WriteLine(op1.PrecoComDesconto);

            //op1.PrecoComDesconto = 3000;

            var op2 = new CarroOpcional();
            op2.Nome = "Direcao eletrica";
            op2.Preco = 2349.9;

            Console.WriteLine(op1.Nome);
            Console.WriteLine(op1.Preco);

            Console.WriteLine(op2.Nome);
            Console.WriteLine(op2.Preco);
            Console.WriteLine(op2.PrecoComDesconto);

        }
    }
}
