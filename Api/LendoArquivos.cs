using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Api
{
    internal class LendoArquivos
    {
        public static void Executar() {
            var path = @"~/lendo_arquivos.txt".ParseHome();

            using(int a =3) { }
            if (!File.Exists(path)){
                using (StreamWriter sw = File.AppendText(path)){
                    sw.WriteLine("Produto; Preco; Qtd");
                    sw.WriteLine("Caneta;  3.59;  89");
                    sw.WriteLine("Borracha; 2.89; 27");
                }
            }
            //aqui eu leio o arquivo
            try{
                using (StreamReader sr = new StreamReader(path)){
                    var texto = sr.ReadToEnd();
                    Console.WriteLine(texto);
                }
            } catch(Exception ex) { console.WriteLine(ex.Message); }
            
        }
    }
}
