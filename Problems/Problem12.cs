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
                var divisorCount = factorization.CountOfPossibleDivisors + 1;
                if (divisorCount > _factorCount)
                    return number;
            }
        }
    }
}
