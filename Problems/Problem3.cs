using System;
using Common;

namespace Problems
{
    public class Problem3 : IProblem
    {
        private readonly long _number;
        private readonly PrimeNumbers _primeNumbers;

        public Problem3(long number, PrimeNumbers primeNumbers)
        {
            if (number < 2)
                throw new ArgumentException("number");

            _number = number;
            _primeNumbers = primeNumbers;
        }

        public long Solve()
        {
            var candidates = _primeNumbers.UpTo((long)Math.Sqrt(_number));

            for (var i = candidates.Count - 1; i >= 0; --i)
            {
                var candidate = candidates[i];

                if (_number%candidate == 0)
                    return candidate;
            }

            return _number;
        }
    }
}
