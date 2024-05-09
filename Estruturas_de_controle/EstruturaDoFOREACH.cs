using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Estruturas_de_controle
{
    internal class EstruturaDoFOREACH
    {
        public static void Executar()
        {
            var palavra = "Opa!";

            foreach (var letra in palavra) { 
                Console.WriteLine(letra);
            }

            var alunos = new string[] { "Ana", "Bia", "Carlos" };

            foreach (var letra in alunos)
            {
                Console.WriteLine(alunos);
            }
        }
    }
}
