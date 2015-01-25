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
                AddDigit(digit);
                carry = newCarry;
            }
        }

        protected BigNumber(List<T> digits, IDigitCalculator<T> digitCalculator)
        {
            if (digits.Any(x => !digitCalculator.IsValidDigit(x)))
                throw new ArgumentOutOfRangeException("digits");

            _digits = digits;
            _digitCalculator = digitCalculator;
        }

        public int DigitCount
        {
            get { return _digits.Count; }
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

        public BigNumber<T> Add(BigNumber<T> a)
        {
            var result = CreateZero();
            var smaller = a.DigitCount < DigitCount ? a : this;
            var bigger = a.DigitCount < DigitCount ? this : a;
            var carry = _digitCalculator.Cast(0);

            for (var i = 0; i < smaller.DigitCount; ++i)
            {
                var value = _digitCalculator.CalculateSum(smaller[i], bigger[i], carry);
                carry = _digitCalculator.CalculateCarry(value);
                var digit = _digitCalculator.CalculateDigit(value, carry);
                result.AddDigit(digit);
            }

            for (var i = smaller.DigitCount; i < bigger.DigitCount; ++i)
            {
                var value = _digitCalculator.CalculateSum(bigger[i], carry);
                carry = _digitCalculator.CalculateCarry(value);
                var digit = _digitCalculator.CalculateDigit(value, carry);
                result.AddDigit(digit);
            }

            while (_digitCalculator.IsDigitGreaterThanZero(carry))
            {
                var newCarry = _digitCalculator.CalculateCarry(carry);
                var digit = _digitCalculator.CalculateDigit(carry, newCarry);
                result.AddDigit(digit);
                carry = newCarry;
            }

            return result;
        }

        public BigNumber<T> Multiply(BigNumber<T> a)
        {
            var result = CreateZero();

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

                var summand = CreateInstance(summandDigits);
                result = result.Add(summand);
            }

            return result;
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

        private void AddDigit(T digit)
        {
            if (!_digitCalculator.IsValidDigit(digit))
                throw new ArgumentOutOfRangeException("digit");

            _digits.Add(digit);
        }
    }
}
