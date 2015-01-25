using System;
using System.Collections.Generic;

namespace Common
{
    public class BigNumber10Base : BigNumber<uint>
    {
        public BigNumber10Base() : base(new DigitCalculatorGenericBase(10))
        { }

        public BigNumber10Base(ulong value) : base(value, new DigitCalculatorGenericBase(10))
        { }

        public BigNumber10Base(IReadOnlyList<uint> digits)
            : base(digits, new DigitCalculatorGenericBase(10))
        { }

        public static BigNumber10Base Convert(BigNumberInt32Base x)
        {
            var result = new BigNumber10Base();
            var digitBase = x.DigitCalculator.DigitBase;
            var shifterValuePartOne = digitBase/2;
            const ulong shifterValuePartTwo = 2;

            if (shifterValuePartOne*shifterValuePartTwo != digitBase)
                throw new Exception();

            var shifterPartOne = new BigNumber10Base(shifterValuePartOne);
            var shifterPartTwo = new BigNumber10Base(shifterValuePartTwo);
            var shifter = Multiply(shifterPartOne, shifterPartTwo);

            for (var i = x.DigitCount - 1; i >= 0; --i)
            {
                var digit = x[i];
                var summand = new BigNumber10Base(digit);
                result = Add(result, summand);
                if (i > 0)
                    result = Multiply(result, shifter);
            }

            return result;
        }

        public static BigNumber10Base Add(BigNumber10Base a, BigNumber10Base b)
        {
            return new BigNumber10Base(Add(a.Digits, b.Digits, a.DigitCalculator));
        }

        public static BigNumber10Base Multiply(BigNumber10Base a, BigNumber10Base b)
        {
            return new BigNumber10Base(Multiply(a.Digits, b.Digits, a.DigitCalculator));
        }

        public override BigNumber<uint> CreateZero()
        {
            return new BigNumber10Base();
        }

        public override BigNumber<uint> CreateInstance(List<uint> digits)
        {
            return new BigNumber10Base(digits);
        }

        public BigNumber10Base ShiftLeft(int n)
        {
            return new BigNumber10Base(ShiftLeftInternal(n));
        }
    }
}
