using BuilderFilterDynamic.Models;
using System;
using System.Linq.Expressions;

namespace BuilderFilterDynamic.Intefaces
{
    interface IFilterTypeBuilder<TType> where TType : class
    {
        IFilterTypeBuilder<TType> EhIgual(string nomeParametro);
        IFilterTypeBuilder<TType> Contains(string nomeParametro);
        IFilterTypeBuilder<TType> EhMaior(string nomeParametro);
        IFilterTypeBuilder<TType> EhMenor(string nomeParametro);
        IFilterTypeBuilder<TType> And(string nomeParametro, string filterType);
        Expression<Func<TType, bool>> Construir();
    }
}
