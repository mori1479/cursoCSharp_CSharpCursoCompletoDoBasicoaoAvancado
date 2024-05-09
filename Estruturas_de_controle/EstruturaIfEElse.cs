using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Estruturas_de_controle
{
    internal class EstruturaIfEElse
    {
        public static void Executar()
        {
            int idade = 16;
            if (idade >= 18)
            {
                Console.WriteLine("Voce e maior de idade");
            }
            else Console.WriteLine("Voce e menor de idade");
        }
    }
}
