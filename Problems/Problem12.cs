using System.Collections.Generic;
using Common;

namespace Problems
{
    public class Problem12 : IProblem
    {
        private readonly FactorizationCache _factorizationCache;
        private readonly int _factorCount;

        public Problem12(FactorizationCache factorizationCache, int factorCount)
        {
            _factorizationCache = factorizationCache;
            _factorCount = factorCount;
        }

        public long Solve()
        {
            var number = 1;

            for (var i = 2;; ++i)
            {
                number += i;

                var factorization = _factorizationCache.Factorize(number);
                var divisorCount = CalculateCountOfPossibleDivisors(factorization);
                if (divisorCount > _factorCount)
                    return number;
            }
        }

        private static long CalculateCountOfPossibleDivisors(IEnumerable<KeyValuePair<long, long>> factorization)
        {
            long result = 1;

            foreach (var factors in factorization)
                result *= (factors.Value + 1);

            return result;
        }
    }
}
