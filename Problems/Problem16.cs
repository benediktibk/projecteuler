using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using Common;

namespace Problems
{
    public class Problem16 : IProblem
    {
        private readonly int _exponent;

        public Problem16(int exponent)
        {
            if (exponent < 0)
                throw new ArgumentException("exponent");

            _exponent = exponent;
        }

        public long Solve()
        {
            var number = new List<int> {1};

            for (var i = 0; i < _exponent; ++i)
            {
                var carry = 0;

                for (var j = 0; j < number.Count; ++j)
                {
                    var product = number[j]*2 + carry;
                    var digit = product - product/10*10;
                    carry = (product - digit)/10;
                    number[j] = digit;
                }

                while (carry > 0)
                {
                    var digit = carry - carry/10*10;
                    carry = carry/10;
                    number.Add(digit);
                }
            }

            return number.Sum();
        }
    }
}
