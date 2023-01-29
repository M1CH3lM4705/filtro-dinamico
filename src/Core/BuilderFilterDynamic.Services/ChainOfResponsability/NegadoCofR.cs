using BuilderFilterDynamic.Models;
using BuilderFilterDynamic.Services;
using System;

namespace BuilderFilterDynamic.ChainOfResponsability
{
    public class NegadoCofR<TType> : FilterTypeBaseCofR<TType>
    {
        public override FilterTypeInterpreter<TType> Execute(FiltroItem filtroItem)
        {
            if (FilterTypeConstants.Not.Equals(filtroItem.FilterType))
                return new Negado<TType>(filtroItem);

            throw new ArgumentException(nameof(filtroItem.FilterType));
        }
    }
}
