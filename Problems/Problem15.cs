using System;
using Common;

namespace Problems
{
    public class Problem15 : IProblem
    {
        private readonly int _dimension;

        public Problem15(int dimension)
        {
            if (dimension < 2)
                throw new ArgumentException("dimension");

            if (dimension%2 != 0)
                throw new ArgumentException("dimension");

            _dimension = dimension;
        }

        public long Solve()
        {
            return 0;
        }
    }
}
