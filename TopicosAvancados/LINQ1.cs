using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.TopicosAvancados
{
    public class Aluno{
        public string Nome;
        public int Idade;
        public double Nota;
    }

    internal class LINQ1
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

            Console.WriteLine("== Aprovados ================");
            var aprovados = alunos.Where(a => a.Nota > 7).OrderBy(a => a.Nome); //OrderBy(a => -a.Nome); Para ficar na ordem inversa
            foreach (var aluno in aprovados){
                Console.WriteLine(aluno.Nome);
            }

            Console.WriteLine("== Chamada ================");
            var chamada = alunos.OrderBy(a => a.Nome).Select(a => a.Nome); //transformando um objeto compleato em apenas nome
            foreach (var aluno in chamada){
                Console.Write(aluno);
            }

            Console.WriteLine("\n== Aprovados (por idade) ==========");
            var alunosAprovados =
                from aluno in alunos
                where aluno.Nota > 7
                orderby aluno.Idade
                select aluno.Nome;
        }
    }
}
