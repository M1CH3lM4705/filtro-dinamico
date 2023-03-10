using BuilderFilterDynamic.Models;
using BuilderFilterDynamic.Services;
using System;

namespace BuilderFilterDynamic.ChainOfResponsability
{
    public class EhMenorCofR<TType> : FilterTypeBaseCofR<TType>
    {
        public override FilterTypeInterpreter<TType> Execute(FiltroItem filtroItem)
        {
            if (filtroItem.FilterType == FilterTypeConstants.LessThan)
            {
                return new EhMenorIntrepreter<TType>(filtroItem);
            }

            throw new ArgumentException(nameof(filtroItem.FilterType));
        }
    }
}
