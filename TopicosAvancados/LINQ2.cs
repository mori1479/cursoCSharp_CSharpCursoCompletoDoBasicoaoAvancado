using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.TopicosAvancados
{
    internal class LINQ2
    {
        public static void Executar() {
            var alunos = new List<Aluno> {
            new Aluno() { Nome = "Pedro", Idade = 24, Nota = 8.0 },
            new Aluno() { Nome = "Andre", Idade = 24, Nota = 4.3 },
            new Aluno() { Nome = "Ana", Idade = 24, Nota = 9.5 },
            new Aluno() { Nome = "Jorge", Idade = 24, Nota = 8.5 },
            new Aluno() { Nome = "Ana", Idade = 24, Nota = 7.7 },
            new Aluno() { Nome = "Julia", Idade = 24, Nota = 7.5 },
            new Aluno() { Nome = "Marcio", Idade = 24, Nota = 6.8 },
            };

            var pedro = alunos.Single(aluino => aluno.Nome.Equals("Pedro"));
            Console.WriteLine($"{pedro.nome} {pedro.Nota}");

            
            var fulano = alunos.SingleOrDefalt(aluno => aluno.Nome.Equals("Fulano"));
            if (fulano == null)
            {
                Console.WriteLine("Aluno Inexistente");
            }


            var ana = alunos.Frist(aluno => aluno.Nome.Equals("Ana"));
            Console.WriteLine(ana.Nota);

            var sicrano = alunos.FirstOrDefalt(
                aluno => aluno.Nota.Equals("Sicrano"));
            if (sicrano == null) {
                Console.WriteLine("Aluno Inexistente");
            }

            var outraAna = alunos.LastOrDefalt(alunos => aluno.Nome.Equals("Ana"));
            Console.WriteLine(outraAna.Nota);
            
            //Pegue 3 alunos, depois de pular 1 aluno
            var exemploSkip = alunos.Skip(1).Take(3);
            foreach (var item in exemploSkip){
                Console.WriteLine(item.Nome);
            }

            var maiorNota = alunos.Max(aluno  => alunos.Nota);
            Console.WriteLine(maiorNota);

            var menorNota = alunos.Min(aluno  => alunos.Nota);
            Console.WriteLine(menorNota);

            var somatorioNotas = alunos.Sum(aluno => alunos.Nota);
            Console.WriteLine(somatorioNotas);

            var mediaDaTurma = alunos.Average(a => a.Nota >=7).Average(aluno =>aluno.Nota);

        }
    }
}
