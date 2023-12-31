﻿namespace Common
{
    public class DigitCalculatorInt32Base : IDigitCalculator<ulong>
    {
        private readonly int _baseInShifts;

        public DigitCalculatorInt32Base()
        {
            _baseInShifts = 32;
        }

        public ulong DigitBase
        {
            get { return (((ulong) 1) << _baseInShifts); }
        }

        public ulong CalculateDigit(ulong value, ulong carry)
        {
            return value - (carry << _baseInShifts);
        }

        public ulong CalculateCarry(ulong value)
        {
            return value >> _baseInShifts;
        }

        public ulong Cast(ulong value)
        {
            return value;
        }

        public bool IsDigitGreaterThanZero(ulong value)
        {
            return value > 0;
        }

        public ulong CalculateSum(ulong a, ulong b, ulong c)
        {
            return a + b + c;
        }

        public ulong CalculateSum(ulong a, ulong b)
        {
            return a + b;
        }

        public ulong CalculateProduct(ulong a, ulong b, ulong carry)
        {
            return a*b + carry;
        }

        public bool IsValidDigit(ulong a)
        {
            return a < DigitBase;
        }
    }
}
