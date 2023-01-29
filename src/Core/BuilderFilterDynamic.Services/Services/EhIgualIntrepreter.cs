using BuilderFilterDynamic.Models;
using System.Linq.Expressions;

namespace BuilderFilterDynamic.Services
{
    class EhIgualIntrepreter<TType> : FilterTypeInterpreter<TType>
    {
        public EhIgualIntrepreter(FiltroItem filtroItem) : base(filtroItem)
        {
        }

        internal override Expression CriarExpressaoBinaria(MemberExpression property, ConstantExpression constant)
            => Expression.Equal(property, constant);
    }
}
