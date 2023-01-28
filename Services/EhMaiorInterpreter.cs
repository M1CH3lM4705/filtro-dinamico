using BuilderFilterDynamic.Models;
using System.Linq.Expressions;

namespace BuilderFilterDynamic.Services
{
    class EhMaiorInterpreter<TType> : FilterTypeInterpreter<TType>
    {
        public EhMaiorInterpreter(FiltroItem filtroItem) : base(filtroItem)
        {

        }
        internal override Expression CriarExpressaoBinaria(MemberExpression property, ConstantExpression constant)
            => Expression.GreaterThan(property, constant);
    }
}
