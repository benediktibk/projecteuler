using System;
using Common;

namespace Problems
{
    public class Problem3 : IProblem
    {
        private readonly long _number;

        public Problem3(long number)
        {
            if (number < 2)
                throw new ArgumentException("number");

            _number = number;
        }

        public long Solve()
        {
            var primeNumbers = new PrimeNumbers();
            var candidates = primeNumbers.UpTo((long)Math.Sqrt(_number));

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
