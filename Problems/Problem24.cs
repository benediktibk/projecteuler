using System.Collections.Generic;
using Common;

namespace Problems
{
    public class Problem24 : IProblem
    {
        private readonly int _digitCount;
        private readonly int _permutationIndex;

        public Problem24(int digitCount, int permutationIndex)
        {
            _digitCount = digitCount;
            _permutationIndex = permutationIndex;
        }

        public long Solve()
        {
            return 0;
        }

        public List<long> CreateAllPermutations()
        {
            var result = new List<long>();
            return result;
        }
    }
}
