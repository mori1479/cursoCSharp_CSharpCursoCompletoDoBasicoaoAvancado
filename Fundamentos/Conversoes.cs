using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Fundamentos
{
    internal class Conversoes
    {
        public static void Executar() {
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(quebrado);
            //Neste caso ele consegue converter

            double nota = 9.7;
            // int notaTruncada = nota; //Nao consegue converter de maneira automatica
            int notaTruncada = (int) nota;
            Console.WriteLine("Nota truncada: {0}", notaTruncada);

            Console.WriteLine("Digite o segundo numero: ");
            int.TryParse(Console.ReadLine(), out int numero);
            Console.WriteLine("Resultado : {0}", numero);

        }
    }
}
