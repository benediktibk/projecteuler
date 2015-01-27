using System;

namespace Common
{
    public static class Combinatorial
    {
        public static long Factorial(long n)
        {
            if (n < 0)
                throw new ArgumentOutOfRangeException("n");

            long result = 1;

            for (var i = 2; i <= n; ++i)
                result *= i;

            return result;
        }
    }
}
