using System;
//using System.Collections.Generic; tirado o .generic do final para usar stack
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//O PRIMEIRO A ENTRAR EH O ULTIMO A SAIR(CONTRARIO DA FILA)
namespace ConsoleApp1.Colecoes
{
    class StackExemplo
    {
        public static void Exectar(){
            var pilha = new Stack();

            pilha.Push(3);
            pilha.Push("a");
            pilha.Push(true);
            pilha.Push(3.14f);

            foreach(var item in pilha){
                Console.WriteLine($"{item} ");
            }

            Console.WriteLine($"\nPop: {pilha.Pop()}");

            foreach (var item in pilha) {
                Console.WriteLine($"\nPeek: {pilha.Peek()}");
                Console.WriteLine(pilha.Count);
            }
        }
    }
}
