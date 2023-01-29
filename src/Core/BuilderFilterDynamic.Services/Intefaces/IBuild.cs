using System;
using System.Linq.Expressions;

namespace BuilderFilterDynamic.Intefaces
{
    public interface IBuild<TType>
    {
        /// <summary>
        /// Metódo que monta a Expression tree para queries
        /// </summary>
        /// <returns></returns>
        Expression<Func<TType, bool>> Construir();
    }
}
