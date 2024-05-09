using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Fundamentos
{
    internal class CasaDescimal
    {
        public static void Executar()
        {
            double valor = 15.175;
            Console.WriteLine("Arendondando inteiro, uma casa e duas decimais");
            Console.WriteLine(valor.ToString("F0"));
            Console.WriteLine(valor.ToString("F1"));
            Console.WriteLine(valor.ToString("F2"));
            Console.WriteLine("Moeda");
            Console.WriteLine(valor.ToString("C"));
            Console.WriteLine("Percentual");
            Console.WriteLine(valor.ToString("P"));
            Console.WriteLine("Utilizando cerquilha");
            Console.WriteLine(valor.ToString("#.#"));
        }
    }
}
