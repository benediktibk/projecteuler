using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Common;

namespace Problems
{
    public class Problem24 : IProblem
    {
        private readonly int _digitCount;
        private readonly int _permutationIndex;

        public Problem24(int digitCount, int permutationIndex)
        {
            _digitCount = digitCount;
            _permutationIndex = permutationIndex;
        }

        public long Solve()
        {
            var digit = 0;
            long currentIndex = 1;
            var permutation = new List<int>(_digitCount);
            var digitsLeft = new List<int>(_digitCount);

            for (var i = 0; i < _digitCount; ++i)
                digitsLeft.Add(i);

            while (digitsLeft.Count > 0)
            {
                var nextStep = Combinatorial.Factorial(digitsLeft.Count - 1);

                if (currentIndex + nextStep <= _permutationIndex)
                {
                    currentIndex += nextStep;
                    digit++;
                }
                else
                {
                    permutation.Add(digitsLeft[digit]);
                    digitsLeft.RemoveAt(digit);
                    digit = 0;
                }
            }

            long result = 0;
            long shifter = 1;

            for (var i = _digitCount - 1; i >= 0; --i, shifter *= 10)
                result += permutation[i]*shifter;

            return result;
        }

        public List<long> CreateAllPermutations()
        {
            var candidates = new List<long>(_digitCount);

            for (var i = 0; i < _digitCount; ++i)
                candidates.Add(i);

            return CreateAllPermutations(candidates);
        }

        public List<long> CreateAllPermutations(List<long> candidates)
        {
            if (candidates.Count == 0)
                return new List<long>{0};

            var result = new List<long>((int)Combinatorial.Factorial(candidates.Count));
            var shifter = (long) Math.Pow(10, candidates.Count - 1);

            foreach (var candidate in candidates)
            {
                var candidatesReduced = candidates.Where(x => x != candidate).ToList();
                var partialResults = CreateAllPermutations(candidatesReduced);
                result.AddRange(partialResults.Select(partialResult => candidate*shifter + partialResult));
            }

            return result;
        }
    }
}
