using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Estruturas_de_controle
{
    internal class UsandoBreak
    {
        public static void Executar()
        {
            int[] numeros = { 1, 3, 5, 7, 9, 11 };
            int numeroProcurado = 7;

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == numeroProcurado)
                {
                    Console.WriteLine($"Número encontrado na posição: {i}");
                    break; // Sai do loop porque o número foi encontrado
                }
            }
        }
    }
}
