using BuilderFilterDynamic.Extensions;
using BuilderFilterDynamic.Models;
using BuilderFilterDynamic.Services;
using System;

namespace BuilderFilterDynamic
{
    class Program
    {

        static void Main(string[] args)
        {
            var pessoa = new Pessoa { Nome = "Michel", Idade = 35, Aluno = new Aluno { Nome="Joao", Turma="A"} };
            //var filtro = new FiltroItem(nameof(pessoa.Nome), pessoa.Nome);
            //filtro.AddAnd(new FiltroItem("Teste1", pessoa.Nome));
            //filtro.AddAnd(new FiltroItem("Teste2", pessoa.Nome));

            var builderFilter = new FilterTypeBuilder<Pessoa>(pessoa)
                .EhIgual(nameof(pessoa.Nome))
                .Contains(nameof(pessoa.Nome))
                .Contains(nameof(pessoa.Aluno.Nome))
                .EhMaior(nameof(pessoa.Idade))
                .And(nameof(pessoa.Idade), "lessThan")
                .Construir();

            Console.WriteLine(builderFilter);
         }
    }

    class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public Aluno Aluno { get; set; }
    }

    class Aluno
    {
        public string Nome { get; set; }
        public string Turma { get; set; }
    }
}
