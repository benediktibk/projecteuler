using System.Collections.Generic;
using System.Linq;
using Common;

namespace Problems
{
    public class Problem23 : IProblem
    {
        private readonly FactorizationCache _factorizationCache;
        private readonly int _limit;

        public Problem23(FactorizationCache factorizationCacheCache)
        {
            _factorizationCache = factorizationCacheCache;
            _limit = 28123;
        }

        public long Solve()
        {
            var abundantNumbers = FindAbundantNumbers();
            var possibleSums = CalculatePossibleSums(abundantNumbers);
            long result = 0;

            for (var i = 1; i < _limit; ++i)
                if (!possibleSums.Contains(i))
                    result += i;

            return result;
        }

        public List<long> FindAbundantNumbers()
        {
            var result = new List<long>(_limit);

            for (var i = 2; i < _limit; ++i)
            {
                var factorization = _factorizationCache.Factorize(i);
                var divisors = factorization.CalculateAllPossibleDivisors();
                var divisorSum = divisors.Sum(x => x);

                if (divisorSum > i)
                    result.Add(i);
            }

            return result;
        }

        public HashSet<long> CalculatePossibleSums(IReadOnlyList<long> abundantNumbers)
        {
            var result = new HashSet<long>();

            for (var i = 0; i < abundantNumbers.Count; ++i)
            {
                for (var j = i; j < abundantNumbers.Count; ++j)
                {
                    var sum = abundantNumbers[i] + abundantNumbers[j];

                    if (sum >= _limit)
                        break;

                    result.Add(sum);
                }
            }

            return result;
        }
    }
}
