using BuilderFilterDynamic.ChainOfResponsability;
using BuilderFilterDynamic.Models;
using System.Collections.Generic;

namespace BuilderFilterDynamic.Flyweight
{
    public class FilterFlyweight<TType>
    {
        private readonly IDictionary<string, FilterTypeBaseCofR<TType>> Get =
            new Dictionary<string, FilterTypeBaseCofR<TType>>()
            {
                {FilterTypeConstants.Contains, new ContainsCofR<TType>() },
                {FilterTypeConstants.Equals, new EqualCofR<TType>() },
                {FilterTypeConstants.GreaterThan, new EhMaiorCofR<TType>() },
                {FilterTypeConstants.LessThan, new EhMenorCofR<TType>() },
                {FilterTypeConstants.GreaterThanOrEqual, new EhMaiorOuIgualCofR<TType>() },
                {FilterTypeConstants.LessThanOrEqual, new EhMenorOuIgualCofR<TType>() },
                {FilterTypeConstants.NotEqual, new EhDiferenteCofR<TType>() },
                {FilterTypeConstants.Not, new NegadoCofR<TType>() },
            };

        public FilterTypeBaseCofR<TType> Selecionar(string filterType) =>
            Get[filterType];
    }
}
