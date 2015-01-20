using System;
using System.Collections.Generic;
using Common;

namespace Problems
{
    public class Problem4 : IProblem
    {
        private readonly int _numberOfDigits;
        private readonly IDictionary<int, int> _powersOf10;

        public Problem4(int numberOfDigits)
        {
            _numberOfDigits = numberOfDigits;
            _powersOf10 = new Dictionary<int, int>();
        }

        public long Solve()
        {
            var initialValue = CalculatePowerOf10(_numberOfDigits) - 1;
            var finalValue = CalculatePowerOf10(_numberOfDigits - 1);
            var result = 0;

            for (var a = initialValue; a >= finalValue; --a)
            {
                for (var b = a; b >= finalValue; --b)
                {
                    var product = a*b;

                    if (product < result)
                        continue;

                    if (!IsPalindrome(product)) 
                        continue;

                    result = product;
                    break;
                }
            }

            return result;
        }

        public bool IsPalindrome(int number)
        {
            var numberOfDigits = (int)Math.Log10(number) + 1;

            for (var digit = 1; digit <= numberOfDigits/2; ++digit)
            {
                var backDigit = ExtractDigit(number, digit);
                var frontDigit = ExtractDigit(number, numberOfDigits - digit + 1);

                if (frontDigit != backDigit)
                    return false;
            }

            return true;
        }

        public int ExtractDigit(int number, int digit)
        {
            var powerOf10 = CalculatePowerOf10(digit - 1);
            var numberDivided = number / powerOf10;
            var numberWithoutDigit = (numberDivided / 10) * 10;
            return numberDivided - numberWithoutDigit;
        }

        public int CalculatePowerOf10(int exponent)
        {
            if (exponent < 0)
                throw new ArgumentException("exponent");

            int result;

            if (_powersOf10.TryGetValue(exponent, out result))
                return result;

            if (exponent == 0)
                return 1;

            result = CalculatePowerOf10(exponent - 1)*10;
            _powersOf10.Add(exponent, result);
            return result;
        }
    }
}
