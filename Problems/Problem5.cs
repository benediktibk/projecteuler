using System;
using System.Collections.Generic;
using Common;

namespace Problems
{
    public class Problem5 : IProblem
    {
        private readonly int _limit;
        private readonly PrimeNumbers _primeNumbers;

        public Problem5(int limit, PrimeNumbers primeNumbers)
        {
            if (limit < 2)
                throw new ArgumentException("limit");

            _limit = limit;
            _primeNumbers = primeNumbers;
        }

        public long Solve()
        {
            var totalPrimeFactors = new Factorization();

            for (var i = 2; i < _limit; ++i)
            {
                var primeFactors = _primeNumbers.Factorize(i);

                totalPrimeFactors = Factorization.Max(totalPrimeFactors, primeFactors);
            }

            totalPrimeFactors[2] = Math.Max(2, totalPrimeFactors[2]);

            return totalPrimeFactors.CalculateProduct();
        }
    }
}
