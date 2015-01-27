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
            var permutations = CreateAllPermutations();
            permutations.Sort();
            return permutations[_permutationIndex - 1];
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
