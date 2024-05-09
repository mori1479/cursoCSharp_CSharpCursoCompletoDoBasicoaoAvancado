using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Api
{
    internal class ExDirectoryInfo
    {
        public static void Executar() {
            var dirProjeto = @"~/source/repos/CursoCSharp/CursoCSharp".ParseHome();

            var dirInfo = new ExDirectoryInfo(dirProjeto);

            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }

            Console.WriteLine("== Arquivos ============");
            var arquivos = dirInfo.GetFiles();
            foreach(var arquivo in arquivos) {
                Console.WriteLine(arquivo); 
            }

            Console.WriteLine("\n== Diretorios ============");
            var pastas = dirInfo.GetFiles();
            foreach (var pasta in pastas){
                Console.WriteLine(pasta);
            }

            Console.WriteLine(dirInfo.CreationTime);
            Console.WriteLine(dirInfo.FullName);
            Console.WriteLine(dirInfo.Root);
            Console.WriteLine(dirInfo.Parent.Parent);
        }
    }
}
