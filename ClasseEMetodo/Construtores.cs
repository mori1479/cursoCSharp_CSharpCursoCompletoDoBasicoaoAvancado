using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ClasseEMetodo
{
    class Carro {// criado outra classe "Carro".
        public string Modelo;
        public string Fabricante;
        public int Ano;

        public Carro(string Modelo, string Fabricante, int Ano) { 
            this.Modelo = Modelo;
            this.Fabricante = Fabricante;
            this.Ano = Ano;
            //O this.modelo (pertence ao objeto) se refere ao modelo la em cima, ja o sem o this na frente, ao do construtor
            //Tambem pode usar as var com a primeira letra em minusculo para diferenciar
        }
        public Carro() { } // outro construtor, para poder fazer de outros jeitos, como no carro 1 e 3
    }

    class Construtores
    {
        public static void Executar()
        {
            //Para iniciar uma var de carro sem construtor
            var carro1 = new Carro();
            carro1.Fabricante = "BMW";
            carro1.Modelo = "325i";
            carro1.Ano = 2024;
            Console.WriteLine($"{carro1.Modelo} {carro1.Fabricante} {carro1.Ano}");
            var carro2 = new Carro("KA", "Ford", 2024);
            Console.WriteLine($"{carro2.Modelo} {carro2.Fabricante} {carro2.Ano}");

            //outro jeito de fazer o construtor. atencao para o final do "}" que tem ponto e virgula dps
            var carro3 = new Carro(){
                Fabricante = "Fiat",
                Modelo = "Uno",
                Ano = 2014

            };

            Console.WriteLine($"{carro3.Modelo} {carro3.Fabricante} {carro3.Ano}");//para imprimir, sempre fora do contrutor

        }
    }
}
