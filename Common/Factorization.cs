using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Common
{
    public class Factorization : IReadOnlyFactorization
    {
        private readonly Dictionary<long, long> _factors;

        public Factorization()
        {
            _factors = new Dictionary<long, long>();
        }

        public Factorization(Factorization factorization)
        {
            _factors = new Dictionary<long, long>(factorization._factors);
        }

        public long this[long factor]
        {
            get
            {
                long result;
                return _factors.TryGetValue(factor, out result) ? result : 0;
            }
            set { _factors[factor] = value; }
        }

        public long FactorCount
        {
            get { return _factors.Count; }
        }

        public long TotalFactorCount
        {
            get { return _factors.Sum(x => x.Value); }
        }

        public static Factorization Max(Factorization one, Factorization two)
        {
            var result = new Factorization();

            foreach (var factor in one._factors)
                result[factor.Key] = factor.Value;

            foreach (var factor in two._factors)
                result[factor.Key] = Math.Max(factor.Value, one[factor.Key]);

            return result;
        }

        public long CalculateProduct()
        {
            long result = 1;

            foreach (var factor in _factors)
            {
                for (var i = 0; i < factor.Value; ++i)
                    result *= factor.Key;
            }

            return result;
        }

        public IEnumerator<KeyValuePair<long, long>> GetEnumerator()
        {
            return _factors.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable) _factors).GetEnumerator();
        }
    }
}
