using BuilderFilterDynamic.ChainOfResponsability;
using BuilderFilterDynamic.Flyweight;
using BuilderFilterDynamic.Intefaces;
using BuilderFilterDynamic.Models;

namespace BuilderFilterDynamic.Services
{
    public static class ContextCofR<TType>
    {
        public static IFilterTypeInterpreter<TType> SelecionarFilter(FiltroItem filtroItem)
        {
            var flyweight = new FilterFlyweight<TType>();
            var method = flyweight.Selecionar(filtroItem.FilterType);
            return method.Execute(filtroItem);
        }
    }
}
