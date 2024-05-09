using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Encapsulamento;
//usa as classes do projeto "encapsulamento"
namespace ConsoleApp1.OrientacaoObj
{
    public class FilhoNaoReconhecido : SubCelebridade {
        public new void MeusAcessos() {
            Console.WriteLine(InfoPublica);
            Console.WriteLine(InfoHeranca);
            //Console.WriteLine(InfoProjeto);
            Console.WriteLine(InfoProjHer);
            //Console.WriteLine(InfoClassHerproj);
            //Console.WriteLine(privado);

        }
    }

    public class AmigoDistante {
        public readonly SubCelebridade amiga = new SubCelebridade();

        public void MeusAcessos(){
            Console.Writeline(amiga.InfoPublica);
            //Console.WriteLine(InfoHeranca);
            //Console.WriteLine(InfoProjeto);
            //Console.WriteLine(InfoProjHer);
            //Console.WriteLine(InfoClassHerproj);
            //Console.WriteLine(privado);
        }
    }

    public class Encapsulamento
    {
        public void Executar() {
            SubCelebridade sub = subCelebridade();
            sub.MeusAcessos();

            new FilhoReconhecido().MeusAcessos();
            new AmigoProximo().MeusAcessos();

            new FilhoNaoReconhecido().MeusAcessos();
            new AmigoDistante().MeusAcessos();
        }
    }
}
