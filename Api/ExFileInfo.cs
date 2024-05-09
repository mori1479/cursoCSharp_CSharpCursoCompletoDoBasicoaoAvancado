using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Api
{
    internal class ExFileInfo
    {
        public static void ExcluirSeExistir(params string[] caminhos) { 
            foreach(var caminho in caminhos){
                FileInfo arquivo = new FileInfo(caminho);

                if (arquivo.Exists) { arquivo.Delete(); }
            }
        }
        public static void Executar() {
            var caminhoOrigem = @"~/arq_origem.txt".ParserHome();
            var caminhoDestino = @"~/arq_destino.txt".ParserHome();
            var caminhoCopia = @"~/arq_copia.txt".ParserHome();

            ExcluirSeExistir(caminhoOrigem, caminhoDestino, caminhoCopia);

            using (StreamWriter sw = File.CreateText(caminhoOrigem)){
                sw.WriteLine("Arquivo original!");
            }

            FileInfo origem = new FileInfo(caminhoDestino);
            Console.WriteLine(origem.Name);
            Console.WriteLine(origem.IsReadOnly);
            Console.WriteLine(origem.FullName);
            Console.WriteLine(origem.Extension);
            Console.WriteLine(origem.DirectoryName);

            origem.CopyTo(caminhoCopia);
            origem.MoveTo(caminhoDestino);
        }
    }
}
