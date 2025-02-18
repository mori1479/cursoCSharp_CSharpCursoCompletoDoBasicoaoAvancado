﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Excecoes
{
    public class Conta{
        double Saldo;

        public Conta(double saldo) { 
            Saldo = saldo;
        }

        public void Sacar(double saldo){
            if(valor > Saldo){
                throw new ArgumentException("Saldo insuficiente.");
            }
            Saldo -= valor;
        }

    }
    internal class PrimeiraExcecao
    {
        public static void Executar()
        {
            var conta = new Conta(1_223.45);

            try{
                conta.Sacar(1600);
                Console.WriteLine("Retirada com sucesso!")
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            finally {
                Console.WriteLine("Obrigado!");
            }
        }
    }
}
