namespace BuilderFilterDynamic.Intefaces
{
    public interface IFilterTypeBuilder<TType> : IBuild<TType> where TType : class
    {
        IFilterTypeBuilder<TType> EhIgual(string nomeParametro);
        IFilterTypeBuilder<TType> Contains(string nomeParametro);
        IFilterTypeBuilder<TType> EhMaior(string nomeParametro);
        IFilterTypeBuilder<TType> EhMenor(string nomeParametro);
        IFilterTypeBuilder<TType> EhMaiorOuIgual(string nomeParametro);
        IFilterTypeBuilder<TType> EhMenorOuIgual(string nomeParametro);
        IFilterTypeBuilder<TType> Negar(string nomeParametro);
        IFilterTypeBuilder<TType> EhDiferente(string nomeParametro);
        IFilterTypeBuilder<TType> And(string nomeParametro, string filterType);
        IFilterTypeBuilder<TType> Or(string nomeParametro, string filterType);
    }
}
