using Common;

namespace Problems
{
    public class Problem12 : IProblem
    {
        private readonly PrimeNumbers _primeNumbers;
        private readonly int _factorCount;

        public Problem12(PrimeNumbers primeNumbers, int factorCount)
        {
            _primeNumbers = primeNumbers;
            _factorCount = factorCount;
        }

        public long Solve()
        {
            return 0;
        }
    }
}
