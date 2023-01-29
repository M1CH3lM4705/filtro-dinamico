using BuilderFilterDynamic.Intefaces;
using BuilderFilterDynamic.Models;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace BuilderFilterDynamic.Services
{
    public abstract class FilterTypeInterpreter<TType> : IFilterTypeInterpreter<TType>
    {
        private readonly FiltroItem _filtroItem;

        public FilterTypeInterpreter(FiltroItem filtroItem)
        {
            _filtroItem = filtroItem;
        }

        public Expression<Func<TType, bool>> Interpretar()
        {
            var dynamicType = typeof(TType);
            var parametro = Expression.Parameter(dynamicType, dynamicType.Name.First().ToString().ToLower());
            var propriedade = Expression.Property(parametro, _filtroItem.Propriedade);
            var propriedadeInfo = (PropertyInfo)propriedade.Member;
            var value = Convert.ChangeType(_filtroItem.Value.ToString(), propriedadeInfo.PropertyType);
            var constante = Expression.Constant(value);
            var expressao = CriarExpressaoBinaria(propriedade, constante);

            return Expression.Lambda<Func<TType, bool>>(expressao, parametro);
        }

        internal abstract Expression CriarExpressaoBinaria(MemberExpression property, ConstantExpression constant);
    }
}
