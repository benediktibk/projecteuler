namespace Common
{
    public interface IReadOnlyFactorization
    {
        long this[long factor] { get; }
        long FactorCount { get; }
        long TotalFactorCount { get; }
        long CalculateProduct();
    }
}