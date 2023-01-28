using BuilderFilterDynamic.Intefaces;
using BuilderFilterDynamic.Services;

namespace BuilderFilterDynamic.Extensions
{
    public static class InterpreterTypeExtensions
    {
        public static IFilterTypeInterpreter<TType> And<TType>(this IFilterTypeInterpreter<TType> left, IFilterTypeInterpreter<TType> right)
            => new EhInterpreter<TType>(left, right);

        public static IFilterTypeInterpreter<TType> Or<TType>(this IFilterTypeInterpreter<TType> left, IFilterTypeInterpreter<TType> right)
            => new OuInterpreter<TType>(left, right);

    }
}
