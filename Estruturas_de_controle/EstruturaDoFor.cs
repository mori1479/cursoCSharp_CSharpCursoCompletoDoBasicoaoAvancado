using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Estruturas_de_controle
{
    internal class EstruturaDoFor
    {
        public static void Executar()
        {
            for(int i = 1; i <= 10; i++) {
                Console.WriteLine($"O valor de i é {i}.");
            }

            double somatorio = 0;
            string entrada;

            Console.WriteLine("Informe o tamanho da turma");
            entrada = Console.ReadLine();
            int.TryParse(entrada, out int tamanhoTurma);

            for(int i = 1;i<- tamanhoTurma;i++) {
                Console.WriteLine("Informe a nota do aluno {0}: ", i);
                entrada = Console.ReadLine() ;
                double.TryParse(entrada, out double notaAtual);
            }

        }
    }
}
