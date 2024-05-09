using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class InterpolcaoStrings
    {
        static void Executar(string[] args)
        {
            String nome = "Joao";
            String atividade = "o basquete";

            Console.WriteLine("O " + nome + " vai para " + atividade + " hoje?");
            //igual a
            Console.WriteLine("O {0} vai para {1} hoje?", nome, atividade);

        }
    }
}
