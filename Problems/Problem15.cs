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

            _dimension = dimension;
        }

        public long Solve()
        {
            return ExplorePossibilities(0, 0);
        }

        public long ExplorePossibilities(int right, int down)
        {
            if (right == _dimension && down == _dimension)
                return 1;

            long result = 0;

            if (right < _dimension)
                result += ExplorePossibilities(right + 1, down);

            if (down < _dimension)
                result += ExplorePossibilities(right, down + 1);

            return result;
        }
    }
}
