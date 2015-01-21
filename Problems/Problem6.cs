using Common;

namespace Problems
{
    public class Problem6 : IProblem
    {
        private readonly int _upperBorder;

        public Problem6(int upperBorder)
        {
            _upperBorder = upperBorder;
        }

        public long Solve()
        {
            var sum = (_upperBorder + 1)*_upperBorder/2;
            var sumOfSquares = 0;

            for (var i = 1; i <= _upperBorder; ++i)
                sumOfSquares += i*i;

            return sum * sum - sumOfSquares;
        }
    }
}
