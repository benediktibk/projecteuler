using System;
using System.Collections.Generic;

namespace Common
{
    public class PrimeNumbers
    {
        private readonly List<long> _primeNumbers;
        private long _currentUpperBorder;

        public PrimeNumbers()
        {
            _primeNumbers = new List<long>();
            _currentUpperBorder = 1;
        }

        public List<long> UpTo(long limit)
        {
            ExtendPrimeNumbers(limit);
            return UpToInternal(limit);
        }

        private List<long> UpToInternal(long limit)
        {
            if (limit > _currentUpperBorder)
                throw new ArgumentException("limit");

            var lower = 0;
            var upper = _primeNumbers.Count - 1;

            if (_primeNumbers[upper] == limit)
                return new List<long>(_primeNumbers);

            while (upper - lower > 1)
            {
                var middle = (upper + lower)/2;

                if (_primeNumbers[middle] < limit)
                    lower = middle;
                else
                    upper = middle;
            }

            return _primeNumbers.GetRange(0, upper + 1);
        }

        private void ExtendPrimeNumbers(long limit)
        {
            if (limit <= _currentUpperBorder)
                return;

            var blockSize = (int)Math.Pow(2, 30 - 2);

            var blockCount = (int)((limit - _currentUpperBorder)/blockSize);

            for (var i = 0; i < blockCount; ++i)
                ExtendPrimeNumbersInternal(_currentUpperBorder + blockSize);

            ExtendPrimeNumbersInternal(limit);
        }

        private void ExtendPrimeNumbersInternal(long limit)
        {
            var offset = _currentUpperBorder + 1;
            var notPrime = new bool[limit - _currentUpperBorder];

            foreach (var primeNumber in _primeNumbers)
            {
                var nextCandidate = (_currentUpperBorder/primeNumber + 1)*primeNumber;

                while (nextCandidate <= limit)
                {
                    notPrime[nextCandidate - offset] = true;
                    nextCandidate += primeNumber;
                }
            }

            var newPrimeNumbers = new LinkedList<long>();

            for (var candidate = _currentUpperBorder + 1; candidate <= limit; ++candidate)
            {
                if (notPrime[candidate - offset])
                    continue;

                var nextCandidate = candidate*2;

                while (nextCandidate <= limit)
                {
                    notPrime[nextCandidate - offset] = true;
                    nextCandidate += candidate;
                }

                newPrimeNumbers.AddLast(candidate);
            }

            _primeNumbers.AddRange(newPrimeNumbers);

            _currentUpperBorder = limit;
        }
    }
}
