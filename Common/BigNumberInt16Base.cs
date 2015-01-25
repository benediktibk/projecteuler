using System.Collections.Generic;

namespace Common
{
    public class BigNumberInt16Base : BigNumber<uint>
    {
        private readonly List<uint> _digits;

        public BigNumberInt16Base() : base(new DigitCalculatorInt16Base())
        { }

        public BigNumberInt16Base(uint value) : base(value, new DigitCalculatorInt16Base())
        { }

        public List<int> ConvertTo10Base()
        {
            var result = new List<int>();
            return result;
        }

        public override BigNumber<uint> CreateZero()
        {
            return new BigNumberInt16Base();
        }
    }
}
