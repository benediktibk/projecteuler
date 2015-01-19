using System;
using Common;

namespace Problems
{
    public class Problem2 : IProblem
    {
        private readonly int _limit;

        public Problem2(int limit)
        {
            if (limit <= 2)
                throw new ArgumentException("limit");

            _limit = limit;
        }

        public long Solve()
        {
            var previous = 1;
            var current = 2;
            var result = 2;
            var evenCounter = 0;

            while (true)
            {
                var next = previous + current;
                previous = current;
                current = next;
                evenCounter++;

                if (current > _limit)
                    break;

                if (evenCounter != 3) 
                    continue;

                result += current;
                evenCounter = 0;
            }

            return result;
        }
    }
}
