using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Colecoes
{
    class ArrayExemplo
    {
        public static void Executar() {
            string[] alunos = new string[5];
            alunos[0] = "Anderson";
            alunos[1] = "Cleiton";
            alunos[2] = "Bia";
            alunos[3] = "Jose";
            alunos[4] = "Alek";

            foreach (var aluno in alunos) {
                Console.WriteLine(aluno);
            }

            double somatorio = 0;
            double[] notas = { 9.7, 4.8, 8.4, 8.2, 6.8 };

            foreach (var nota in notas) {
                somatorio += nota;
            }

            //for (int i = 0; i < notas.Length; i++)
            //{
            //    somatorio += notas[i];
            //}

            double media = somatorio / notas.Length;
            Console.WriteLine(media);

            char[] letras = { 'A', 'R', 'F' };
            string palavra = new string(letras);
            Console.WriteLine(palavra);
        }
    }
}
