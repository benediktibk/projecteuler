using System.Collections.Generic;
using Common;

namespace Problems
{
    public class Problem27 : IProblem
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
            long resultLength = 0;
            long result = 0;

            for (var i = (-1)*_limit; i <= _limit; ++i)
                aCandidates.Add(i);

            foreach (var b in bCandidates)
            {
                var bEven = b%2;
                
                foreach (var a in aCandidates)
                {
                    var aEven = a%2;

                    if (aEven != bEven)
                        continue;

                    var length = CalculateLengthOfPrimeSequence(a, b);

                    if (length <= resultLength) 
                        continue;

                    resultLength = length;
                    result = a*b;
                }
            }

            return result;
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
