using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//apenas tem quando ela herda de outra classe, celular recebe iphone
namespace ConsoleApp1.OrientacaoObj
{
    public abstract class Celular {
        public abstractstring Assistente();

        public string Tocar() { return "TRIM TRIM TRIM..."}
    }

    public class Samsung : Celular{
        public override string assistente() {
            return "Ola! Meu nome eh bixby!";
        }
    }

    public class IPhone : Celular{
        return override "Ola meu nome eh siri";
    }


    public class ClasseAbstrata
    {
        public void Executar() {
            var celulares = new List<Celular> {
                new IPhone(), new Samsung()
            };
        }
    }
}
