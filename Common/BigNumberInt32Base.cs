using System.Collections.Generic;

namespace Common
{
    public class BigNumberInt32Base : BigNumber<ulong>
    {
        public BigNumberInt32Base() : base(new DigitCalculatorInt32Base())
        { }

        public BigNumberInt32Base(ulong value) : base(value, new DigitCalculatorInt32Base())
        { }

        public BigNumberInt32Base(IReadOnlyList<ulong> digits)
            : base(digits, new DigitCalculatorInt32Base())
        { }

        public List<int> ConvertTo10Base()
        {
            var result = new List<int>();
            return result;
        }

        public override BigNumber<ulong> CreateZero()
        {
            return new BigNumberInt32Base();
        }
    }
}
