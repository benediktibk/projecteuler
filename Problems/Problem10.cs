using System.Linq;
using Common;

namespace Problems
{
    public class Problem10 : IProblem
    {
        private readonly PrimeNumbers _primeNumbers;
        private readonly long _limit;

        public Problem10(long limit, PrimeNumbers primeNumbers)
        {
            _limit = limit;
            _primeNumbers = primeNumbers;
        }

        public long Solve()
        {
            var summands = _primeNumbers.UpTo(_limit);
            return summands.Sum();
        }
    }
}
