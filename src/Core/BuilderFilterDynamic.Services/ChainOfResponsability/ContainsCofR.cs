using BuilderFilterDynamic.Models;
using BuilderFilterDynamic.Services;
using System;

namespace BuilderFilterDynamic.ChainOfResponsability
{
    public class ContainsCofR<TType> : FilterTypeBaseCofR<TType>
    {
        public override FilterTypeInterpreter<TType> Execute(FiltroItem filtroItem)
        {
            if (filtroItem.FilterType == FilterTypeConstants.Contains)
            {
                return new ContainsInterpreter<TType>(filtroItem);
            }
            throw new ArgumentException(nameof(filtroItem.FilterType));
        }
    }
}
