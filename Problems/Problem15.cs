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
            long result = 0;

            for (var diagonalPoint = 0; diagonalPoint < _dimension/2; ++diagonalPoint)
            {
                var toDiagonal = ExplorePossibilities(0, 0, _dimension - diagonalPoint, diagonalPoint);
                result += 2*toDiagonal*toDiagonal;
            }

            var toMiddle = ExplorePossibilities(0, 0, _dimension/2, _dimension/2);
            result += toMiddle*toMiddle;

            return result;
        }

        public long ExplorePossibilities(int currentRight, int currentDown, int targetRight, int targetDown)
        {
            if (currentRight == targetRight && currentDown == targetDown)
                return 1;

            long result = 0;

            if (currentRight < targetRight)
                result += ExplorePossibilities(currentRight + 1, currentDown, targetRight, targetDown);

            if (currentDown < targetDown)
                result += ExplorePossibilities(currentRight, currentDown + 1, targetRight, targetDown);

            return result;
        }
    }
}
