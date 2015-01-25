using System;
using System.Collections.Generic;
using System.Linq;

namespace Common
{
    public abstract class BigNumber<T>
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

        public IDigitCalculator<T> DigitalCalculator
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

        public BigNumber<T> ShiftLeft(int x)
        {
            if (x < 0)
                throw new ArgumentOutOfRangeException("x");

            var digitsShifted = new List<T>(_digits.Count + x);

            for (var i = 0; i < x; ++i)
                digitsShifted.Add(_digitCalculator.Cast(0));

            digitsShifted.AddRange(_digits);
            return CreateInstance(digitsShifted);
        }

        public abstract BigNumber<T> CreateZero();

        public abstract BigNumber<T> CreateInstance(List<T> digits);

        public static List<T> Add(IReadOnlyList<T> a, IReadOnlyList<T> b, IDigitCalculator<T> digitCalculator)
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

        protected BigNumber<T> Multiply(BigNumber<T> a)
        {
            var result = new List<T>();

            for (var i = 0; i < a.DigitCount; ++i)
            {
                var currentDigit = a[i];
                var summandDigits = new List<T>(DigitCount + i);
                var carry = _digitCalculator.Cast(0);

                for (var j = 0; j < i; ++j)
                    summandDigits.Add(carry);

                for (var j = 0; j < DigitCount; ++j)
                {
                    var value = _digitCalculator.CalculateProduct(_digits[j], currentDigit, carry);
                    carry = _digitCalculator.CalculateCarry(value);
                    var digit = _digitCalculator.CalculateDigit(value, carry);
                    summandDigits.Add(digit);
                }

                while (_digitCalculator.IsDigitGreaterThanZero(carry))
                {
                    var newCarry = _digitCalculator.CalculateCarry(carry);
                    var digit = _digitCalculator.CalculateDigit(carry, newCarry);
                    summandDigits.Add(digit);
                    carry = newCarry;
                }

                result = Add(result, summandDigits, DigitalCalculator);
            }

            return CreateInstance(result);
        }
    }
}
