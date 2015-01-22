using System;
using System.Collections.Generic;
using System.Linq;

namespace Common
{
    public class FactorizationCache
    {
        private readonly PrimeNumbers _primeNumbers;
        private readonly Dictionary<long, Factorization> _factorizations; 

        public FactorizationCache(PrimeNumbers primeNumbers)
        {
            _primeNumbers = primeNumbers;
            _factorizations = new Dictionary<long, Factorization>();
        }

        public IReadOnlyFactorization Factorize(long value)
        {
            return FactorizeInternal(value);
        }

        private Factorization FactorizeInternal(long value)
        {
            Factorization result;
            if (_factorizations.TryGetValue(value, out result))
                return result;

            var factorCandidates = _primeNumbers.UpTo((long)Math.Sqrt(value));

            foreach (var factorCandidate in factorCandidates.Where(factorCandidate => value % factorCandidate == 0))
            {
                result = new Factorization(FactorizeInternal(value / factorCandidate));
                result[factorCandidate]++;
                _factorizations.Add(value, result);
                return result;
            }

            result = new Factorization();
            result[value] = 1;
            _factorizations.Add(value, result);
            return result;
        }
    }
}
