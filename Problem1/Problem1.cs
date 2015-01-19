using System;
using Common;

namespace Problem1
{
    public class Problem1 : IProblem
    {
        private readonly int _limit;

        public Problem1(int limit)
        {
            if (limit < 5)
                throw new ArgumentException("limit");

            _limit = limit;
        }

        public int Solve()
        {
            var result = 0;

            for (var i = 3; i < _limit; ++i)
                if (IsMultipleOf(i, 3) || IsMultipleOf(i, 5))
                    result += i;

            return result;
        }

        public bool IsMultipleOf(int product, int factor)
        {
            var quotient = product/factor;
            return quotient*factor == product;
        }
    }
}
