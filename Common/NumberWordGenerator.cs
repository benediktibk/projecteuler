using System;
using System.Collections.Generic;

namespace Common
{
    public class NumberWordGenerator
    {
        private readonly Dictionary<int, string> _cache;

        public NumberWordGenerator()
        {
            _cache = new Dictionary<int, string>
            {
                {1, "one"},
                {2, "two"},
                {3, "three"},
                {4, "four"},
                {5, "five"},
                {6, "six"},
                {7, "seven"},
                {8, "eight"},
                {9, "nine"},
                {10, "ten"},
                {11, "eleven"},
                {12, "twelve"},
                {13, "thirteen"},
                {14, "fourteen"},
                {15, "fifteen"},
                {16, "sixteen"},
                {17, "seventeen"},
                {18, "eighteen"},
                {19, "nineteen"},
                {20, "thirteen"},
                {20, "twenty"},
                {30, "thirty"},
                {40, "forty"},
                {50, "fifty"},
                {60, "sixty"},
                {70, "seventy"},
                {80, "eighty"},
                {90, "ninety"}
            };
        }

        public string GetStringFor(int number)
        {
            string result;

            if (_cache.TryGetValue(number, out result))
                return result;

            if (number > 20 && number < 100)
            {
                var withoutLastDigit = number / 10 * 10;
                var lastDigit = number - withoutLastDigit;
                return Add(number, GetStringFor(withoutLastDigit) + "-" + GetStringFor(lastDigit));
            }

            throw new Exception("do not know how to create the string for " + number);
        }

        private string Add(int number, string word)
        {
            _cache[number] = word;
            return word;
        }
    }
}
