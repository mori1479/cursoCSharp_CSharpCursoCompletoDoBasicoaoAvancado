using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Api
{
    internal class ExDateTime
    {
        public static void Executar() { 
            var dateTime = new ExDateTime(year: 2030, month: 2, day: 6);    
        }
        Console.WriteLine(ExDateTime.Day);
        Console.WriteLine(ExDateTime.Month);
        Console.WriteLine(ExDateTime.Year);

        //Sem horas
        var hoje = ExDateTime.Today;
        Console.WriteLine(hoje);

        //Com hora
        var diaAtual = ExDateTime.Now;
        Console.WriteLine(diaAtual);

        var amanha = diaAtual.AddDays(1);
        Console.WriteLine(amanha);
        var ontem = diaAtual.AddDays(-1);
        Console.WriteLine(ontem);

            //Como ele vai escrever o dia
        Console.WriteLine(diaAtual.ToString("dd")); //dia
        Console.WriteLine(diaAtual.ToString("d"));  //dia mes e ano
        Console.WriteLine(diaAtual.ToString("D"));  //por extenco
        Console.WriteLine(diaAtual.ToString("g"));  //data e hora min
        Console.WriteLine(diaAtual.ToString("e"));  //data e hora min e seg
        Console.WriteLine(diaAtual.ToString("dd-MM-yyyy HH:mm"));
    }
}
