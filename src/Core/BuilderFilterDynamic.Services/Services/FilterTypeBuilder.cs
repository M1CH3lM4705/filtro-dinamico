using BuilderFilterDynamic.Extensions;
using BuilderFilterDynamic.Intefaces;
using BuilderFilterDynamic.Models;
using BuilderFilterDynamic.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace BuilderFilterDynamic.Services
{
    public class FilterTypeBuilder<TType> : 
        IFilterTypeBuilder<TType> where TType : class
    {
        private readonly IList<IFilterTypeInterpreter<TType>> _filterTypes;
        private readonly object _filtro;
        public FilterTypeBuilder(object filtro)
        {
            _filterTypes = new List<IFilterTypeInterpreter<TType>>();
            _filtro = filtro;
        }

        public IFilterTypeBuilder<TType> Contains(string nomeParametro)
        {
            var filtro = ObjectUtils.ConverterParaFiltroItem(_filtro, nomeParametro, "contains");
           _filterTypes.Add(ContextCofR<TType>.SelecionarFilter(filtro));
            return this;
        }

        public IFilterTypeBuilder<TType> And(string nomeParamentro, string filterType)
        {
            var filtro = ObjectUtils.ConverterParaFiltroItem(_filtro, nomeParamentro, filterType);
            _filterTypes[_filterTypes.IndexOf(_filterTypes.Last())] = _filterTypes.Last().And(ContextCofR<TType>.SelecionarFilter(filtro));
            return this;
        }

        public IFilterTypeBuilder<TType> Or(string nomeParamentro, string filterType)
        {
            var filtro = ObjectUtils.ConverterParaFiltroItem(_filtro, nomeParamentro, filterType);
            _filterTypes[_filterTypes.IndexOf(_filterTypes.Last())] = _filterTypes.Last().Or(ContextCofR<TType>.SelecionarFilter(filtro));
            return this;
        }

        public IFilterTypeBuilder<TType> EhIgual(string nomeParametro)
        {
            var filtro = ObjectUtils.ConverterParaFiltroItem(_filtro, nomeParametro, "equals");
            _filterTypes.Add(ContextCofR<TType>.SelecionarFilter(filtro));
            return this;

        }

        public IFilterTypeBuilder<TType> EhMaior(string nomeParametro)
        {
            var filtro = ObjectUtils.ConverterParaFiltroItem(_filtro, nomeParametro, "greaterThan");
            _filterTypes.Add(ContextCofR<TType>.SelecionarFilter(filtro));
            return this;

        }

        public IFilterTypeBuilder<TType> EhMenor(string nomeParametro)
        {
            var filtro = ObjectUtils.ConverterParaFiltroItem(_filtro, nomeParametro, "lessThan");
            _filterTypes.Add(ContextCofR<TType>.SelecionarFilter(filtro));
            return this;

        }

        public IFilterTypeBuilder<TType> EhMaiorOuIgual(string nomeParametro)
        {
            var filtro = ObjectUtils.ConverterParaFiltroItem(_filtro, nomeParametro, "greaterThanOrEqual");
            _filterTypes.Add(ContextCofR<TType>.SelecionarFilter(filtro));
            return this;
        }

        public IFilterTypeBuilder<TType> EhMenorOuIgual(string nomeParametro)
        {
            var filtro = ObjectUtils.ConverterParaFiltroItem(_filtro, nomeParametro, "lessThanOrEqual");
            _filterTypes.Add(ContextCofR<TType>.SelecionarFilter(filtro));
            return this;
        }

        public IFilterTypeBuilder<TType> Negar(string nomeParametro)
        {
            var filtro = ObjectUtils.ConverterParaFiltroItem(_filtro, nomeParametro, "not");
            _filterTypes.Add(ContextCofR<TType>.SelecionarFilter(filtro));
            return this;
        }

        public IFilterTypeBuilder<TType> EhDiferente(string nomeParametro)
        {
            var filtro = ObjectUtils.ConverterParaFiltroItem(_filtro, nomeParametro, "notEqual");
            _filterTypes.Add(ContextCofR<TType>.SelecionarFilter(filtro));
            return this;
        }

        public Expression<Func<TType, bool>> Construir()
        {
            return _filterTypes?
                .Aggregate((curr, next) => curr.And(next))
                .Interpretar();
        }
    }
}
