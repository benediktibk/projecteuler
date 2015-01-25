using System;
using System.Collections.Generic;

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

        protected BigNumber(uint value, IDigitCalculator<T> digitCalculator) : this(digitCalculator)
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

        public abstract BigNumber<T> CreateZero();

        protected void AddDigit(T digit)
        {
            _digits.Add(digit);
        }
    }
}
