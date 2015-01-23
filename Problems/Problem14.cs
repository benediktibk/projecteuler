using System.Collections.Generic;
using Common;

namespace Problems
{
    public class Problem14 : IProblem
    {
        private readonly Dictionary<long, long> _sequenceLenghts;
        private readonly long _border;

        public Problem14()
        {
            _sequenceLenghts = new Dictionary<long, long>();
            _sequenceLenghts.Add(1, 1);
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
            long length = 0;
            var numbers = new LinkedList<long>();

            while (true)
            {
                if (_sequenceLenghts.TryGetValue(number, out length))
                    return length;

                var nextNumber = number%2 == 0 ? number/2 : 3*number + 1;
                length = CalculateSequenceLength(nextNumber) + 1;
                _sequenceLenghts[number] = length;
            }
            return length;
        }
    }
}
