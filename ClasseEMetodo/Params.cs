using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ClasseEMetodo
{
    class Params
    {
        public static void Recepcionar(params string[] pessoas) {
            foreach (var pessoa in pessoas) {
                Console.WriteLine("Ola {0}", pessoa);
            }
        }

        public static void Executar() { 
            Recepcionar("Pedro", "Manu", "Roger");
        }
    }
}
