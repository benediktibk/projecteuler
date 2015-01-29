using System;
using Common;

namespace Problems
{
    public class Problem28 : IProblem
    {
        private readonly int _dimension;

        public Problem28(int dimension)
        {
            if (dimension < 1)
                throw new ArgumentOutOfRangeException("dimension");

            if (dimension%2 == 0)
                throw new ArgumentOutOfRangeException("dimension");

            _dimension = dimension;
        }

        public long Solve()
        {
            var result = 1;
            var current = 1;

            for (var i = 3; i <= _dimension; i += 2)
            {
                for (var j = 0; j < 4; ++j)
                {
                    current += i - 1;
                    result += current;
                }
            }

            return result;
        }
    }
}
