using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Fundamentos
{
    internal class OperadoresTernarios
    {
        public static void Executar()
        {
            Console.WriteLine("Nota maior que 7");
            var nota = 7.0;
            String resultado = nota >= 7.0 ? "Aprovado" : "Reprovado";
            Console.WriteLine(resultado);
            Console.WriteLine("Nota menor que 7");
            nota = 6.0;
            resultado = nota >= 7.0 ? "Aprovado" : "Reprovado";
            Console.WriteLine(resultado);
        }
    }
}
