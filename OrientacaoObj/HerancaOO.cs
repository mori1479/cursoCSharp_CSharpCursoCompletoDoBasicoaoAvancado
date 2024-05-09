using ConsoleApp1.ClasseEMetodo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.OrientacaoObj
{
    public class Carro{
        protected readonly int VelocidadeMaxima;
        int VelocidadeAtual;

        public Carro(int velociadeMaxima){
            VelocidadeMaxima = velociadeMaxima;
        }

        protected int AlterarVelocidade(int delta)
        {
            int novaVelocidade = VelocidadeAtual + delta;

            if (novaVelocidade < 0)
            {
                VelocidadeAtual = 0;
            }
            else if (novaVelocidade > VelocidadeMaxima)
            {
                VelocidadeAtual = VelocidadeMaxima;
            }
            else
            {
                VelocidadeAtual = novaVelocidade;
            }
            return VelocidadeAtual;
        }

        public virtual int Acelerar() {
            return AlterarVelocidade(5);//utilizado o metodo que altera a velocidade
        }
        public int Freiar(){
            return AlterarVelocidade(-5);
        }
        //public Carro() { }      - construtor padrao
    }
    //de incio vai dar errado pois nao tem a classe de contrtutor padrao
    public class Uno : Carro { //criado a classe uno como herderira de carro
        public Uno() : base(200){ // precisa criar este contrutor dentro para chamar o padrao(de base)
        
        }
    }

    public class Ferrari : Carro
    { //Como uma ferrari acelara mais que um uno, vamos sobreescrever o metodo acelerar
        public Ferrari() : base(350){ }
        //utilizado o override para dar enfase de que o metodo estra sendo sobreescrito
        public override int Acelerar(){// em primeiro momento nao da, pois precisa alterar o metodo acelerar para virtual
            return AlterarVelocidade(15);
        }
        //Oculta o metodo da classe pai "public NEW int"
         public new int Frear() {
            return AlterarVelocidade(-15);
        }
    }
    internal class HerancaOO
    {
       
        public static void Executar(){
            Console.WriteLine("Uno...");
            Uno carro1 = new Uno();
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Freiar());
            Console.WriteLine(carro1.Freiar());
            
            Console.WriteLine(carro1.Freiar());//se freiar quando parado, ele nao diminui, foi tratado

            Console.WriteLine("Ferrari com tipo carro...");
            Carro carro2 = new Ferrari();
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Freiar());
            Console.WriteLine(carro2.Freiar());
            Console.WriteLine(carro2.Freiar());

            Console.WriteLine("Uno com tipo carro...");
            carro2 = new Uno();//Polimorfismo
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Freiar());
            Console.WriteLine(carro2.Freiar());
            Console.WriteLine(carro2.Freiar());
        }
    }
}
