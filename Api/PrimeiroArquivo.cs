using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Api
{
    public static class ExtensaoString
    {
        public static string ParseHome(this string path) {
            string home = (Environment.OSVersion.PlatformID.MaxOSX)
                ? Environment.GetEnviromentVariable("HOME")
                : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%HOMEPATH%");
            return path.Replace("~", home);

        }
    }
    internal class PrimeiroArquivo
    {
        public static void Executar() {
            //var s = @"\tste\nestes\a.txt"; //O @ faz com que nao considere o \t como tab e o \n como quebra de linha

            var path = @"~/primeiro_arquivo.txt";

            if (!File.Exists(path)) { 
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Esse e");
                    sw.WriteLine("O nosso");
                    sw.WriteLine("primeiro");
                    sw.WriteLine("arquivo");
                }
            }
            //alterar um arquivo, assim adiciona o texto no final do texto do arquivo ja existente
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("");
                sw.WriteLine("E possivel");
                sw.WriteLine("Adicionar");
                sw.WriteLine("Mais texto");
            }
        }
    }
}
