using System;
using System.Collections.Generic;
using Common;

namespace Problems
{
    public class Problem5 : IProblem
    {
        private readonly int _limit;

        public Problem5(int limit)
        {
            if (limit < 2)
                throw new ArgumentException("limit");

            _limit = limit;
        }

        public long Solve()
        {
            var primeNumbers = new PrimeNumbers();
            var totalPrimeFactors = new Dictionary<long, long>();

            for (var i = 2; i < _limit; ++i)
            {
                var primeFactors = primeNumbers.Factorize(i);

                foreach (var primeFactor in primeFactors)
                {
                    long currentCount;
                    if (totalPrimeFactors.TryGetValue(primeFactor.Key, out currentCount))
                        totalPrimeFactors[primeFactor.Key] = Math.Max(currentCount, primeFactor.Value);
                    else
                        totalPrimeFactors[primeFactor.Key] = primeFactor.Value;
                }
            }

            totalPrimeFactors[2] = Math.Max(2, totalPrimeFactors[2]);

            long result = 1;

            foreach (var primeFactor in totalPrimeFactors)
            {
                for (var i = 0; i < primeFactor.Value; ++i)
                    result *= primeFactor.Key;
            }

            return result;
        }
    }
}
