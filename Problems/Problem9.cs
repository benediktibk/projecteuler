using System;
using System.Collections.Generic;
using Common;

namespace Problems
{
    public class Problem9 : IProblem
    {
        private const int TargetSum = 1000;

        public long Solve()
        {
            for (var c = TargetSum - 1; c > 0; --c)
                for (var b = c - 1; b > 0; --b)
                    for (var a = b - 1; a > 0; --a)
                    {
                        if (a*a + b*b != c*c)
                            continue;

                        if (a + b + c == TargetSum)
                            return a*b*c;
                    }

            return 0;
        }
    }
}
