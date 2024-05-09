﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ClasseEMetodo
{
    class ParametroPadrao
    {
        public static int Somar(int a = 1, int b =1) {
            return a + b;
        }

        public static void Executar() {
            Console.WriteLine(Somar(10, 23));
            Console.WriteLine(Somar(50));
            Console.WriteLine(Somar(b: 7));
            Console.WriteLine(Somar());
        }
    }
}
