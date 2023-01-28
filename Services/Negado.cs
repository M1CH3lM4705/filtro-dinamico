using BuilderFilterDynamic.Models;
using System.Linq.Expressions;

namespace BuilderFilterDynamic.Services
{
    public class Negado<TType> : FilterTypeInterpreter<TType>
    {
        public Negado(FiltroItem filtroItem) : base(filtroItem)
        {

        }
        internal override Expression CriarExpressaoBinaria(MemberExpression property, ConstantExpression constant)
            => Expression.Not(property);
    }
}
