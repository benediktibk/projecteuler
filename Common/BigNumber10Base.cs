using System;
using System.Collections.Generic;
using System.Linq;

namespace Common
{
    public class BigNumber10Base : BigNumber<uint>
    {
        public BigNumber10Base() : base(new DigitCalculatorGenericBase(10))
        { }

        public BigNumber10Base(uint value) : base(value, new DigitCalculatorGenericBase(10))
        { }

        public BigNumber10Base(List<int> digits) : base(new DigitCalculatorGenericBase(10))
        {
            if (digits.Select(x => x).Any(x => x < 0 || x > 9))
                throw new ArgumentOutOfRangeException("digits");

            foreach (var digit in digits)
                AddDigit((uint)digit);
        }

        public override BigNumber<uint> CreateZero()
        {
            return new BigNumber10Base();
        }
    }
}
