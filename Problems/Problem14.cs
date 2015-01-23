using System.Collections.Generic;
using System.Linq;
using Common;

namespace Problems
{
    public class Problem14 : IProblem
    {
        private readonly Dictionary<long, long> _sequenceLenghts;
        private readonly long _border;

        public Problem14()
        {
            _sequenceLenghts = new Dictionary<long, long> {{1, 1}};
            _border = 1000000;
        }

        public long Solve()
        {
            long result = 0;
            long resultLength = 0;

            for (long i = 0; i < _border; ++i)
            {
                var length = CalculateSequenceLength(i);

                if (length <= resultLength) 
                    continue;
                
                result = i;
                resultLength = length;
            }

            return result;
        }

        public long CalculateSequenceLength(long number)
        {
            long length;
            var numbers = new LinkedList<long>();
            var nextNumber = number;

            while (true)
            {
                if (_sequenceLenghts.TryGetValue(nextNumber, out length))
                    break;

                numbers.AddLast(nextNumber);
                nextNumber = nextNumber % 2 == 0 ? nextNumber / 2 : 3 * nextNumber + 1;
            }

            foreach (var x in numbers.Reverse())
            {
                length++;
                _sequenceLenghts[x] = length;
            }

            return length;
        }
    }
}
