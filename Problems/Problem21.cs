using System;
using System.Collections.Generic;
using System.Linq;
using Common;

namespace Problems
{
    public class Problem21 : IProblem
    {
        private readonly FactorizationCache _factorizationCache;

        public Problem21(FactorizationCache factorizationCache)
        {
            _factorizationCache = factorizationCache;
        }

        public long Solve()
        {
            var divisorSums = new Dictionary<long, long>();

            for (var i = 1; i < 10000; ++i)
            {
                var divisorSum = CalculateDivisorSum(i);
                divisorSums[i] = divisorSum;
            }

            var amicable = new HashSet<long>();

            foreach (var divisorSum in divisorSums.Where(divisorSum => divisorSum.Key != divisorSum.Value))
            {
                var aOne = divisorSum.Key;
                var bOne = divisorSum.Value;
                long aTwo;

                if (!divisorSums.TryGetValue(bOne, out aTwo))
                    continue;

                if (aTwo != aOne) 
                    continue;

                amicable.Add(aOne);
                amicable.Add(bOne);
                Console.WriteLine("d(" + aOne + ")=" + bOne + ", d(" + bOne + ")=" + aTwo);
            }

            return amicable.Sum();
        }

        public long CalculateDivisorSum(int value)
        {
            var factorization = _factorizationCache.Factorize(value);
            var divisors = factorization.CalculateAllPossibleDivisors();
            return divisors.Sum(x => x);
        }
    }
}
