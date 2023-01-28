using BuilderFilterDynamic.Models;
using BuilderFilterDynamic.Services;
using System;

namespace BuilderFilterDynamic.ChainOfResponsability
{
    public class EhMaiorOuIgualCofR<TType> : FilterTypeBaseCofR<TType>
    {
        public override FilterTypeInterpreter<TType> Execute(FiltroItem filtroItem)
        {
            if (FilterTypeConstants.GreaterThanOrEqual.Equals(filtroItem.FilterType))
                return new EhMaiorOuIgual<TType>(filtroItem);
            throw new ArgumentNullException(nameof(filtroItem));
        }
    }
}
