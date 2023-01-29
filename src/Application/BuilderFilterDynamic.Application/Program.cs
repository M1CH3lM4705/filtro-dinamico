using BuilderFilterDynamic.Services;
using System;

namespace BuilderFilterDynamic.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            var pessoa = new Pessoa { Nome = "Michel", Idade = 35, Aluno = new Aluno { Nome = "Joao", Turma = "A" } };

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
}
