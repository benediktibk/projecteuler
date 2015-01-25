using System.Collections.Generic;

namespace Common
{
    public interface IReadOnlyFactorization : IEnumerable<KeyValuePair<long, long>>
    {
        long this[long factor] { get; }
        long FactorCount { get; }
        long TotalFactorCount { get; }
        long CountOfPossibleDivisors { get; }

        long CalculateProduct();
        List<long> CalculateAllPossibleDivisors();
    }
}