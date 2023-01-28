using BuilderFilterDynamic.Models;
using System.Linq.Expressions;

namespace BuilderFilterDynamic.Services
{
    class EhMenorIntrepreter<TType> : FilterTypeInterpreter<TType>
    {
        public EhMenorIntrepreter(FiltroItem filtroItem) : base(filtroItem)
        {

        }

        internal override Expression CriarExpressaoBinaria(MemberExpression property, ConstantExpression constant)
            => Expression.LessThan(property, constant);
    }
}
