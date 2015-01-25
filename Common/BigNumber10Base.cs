namespace Common
{
    public class BigNumber10Base : BigNumber<uint>
    {
        public BigNumber10Base() : base(new DigitCalculatorGenericBase(10))
        { }

        public BigNumber10Base(uint value) : base(value, new DigitCalculatorGenericBase(10))
        { }

        public override BigNumber<uint> CreateZero()
        {
            return new BigNumber10Base();
        }
    }
}
