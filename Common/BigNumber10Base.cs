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
            var shifter = new BigNumber10Base(x.DigitCalculator.DigitBase);

            for (var i = x.DigitCount - 1; i >= 0; --i)
            {
                var digit = x[i];
                var summand = new BigNumber10Base(digit);
                result = result.Add(summand);
                if (i > 0)
                    result = result.Multiply(shifter);
            }

            return result;
        }

        public BigNumber10Base Add(BigNumber10Base x)
        {
            return new BigNumber10Base(Add(Digits, x.Digits, DigitCalculator));
        }

        public BigNumber10Base Multiply(BigNumber10Base x)
        {
            return new BigNumber10Base(Multiply(Digits, x.Digits, DigitCalculator));
        }

        public override BigNumber<uint> CreateZero()
        {
            return new BigNumber10Base();
        }

        public override BigNumber<uint> CreateInstance(List<uint> digits)
        {
            return new BigNumber10Base(digits);
        }
    }
}
