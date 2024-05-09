using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.TopicosAvancados
{
    internal class Nullables1
    {
        static int numero3;
        public static void Executar() { 
            Nullable<int> num1 = null;
            int? num2 = null;
            //int num3 = null; Nao da pra usar nullable para int

            Console.WriteLine(numero3);

            if (num1.HasValue){
                Console.WriteLine("Valor de num: {0}", num1 );
            } else{
                Console.WriteLine("A variavel nao possui valor.");
            }

            int valor = num1 ?? 1000; //n'ao tiver valor pega o valor padrao (1000)

            bool? booleana = null;
            bool resultado = booleana.GetValueOrDefault();
            Console.WriteLine(resultado);

            try{
                int x = num1.Value;
                int y = num2.Value;
                Console.WriteLine(x + y);
            }catch(Exception ex) { 
                Console.WriteLine(ex.Message);
            }
        }
    }
}
