using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Common;

namespace Problems
{
    public class Problem18 : IProblem
    {
        private readonly IReadOnlyList<IReadOnlyList<int>> _numberTriangle;

        public Problem18(string numberTriangle)
        {
            var lines = numberTriangle.Split('\n');
            var numberTriangleParsed = new List<IReadOnlyList<int>>(lines.Count());

            foreach (var line in lines)
            {
                var values = line.Split(' ');
                var valuesList = new List<int>(numberTriangleParsed.Count + 1);
                valuesList.AddRange(values.Select(Int32.Parse));
                numberTriangleParsed.Add(valuesList);
            }

            _numberTriangle = numberTriangleParsed;
        }

        public static string GetTriangleForProblem18()
        {
            return "75\n95 64\n17 47 82\n18 35 87 10\n20 04 82 47 65\n19 01 23 75 03 34\n88 02 77 73 07 63 67\n99 65 04 28 06 16 70 92\n41 41 26 56 83 40 80 70 33\n41 48 72 33 47 32 37 16 94 29\n53 71 44 65 25 43 91 52 97 51 14\n70 11 33 28 77 73 17 78 39 68 17 57\n91 71 52 38 17 14 91 43 58 50 27 29 48\n63 66 04 68 89 53 67 30 73 16 69 87 40 31\n04 62 98 27 23 09 70 98 73 93 38 53 60 04 23";
        }

        public static string GetTriangleForExample()
        {
            return "3\n7 4\n2 4 6\n8 5 9 3";
        }

        public long Solve()
        {
            return FindMaximumSum(0, 0);
        }

        private int FindMaximumSum(int row, int column)
        {
            if (row == _numberTriangle.Count)
                return 0;

            var currentValue = _numberTriangle[row][column];
            var sumBelow = Math.Max(FindMaximumSum(row + 1, column), FindMaximumSum(row + 1, column + 1));
            return currentValue + sumBelow;
        }
    }
}
