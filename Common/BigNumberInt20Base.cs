using System.Collections.Generic;

namespace Common
{
    public class BigNumberInt20Base : BigNumber<ulong>
    {
        public BigNumberInt20Base() : base(new DigitCalculatorInt20Base())
        { }

        public BigNumberInt20Base(uint value) : base(value, new DigitCalculatorInt20Base())
        { }

        public BigNumberInt20Base(List<ulong> digits)
            : base(digits, new DigitCalculatorInt20Base())
        { }

        public List<int> ConvertTo10Base()
        {
            var result = new List<int>();
            return result;
        }

        public override BigNumber<ulong> CreateZero()
        {
            return new BigNumberInt20Base();
        }

        public override BigNumber<ulong> CreateInstance(List<ulong> digits)
        {
            return new BigNumberInt20Base(digits);
        }
    }
}
