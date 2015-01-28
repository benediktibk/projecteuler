using System;
using Common;

namespace Problems
{
    public class Problem25 : IProblem
    {
        private readonly int _digits;

        public Problem25(int digits)
        {
            if (digits < 1)
                throw new ArgumentOutOfRangeException("digits");

            _digits = digits;
        }

        public long Solve()
        {
            var last = new BigNumber10Base(1);
            var current = new BigNumber10Base(1);
            var result = 2;

            while (current.DigitCount < _digits)
            {
                var next = BigNumber10Base.Add(last, current);
                last = current;
                current = next;
                result++;
            }

            return result;
        }
    }
}
