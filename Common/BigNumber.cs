using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Common
{
    public abstract class BigNumber<T> : IEnumerable<T>
    {
        private readonly List<T> _digits;
        private readonly IDigitCalculator<T> _digitCalculator; 

        protected BigNumber(IDigitCalculator<T> digitCalculator)
        {
            _digits = new List<T>();
            _digitCalculator = digitCalculator;
        }

        protected BigNumber(ulong value, IDigitCalculator<T> digitCalculator) : this(digitCalculator)
        {
            var carry = _digitCalculator.Cast(value);

            while (_digitCalculator.IsDigitGreaterThanZero(carry))
            {
                var newCarry = _digitCalculator.CalculateCarry(carry);
                var digit = _digitCalculator.CalculateDigit(carry, newCarry);
                _digits.Add(digit);
                carry = newCarry;
            }
        }

        protected BigNumber(IReadOnlyList<T> digits, IDigitCalculator<T> digitCalculator)
        {
            if (digits.Any(x => !digitCalculator.IsValidDigit(x)))
                throw new ArgumentOutOfRangeException("digits");

            _digits = new List<T>(digits);
            _digitCalculator = digitCalculator;
        }

        public IReadOnlyList<T> Digits
        {
            get { return _digits; }
        }

        public int DigitCount
        {
            get { return _digits.Count; }
        }

        public IDigitCalculator<T> DigitCalculator
        {
            get { return _digitCalculator; }
        }

        public T this[int digit]
        {
            get
            {
                if (digit >= DigitCount)
                    throw new ArgumentOutOfRangeException("digit");

                return _digits[digit];
            }
        }

        public List<T> ShiftLeftInternal(int x)
        {
            if (x < 0)
                throw new ArgumentOutOfRangeException("x");

            var digitsShifted = new List<T>(_digits.Count + x);

            for (var i = 0; i < x; ++i)
                digitsShifted.Add(_digitCalculator.Cast(0));

            digitsShifted.AddRange(_digits);
            return digitsShifted;
        }

        public abstract BigNumber<T> CreateZero();

        protected static List<T> Add(IReadOnlyList<T> a, IReadOnlyList<T> b, IDigitCalculator<T> digitCalculator)
        {
            var result = new List<T>();
            var smaller = a.Count < b.Count ? a : b;
            var bigger = a.Count < b.Count ? b : a;
            var carry = digitCalculator.Cast(0);

            for (var i = 0; i < smaller.Count; ++i)
            {
                var value = digitCalculator.CalculateSum(smaller[i], bigger[i], carry);
                carry = digitCalculator.CalculateCarry(value);
                var digit = digitCalculator.CalculateDigit(value, carry);
                result.Add(digit);
            }

            for (var i = smaller.Count; i < bigger.Count; ++i)
            {
                var value = digitCalculator.CalculateSum(bigger[i], carry);
                carry = digitCalculator.CalculateCarry(value);
                var digit = digitCalculator.CalculateDigit(value, carry);
                result.Add(digit);
            }

            while (digitCalculator.IsDigitGreaterThanZero(carry))
            {
                var newCarry = digitCalculator.CalculateCarry(carry);
                var digit = digitCalculator.CalculateDigit(carry, newCarry);
                result.Add(digit);
                carry = newCarry;
            }

            return result;
        }

        protected static List<T> Multiply(IReadOnlyList<T> a, IReadOnlyList<T> b, IDigitCalculator<T> digitCalculator)
        {
            var result = new List<T>();

            for (var i = 0; i < a.Count; ++i)
            {
                var currentDigit = a[i];
                var summandDigits = new List<T>(b.Count + i);
                var carry = digitCalculator.Cast(0);

                for (var j = 0; j < i; ++j)
                    summandDigits.Add(carry);

                for (var j = 0; j < b.Count; ++j)
                {
                    var value = digitCalculator.CalculateProduct(b[j], currentDigit, carry);
                    carry = digitCalculator.CalculateCarry(value);
                    var digit = digitCalculator.CalculateDigit(value, carry);
                    summandDigits.Add(digit);
                }

                while (digitCalculator.IsDigitGreaterThanZero(carry))
                {
                    var newCarry = digitCalculator.CalculateCarry(carry);
                    var digit = digitCalculator.CalculateDigit(carry, newCarry);
                    summandDigits.Add(digit);
                    carry = newCarry;
                }

                result = Add(result, summandDigits, digitCalculator);
            }

            return result;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _digits.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
