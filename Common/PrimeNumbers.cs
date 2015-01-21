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

        public int Count
        {
            get { return _primeNumbers.Count; }
        }

        public List<long> UpTo(long limit)
        {
            Extend(limit);
            return UpToInternal(limit);
        }

        public Dictionary<long, long> Factorize(long value)
        {
            var factorCandidates = UpTo((long)Math.Sqrt(value));
            var result = new Dictionary<long, long>();

            foreach (var factorCandidate in factorCandidates)
            {
                var alreadyAdded = false;

                while (true)
                {
                    var remainder = value%factorCandidate;

                    if (remainder != 0)
                        break;

                    value /= factorCandidate;

                    if (alreadyAdded)
                        result[factorCandidate]++;
                    else
                    {
                        result[factorCandidate] = 1;
                        alreadyAdded = true;
                    }
                }
            }

            if (result.Count == 0)
                result[value] = 1;

            return result;
        }

        public long UpperBorderForNumberOfPrimeNumbers(long x)
        {
            if (x < 100)
                return 25;

            return (long)(x/Math.Log(x)*1.2);
        }

        public void Extend(long limit)
        {
            if (limit <= _currentUpperBorder)
                return;

            var blockSize = (int)Math.Pow(2, 30 - 2);

            var blockCount = (int)((limit - _currentUpperBorder) / blockSize);

            for (var i = 0; i < blockCount; ++i)
                ExtendInternal(_currentUpperBorder + blockSize);

            ExtendInternal(limit);
        }

        private List<long> UpToInternal(long limit)
        {
            if (limit > _currentUpperBorder)
                throw new ArgumentException("limit");

            var lower = 0;
            var upper = _primeNumbers.Count - 1;

            if (upper >= 0 && _primeNumbers[upper] == limit)
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

        private void ExtendInternal(long limit)
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
