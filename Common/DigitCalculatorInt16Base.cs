namespace Common
{
    public class DigitCalculatorInt16Base : IDigitCalculator<uint>
    {
        private static readonly int BaseInBinaryShifts;

        static DigitCalculatorInt16Base()
        {
            BaseInBinaryShifts = 16;
        }

        public uint CalculateDigit(uint value, uint carry)
        {
            return value - (carry << BaseInBinaryShifts);
        }

        public uint CalculateCarry(uint value)
        {
            return value >> BaseInBinaryShifts;
        }

        public uint Cast(uint value)
        {
            return value;
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
    }
}
