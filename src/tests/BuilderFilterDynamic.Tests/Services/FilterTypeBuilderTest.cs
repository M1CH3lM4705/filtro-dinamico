using BuilderFilterDynamic.Services;
using System;
using System.Linq.Expressions;
using Xunit;

namespace BuilderFilterDynamic.Tests.Services
{
    public class FilterTypeBuilderTest
    {
        [Fact]
        public void DevoObterExpressionEhIgual()
        {
            var pessoa = new Pessoa()
            {
                Nome = "Teste",
                Idade = 1
            };

            Expression<Func<Pessoa, bool>> lambdaEhIgual = p => p.Nome == "Teste";

            var expression = new FilterTypeBuilder<Pessoa>(pessoa).EhIgual(nameof(pessoa.Nome)).Construir();

            Assert.Equal(expression.ToString(), lambdaEhIgual.ToString());
        }
    }
}
