using BuilderFilterDynamic.Models;
using System.Linq.Expressions;

namespace BuilderFilterDynamic.Services
{
    public class EhMaiorOuIgual<TType> : FilterTypeInterpreter<TType>
    {
        public EhMaiorOuIgual(FiltroItem filtroItem) : base(filtroItem)
        {

        }
        internal override Expression CriarExpressaoBinaria(MemberExpression property, ConstantExpression constant)
            => Expression.GreaterThanOrEqual(property, constant);
    }
}
