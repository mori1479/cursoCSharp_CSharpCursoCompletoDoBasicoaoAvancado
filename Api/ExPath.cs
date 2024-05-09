using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Api
{
    internal class ExPath
    {
        public static void Executar() {
            var arquivo = @"~/exemplo_path_arquivo.txt".ParseHome();
            var pasta = @"~/exemplo_path_pasta".ParseHome();

            if(!File.Exists(arquivo)){
                using(StreamWriter sw = File.Create(arquivo)){
                    sw.WriteLine("Um novo arquivo criado!");
                }
            }

            if (!Directory.Exists(pasta)) { 
                Directory.CreateDirectory(pasta);
            }

            Console.WriteLine(Path.GetExtension(arquivo));
            Console.WriteLine(Path.GetFileName(arquivo));
            Console.WriteLine(Path.GetFileNameWithoutExtension(arquivo));
            Console.WriteLine(Path.GetDirectoryName(arquivo));
            Console.WriteLine(Path.HasExtention(arquivo));

            Console.WriteLine(Path.HasExtension(pasta));
            Console.WriteLine(Path.GetFullPath(pasta));
            Console.WriteLine(Path.GetPathRoot(pasta));
        }
    }
}
