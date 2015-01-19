using System;
using System.Collections.Generic;
using System.Linq;

namespace Common
{
    public class PrimeNumbers
    {
        private readonly List<int> _primeNumbers;
        private int _currentUpperBorder;

        public PrimeNumbers()
        {
            _primeNumbers = new List<int>();
            _currentUpperBorder = 1;
        }

        public List<int> UpTo(int limit)
        {
            ExtendPrimeNumbers(limit);
            return UpToInternal(limit);
        }

        private List<int> UpToInternal(int limit)
        {
            if (limit > _currentUpperBorder)
                throw new ArgumentException("limit");

            var lower = 0;
            var upper = _primeNumbers.Count - 1;

            if (_primeNumbers[upper] == limit)
                return new List<int>(_primeNumbers);

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

        private void ExtendPrimeNumbers(int limit)
        {
            if (limit <= _currentUpperBorder)
                return;

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

            var newPrimeNumbers = new LinkedList<int>();

            for (var candidate = _currentUpperBorder + 1; candidate <= limit; ++candidate)
            {
                if (notPrime[candidate - offset])
                    continue;

                var nextCandidate = candidate * 2; 
                
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
