using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Problems
{
    public class Problem7 : IProblem
    {
        private readonly int _count;
        private readonly PrimeNumbers _primeNumbers;

        public Problem7(int count, PrimeNumbers primeNumbers)
        {
            _count = count;
            _primeNumbers = primeNumbers;
        }

        public long Solve()
        {
            var upperBorder = 100;

            while (_primeNumbers.Count < _count)
            {
                upperBorder *= 10;
                _primeNumbers.Extend(upperBorder);
            }

            var allPrimeNumbers = _primeNumbers.UpTo(upperBorder);
            return allPrimeNumbers[_count - 1];
        }
    }
}
