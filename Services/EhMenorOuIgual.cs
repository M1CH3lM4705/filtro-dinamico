using BuilderFilterDynamic.Models;
using System.Linq.Expressions;

namespace BuilderFilterDynamic.Services
{
    public class EhMenorOuIgual<TType> : FilterTypeInterpreter<TType>
    {
        public EhMenorOuIgual(FiltroItem filtroItem) : base(filtroItem)
        {

        }
        internal override Expression CriarExpressaoBinaria(MemberExpression property, ConstantExpression constant)
            => Expression.LessThanOrEqual(property, constant);
    }
}
