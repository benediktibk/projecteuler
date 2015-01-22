using System;
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

        private static long CalculateCountOfPossibleDivisors(IReadOnlyFactorization factorization)
        {
            var primeFactorCount = factorization.TotalFactorCount;
            long result = 1;

            for (var i = 1; i <= primeFactorCount; ++i)
                result += CalculateSelectionOutOf(primeFactorCount, i);

            foreach (var factors in factorization)
                for (var i = 2; i <= factors.Value; ++i)
                    result -= CalculateSelectionOutOf(factors.Value, i);

            return result;
        }

        private static long CalculateSelectionOutOf(long n, long k)
        {
            return CalculateFactorial(n)/(CalculateFactorial(k)*CalculateFactorial(n - k));
        }

        private static long CalculateFactorial(long n)
        {
            var result = 1;

            for (var i = 2; i <= n; ++i)
                result *= i;

            return result;
        }
    }
}
