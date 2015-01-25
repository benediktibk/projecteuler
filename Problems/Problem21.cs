using System.Linq;
using Common;

namespace Problems
{
    public class Problem21 : IProblem
    {
        private readonly FactorizationCache _factorizationCache;

        public Problem21(FactorizationCache factorizationCache)
        {
            _factorizationCache = factorizationCache;
        }

        public long Solve()
        {
            return 0;
        }

        public long CalculateDivisorSum(int value)
        {
            var factorization = _factorizationCache.Factorize(value);
            return 1 + factorization.Sum(x => x.Key*x.Value);
        }
    }
}
