using System;
using Common;

namespace Problems
{
    public class Problem19 : IProblem
    {
        public long Solve()
        {
            var currentDate = new DateTime(1901, 1, 1);
            var endDate = new DateTime(2000, 12, 31);

            while (currentDate.DayOfWeek != DayOfWeek.Sunday)
                currentDate = currentDate.AddDays(1);

            var result = 0;

            while (currentDate < endDate)
            {
                if (currentDate.Date.Day == 1)
                    result++;

                currentDate = currentDate.AddDays(7);
            }

            return result;
        }
    }
}
