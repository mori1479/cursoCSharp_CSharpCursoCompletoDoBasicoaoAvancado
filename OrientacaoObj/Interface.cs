using ConsoleApp1.OrientacaoObj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.OrientacaoObj
{
    interface Operacaobinaria {
        int Operacao(int a, int b)
        }
    }

    class Soma : Operacaobinaria {
        public int Operacao(int a, int b) {
            return a + b;
        }
    }

    class Subtracao : Operacaobinaria{
        public int Operacao(int a, int b) {
            return a - b;
        }
    }

    class Multiplicacao : Operacaobinaria
    {
        public int Operacao(int a, int b)
        {
            return a * b;
        }
    }

    class Calculadora {
        List<Operacaobinaria> operacoes = new List<Operacaobinaria> {
                new Soma(),
                new Subtracao(),
                new Multiplicacao(),
                new Divisao()
            };
        public string ExecutarOperacoes(int a, int b){
            string resultado += "";
            foreach(var op in operacoes){
                resultado += $"Usando {op.GetType().Name} = {op.Operacao(a, b)}\n;
            }
        }
    }
    class Divisao : Operacaobinaria
    {
        public int Operacao(int a, int b)
        {
            return a / b;
        }
    }

internal class Interface
    {
    public static void Executar() { 
        var calc = new Calculadora();
        var resultado = calc.ExecutarOperacoes(20, 5)
    }
    }
}
