using BuilderFilterDynamic.Models;
using BuilderFilterDynamic.Services;

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
            return null;
        }
    }
}
