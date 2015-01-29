using System;
using System.Collections.Generic;

namespace Common
{
    public class PrimeNumbers
    {
        private readonly List<long> _primeNumbers;
        private readonly Dictionary<long, bool> _isPrime; 
        private long _currentUpperBorder;

        public PrimeNumbers()
        {
            _primeNumbers = new List<long>();
            _isPrime = new Dictionary<long, bool>();
            _currentUpperBorder = 1;
        }

        public int Count
        {
            get { return _primeNumbers.Count; }
        }

        public bool IsPrime(long value)
        {
            bool result;

            if (_isPrime.TryGetValue(value, out result))
                return result;

            result = IsPrimeInternal(value);
            _isPrime.Add(value, result);
            return result;
        }

        public List<long> UpTo(long limit)
        {
            Extend(limit);
            return UpToInternal(limit);
        }

        public Factorization Factorize(long value)
        {
            var factorCandidates = UpTo((long)Math.Sqrt(value));
            var result = new Factorization();

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

            if (result.FactorCount == 0)
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

            var blockSize = (int)Math.Pow(2, 24);

            var blockCount = (int)((limit - _currentUpperBorder) / blockSize);

            for (var i = 0; i < blockCount; ++i)
                ExtendInternal(_currentUpperBorder + blockSize);

            ExtendInternal(limit);
        }

        private bool IsPrimeInternal(long value)
        {
            Extend(value);
            return _primeNumbers.Contains(value);
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
            var candidatesList = new List<long>((int)(limit - _currentUpperBorder));

            for (var candidate = _currentUpperBorder + 1; candidate <= limit; ++candidate)
                candidatesList.Add(candidate);

            var candidates = new HashSet<long>(candidatesList);

            foreach (var primeNumber in _primeNumbers)
            {
                var nextCandidate = (_currentUpperBorder/primeNumber + 1)*primeNumber;

                while (nextCandidate <= limit)
                {
                    candidates.Remove(nextCandidate);
                    nextCandidate += primeNumber;
                }
            }

            var newPrimeNumbers = new LinkedList<long>();
            var reducedCandidates = new HashSet<long>(candidates);

            foreach (var candidate in candidates)
            {
                if (!reducedCandidates.Contains(candidate))
                    continue;

                var nextCandidate = candidate*2;

                while (nextCandidate <= limit)
                {
                    reducedCandidates.Remove(nextCandidate);
                    nextCandidate += candidate;
                }

                newPrimeNumbers.AddLast(candidate);
            }

            _primeNumbers.AddRange(newPrimeNumbers);

            _currentUpperBorder = limit;
        }
    }
}
