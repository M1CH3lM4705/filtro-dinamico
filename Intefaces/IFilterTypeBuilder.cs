using BuilderFilterDynamic.Models;
using System;
using System.Linq.Expressions;

namespace BuilderFilterDynamic.Intefaces
{
    public interface IFilterTypeBuilder<TType> : IBuild<TType> where TType : class
    {
        IFilterTypeBuilder<TType> EhIgual(string nomeParametro);
        IFilterTypeBuilder<TType> Contains(string nomeParametro);
        IFilterTypeBuilder<TType> EhMaior(string nomeParametro);
        IFilterTypeBuilder<TType> EhMenor(string nomeParametro);
        IFilterTypeBuilderAndOr<TType> And(string nomeParametro, string filterType);
        IFilterTypeBuilderAndOr<TType> Or(string nomeParametro, string filterType);
    }
}
