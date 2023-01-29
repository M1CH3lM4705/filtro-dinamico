using BuilderFilterDynamic.Models;
using BuilderFilterDynamic.Services;

namespace BuilderFilterDynamic.ChainOfResponsability
{
    public abstract class FilterTypeBaseCofR<TType>
    {
        public abstract FilterTypeInterpreter<TType> Execute(FiltroItem filtroItem);
    }
}
