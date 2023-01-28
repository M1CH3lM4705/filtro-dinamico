using BuilderFilterDynamic.Models;
using System.Linq.Expressions;
using System.Reflection;

namespace BuilderFilterDynamic.Services
{
    class ContainsInterpreter<TType> : FilterTypeInterpreter<TType>
    {
        private readonly MethodInfo methodInfoContains;

        public ContainsInterpreter(FiltroItem filtroItem) : base(filtroItem)
        {
            methodInfoContains = typeof(string).GetMethod(nameof(string.Contains), new[] { typeof(string) });
        }

        internal override Expression CriarExpressaoBinaria(MemberExpression property, ConstantExpression constant)
            => Expression.Call(property, methodInfoContains, constant);
    }
}
