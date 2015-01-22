using System;
using System.Collections.Generic;
using System.Diagnostics;
using Common;

namespace Problems
{
    public class Problem9 : IProblem
    {
        private const int TargetSum = 1000;

        public long Solve()
        {
            for (var c = TargetSum - 1; c > 0; --c)
                for (var b = 1; b < TargetSum - c; ++b)
                {
                    var a = TargetSum - b - c;

                    if (a * a + b * b == c * c)
                        return a * b * c;
                }

            return 0;
        }
    }
}
