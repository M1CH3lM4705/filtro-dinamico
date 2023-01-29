using BuilderFilterDynamic.Models;
using BuilderFilterDynamic.Services;
using System;

namespace BuilderFilterDynamic.ChainOfResponsability
{
    public class EhMaiorCofR<TType> : FilterTypeBaseCofR<TType>
    {
        public override FilterTypeInterpreter<TType> Execute(FiltroItem filtroItem)
        {
            if(filtroItem.FilterType == FilterTypeConstants.GreaterThan)
            {
                return new EhMaiorInterpreter<TType>(filtroItem);
            }

            throw new ArgumentException(nameof(filtroItem.FilterType));

        }
    }
}
