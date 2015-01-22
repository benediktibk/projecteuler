using System;
using System.Collections.Generic;
using System.Linq;

namespace Common
{
    public class FactorizingCache
    {
        private readonly PrimeNumbers _primeNumbers;
        private readonly Dictionary<long, Factorization> _factorizations; 

        public FactorizingCache(PrimeNumbers primeNumbers)
        {
            _primeNumbers = primeNumbers;
            _factorizations = new Dictionary<long, Factorization>();
        }

        public Factorization Factorize(long value)
        {
            Factorization result;
            if (_factorizations.TryGetValue(value, out result))
                return result;

            var factorCandidates = _primeNumbers.UpTo((long)Math.Sqrt(value));

            foreach (var factorCandidate in factorCandidates.Where(factorCandidate => value%factorCandidate == 0))
            {
                result = Factorize(value/factorCandidate);
                result[factorCandidate]++;
                return result;
            }

            result = new Factorization();
            result[value] = 1;
            return result;
        }
    }
}
