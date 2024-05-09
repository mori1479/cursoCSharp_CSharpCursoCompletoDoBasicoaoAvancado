using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ClasseEMetodo
{
    public class CalculadoraEstatica
    {
        public static int Multiplicar(int a, int b)
        {
            return a * b;
        }

        public int Somar(int a, int b)
        {
            return a + b;
        }
    }

    class MetodosEstaticos
    {
        public static void Executar() {
            var resultado = CalculadoraEstatica.Multiplicar(3, 2);
            Console.WriteLine("Resultado: {0}", resultado);

            CalculadoraEstatica calc = new CalculadoraEstatica();
            Console.WriteLine(calc.Somar(3, 2));
            Console.WriteLine(CalculadoraEstatica.Multiplicar(2,2));
        }
        //Se nao tem a palavra static, so e acessivel a partir da instancia e quando o metodo tem, se torna acessivel a partir da classe
        
        
    }
}
