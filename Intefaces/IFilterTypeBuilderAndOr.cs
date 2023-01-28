namespace BuilderFilterDynamic.Intefaces
{
    /// <summary>
    /// Interface <c>IFilterTypeBuilderAndOr</c>
    /// </summary>
    /// <typeparam name="TType">É uma classe</typeparam>
    public interface IFilterTypeBuilderAndOr<TType> : IBuild<TType>
    {
       /// <summary>
       /// Metódo <c>And</c> que recebe dois parâmetros obrigatórios
       /// </summary>
       /// <param name="nomeParametro"></param>
       /// <param name="filterType"></param>
       /// <returns></returns>
        IFilterTypeBuilderAndOr<TType> And(string nomeParametro, string filterType);
        /// <summary>
        /// Metódo <c>Or</c> que recebe dois parâmetros obrigatórios
        /// </summary>
        /// <param name="nomeParametro"></param>
        /// <param name="filterType"></param>
        /// <returns>TType</returns>
        IFilterTypeBuilderAndOr<TType> Or(string nomeParametro, string filterType);
    }
}
