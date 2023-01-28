using BuilderFilterDynamic.Models;
using BuilderFilterDynamic.Services;
using System;

namespace BuilderFilterDynamic.ChainOfResponsability
{
    public class EqualCofR<TType> : FilterTypeBaseCofR<TType>
    {
        public override FilterTypeInterpreter<TType> Execute(FiltroItem filtroItem)
        {
            if(filtroItem.FilterType == FilterTypeConstants.Equals)
            {
                return new EhIgualIntrepreter<TType>(filtroItem);
            }
            return null;
        }
    }
}
