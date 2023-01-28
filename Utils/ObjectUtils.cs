using BuilderFilterDynamic.Models;
using System;

namespace BuilderFilterDynamic.Utils
{
    static class ObjectUtils
    {
        private static bool ObjetoEValorSaoIguais(object item, string value)
        {
            return ObterNomePropriedade(item, value) == value;
        }

        private static string ObterNomePropriedade(object item, string value) 
            => item.GetType().GetProperty(value).Name.ToString();

        public static FiltroItem ConverterParaFiltroItem(object item, string value, string tipoFiltro)
        {
            if (!ObjetoEValorSaoIguais(item, value))
                throw new ArgumentException("Valor da propriedade é diferente", nameof(item));

            return new FiltroItem(
                ObterNomePropriedade(item, value), 
                item.GetType().GetProperty(value).GetValue(item), 
                tipoFiltro
            );
        }
    }
}
