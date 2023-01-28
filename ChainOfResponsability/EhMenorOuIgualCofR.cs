using BuilderFilterDynamic.Models;
using BuilderFilterDynamic.Services;
using System;

namespace BuilderFilterDynamic.ChainOfResponsability
{
    public class EhMenorOuIgualCofR<TType> : FilterTypeBaseCofR<TType>
    {
        public override FilterTypeInterpreter<TType> Execute(FiltroItem filtroItem)
        {
            if (FilterTypeConstants.LessThanOrEqual.Equals(filtroItem.FilterType))
                return new EhMenorOuIgual<TType>(filtroItem);
            throw new ArgumentNullException(nameof(filtroItem));
        }
    }
}
