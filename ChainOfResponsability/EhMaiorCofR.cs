using BuilderFilterDynamic.Models;
using BuilderFilterDynamic.Services;

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

            return null;
        }
    }
}
