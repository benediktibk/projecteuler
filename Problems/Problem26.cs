using System;
using System.Collections.Generic;
using System.Linq;
using Common;

namespace Problems
{
    public class Problem26 : IProblem
    {
        private readonly int _denominatorLimit;

        public Problem26(int denominatorLimit)
        {
            if (denominatorLimit < 2)
                throw new ArgumentOutOfRangeException("denominatorLimit");

            _denominatorLimit = denominatorLimit;
        }

        public long Solve()
        {
            var result = 0;
            var resultValue = 0;

            for (var i = 2; i < _denominatorLimit; ++i)
            {
                var candidate = CalculatePeriodLength(i);

                if (candidate <= resultValue) 
                    continue;

                resultValue = candidate;
                result = i;
            }

            return result;
        }

        public static int CalculatePeriodLength(int denominator)
        {
            var rests = new List<int>{1};

            while (rests.Last() > 0)
            {
                var rest = rests.Last()*10;
                var digit = rest/denominator;
                rest = rest - digit*denominator;
                var index = rests.FindIndex(x => x == rest);

                if (index >= 0)
                    return rests.Count - index;

                rests.Add(rest);
            }

            return 0;
        }
    }
}
