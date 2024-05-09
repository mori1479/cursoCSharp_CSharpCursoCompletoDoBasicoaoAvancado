using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Colecoes
{
    class ArrayListExemplo
    {
        public static void Executar() {
            var arraylist = new ArrayList { 
                "Plavra",
                3,
                true
            };

            arraylist.Add(3.14);

            foreach (var item in arraylist)
            {
                Console.WriteLine("{0} => {1}", item, item.GetType()) ;
            }
        }
    }
}
