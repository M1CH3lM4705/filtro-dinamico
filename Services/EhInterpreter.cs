using BuilderFilterDynamic.Intefaces;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace BuilderFilterDynamic.Services
{
    public class EhInterpreter<TType> : IFilterTypeInterpreter<TType>
    {
        private readonly IFilterTypeInterpreter<TType> _leftInterpreter;
        private readonly IFilterTypeInterpreter<TType> _rightInterpreter;

        public EhInterpreter(IFilterTypeInterpreter<TType> leftInterpreter, IFilterTypeInterpreter<TType> rightInterpreter)
        {
            _leftInterpreter = leftInterpreter;
            _rightInterpreter = rightInterpreter;
        }

        public Expression<Func<TType, bool>> Interpretar()
        {
            var leftExpression = _leftInterpreter.Interpretar();
            var rightExpression = Expression.Invoke(_rightInterpreter.Interpretar(), leftExpression.Parameters.FirstOrDefault());

            var andAlsoExpression = Expression.AndAlso(leftExpression.Body, rightExpression);

            return Expression.Lambda<Func<TType, bool>>(andAlsoExpression, leftExpression.Parameters.FirstOrDefault());
        }
    }
}
