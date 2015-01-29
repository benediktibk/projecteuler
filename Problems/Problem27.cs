using System.Collections.Generic;
using Common;

namespace Problems
{
    class Problem27 : IProblem
    {
        private readonly int _limit;
        private readonly PrimeNumbers _primeNumbers;

        public Problem27(PrimeNumbers primeNumbers)
        {
            _limit = 1000;
            _primeNumbers = primeNumbers;
        }

        public long Solve()
        {
            var bCandidates = _primeNumbers.UpTo(_limit);
            var aCandidates = new List<long>();

            for (var i = (-1)*_limit; i <= _limit; ++i)
                aCandidates.Add(i);
            return 0;
        }

        public long CalculateLengthOfPrimeSequence(long a, long b)
        {
            var n = 0;

            while (_primeNumbers.IsPrime(EvaluatePolynom(a, b, n)))
                n++;

            return n;
        }

        public static long EvaluatePolynom(long a, long b, long n)
        {
            return n*n + a*n + b;
        }
    }
}
