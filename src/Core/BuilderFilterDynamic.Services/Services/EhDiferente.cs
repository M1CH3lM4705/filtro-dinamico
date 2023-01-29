using BuilderFilterDynamic.Models;
using System.Linq.Expressions;

namespace BuilderFilterDynamic.Services
{
    public class EhDiferente<TType> : FilterTypeInterpreter<TType>
    {
        public EhDiferente(FiltroItem filtroItem) : base(filtroItem)
        {

        }
        internal override Expression CriarExpressaoBinaria(MemberExpression property, ConstantExpression constant)
            => Expression.NotEqual(property, constant);
    }
}
