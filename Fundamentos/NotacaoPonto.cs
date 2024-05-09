using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Fundamentos
{
    internal class NotacaoPonto
    {
        public static void Executar() 
        {
            var saudacao = "Ola".ToUpper().Insert(3, " World!");
            Console.WriteLine(saudacao);
            saudacao = "Ola".ToUpper().Insert(3, " World!").Replace("World!", "Mundo!");
            Console.WriteLine(saudacao);

            //tambem tem em vars
            Console.WriteLine("TESTE".Length);
            //podendo pegar tambem de uma var string
            String testeLenth = "123456789";
            Console.WriteLine(testeLenth.Length);
            //para caso nao importe se esta null
            String stringNul = null;
            Console.WriteLine(stringNul?.Length); 
            //tambem pode ser tratado com exception ou um if
        }
    }
}
