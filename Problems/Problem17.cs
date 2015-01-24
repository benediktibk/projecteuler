using System;
using System.Collections.Generic;
using System.Linq;
using Common;

namespace Problems
{
    public class Problem17 : IProblem
    {
        private readonly int _limit;
        private readonly NumberWordGenerator _numberWordGenerator;

        public Problem17(int limit, NumberWordGenerator numberWordGenerator)
        {
            if (limit < 1)
                throw new ArgumentException("limit");

            _limit = limit;
            _numberWordGenerator = numberWordGenerator;
        }

        public long Solve()
        {
            long result = 0;

            for (var i = 1; i <= _limit; ++i)
            {
                var word = _numberWordGenerator[i];
                result += word.Count(x => x != ' ' && x != '-');
            }

            return result;
        }
    }
}
