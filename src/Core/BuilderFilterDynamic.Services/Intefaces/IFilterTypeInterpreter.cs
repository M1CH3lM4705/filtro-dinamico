using System;
using System.Linq.Expressions;

namespace BuilderFilterDynamic.Intefaces
{
    public interface IFilterTypeInterpreter<TType>
    {
        Expression<Func<TType, bool>> Interpretar();
    }
}
