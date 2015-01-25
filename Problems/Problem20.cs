using System;
using System.Linq;
using Common;

namespace Problems
{
    public class Problem20 : IProblem
    {
        private readonly int _number;

        public Problem20(int number)
        {
            if (number < 1)
                throw new ArgumentOutOfRangeException("number");

            _number = number;
        }

        public long Solve()
        {
            var factorial = new BigNumberInt32Base(1);

            for (var i = 2; i <= _number; ++i)
            {
                var factor = new BigNumberInt32Base((uint) i);
                factorial = BigNumberInt32Base.Multiply(factorial, factor);
            }

            var factorialIn10Base = BigNumber10Base.Convert(factorial);
            return factorialIn10Base.Sum(u => u);
        }
    }
}
