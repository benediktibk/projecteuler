using System;
using System.Collections.Generic;
using System.Linq;

namespace Common
{
    public class BigNumber10Base : BigNumber<uint>
    {
        public BigNumber10Base() : base(new DigitCalculatorGenericBase(10))
        { }

        public BigNumber10Base(ulong value) : base(value, new DigitCalculatorGenericBase(10))
        { }

        public BigNumber10Base(List<uint> digits) : base(digits, new DigitCalculatorGenericBase(10))
        { }

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
