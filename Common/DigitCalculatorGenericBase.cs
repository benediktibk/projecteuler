using System;

namespace Common
{
    public class DigitCalculatorGenericBase : IDigitCalculator<uint>
    {
        private readonly uint _base;

        public DigitCalculatorGenericBase(uint baseValue)
        {
            _base = baseValue;
        }

        public uint CalculateDigit(uint value, uint carry)
        {
            return value - carry * _base;
        }

        public uint CalculateCarry(uint value)
        {
            return value / _base;
        }

        public uint Cast(ulong value)
        {
            if (value > UInt32.MaxValue)
                throw new ArgumentOutOfRangeException("value");

            return (uint)value;
        }

        public bool IsDigitGreaterThanZero(uint value)
        {
            return value > 0;
        }

        public uint CalculateSum(uint a, uint b, uint c)
        {
            return a + b + c;
        }

        public uint CalculateSum(uint a, uint b)
        {
            return a + b;
        }

        public uint CalculateProduct(uint a, uint b, uint carry)
        {
            return a*b + carry;
        }

        public bool IsValidDigit(uint a)
        {
            return a < _base;
        }
    }
}
