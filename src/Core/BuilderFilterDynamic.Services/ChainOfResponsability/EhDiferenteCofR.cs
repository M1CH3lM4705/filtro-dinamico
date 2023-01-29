using BuilderFilterDynamic.Models;
using BuilderFilterDynamic.Services;
using System;

namespace BuilderFilterDynamic.ChainOfResponsability
{
    public class EhDiferenteCofR<TType> : FilterTypeBaseCofR<TType>
    {
        public override FilterTypeInterpreter<TType> Execute(FiltroItem filtroItem)
        {
            if (FilterTypeConstants.NotEqual.Equals(filtroItem.FilterType))
                return new EhDiferente<TType>(filtroItem);
            throw new ArgumentNullException(nameof(filtroItem.FilterType));
        }
    }
}
