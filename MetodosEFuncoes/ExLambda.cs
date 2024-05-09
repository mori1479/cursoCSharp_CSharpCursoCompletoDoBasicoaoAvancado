using ConsoleApp1.ClasseEMetodo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.MetodosEFuncoes
{
    internal class ExLambda
    {
        public static void Executar(){
            Action algoNoConsole = () => {
                Console.WriteLine("Lambda com C#!");
            };

            algoNoConsole();

            Func<int> jogarDado = () => {
                Random random = new Random();
                return random.Next(1, 7);
            };

            Console.WriteLine(jogarDado());

            Func<int, string> conversorHex = numero => numero.ToString("x");
            Console.WriteLine(conversorHex(1234));

            MetodosEFuncoes<int, int, int, string> formatarData = (dia, mes, ano) =>
                string.Format("{0:D2}/{1:D2}/{2:D2}", dia, mes, ano);
            Console.WriteLine(formatarData(1, 1, 2019));
        }
    }
}
