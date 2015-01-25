using Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CommonTest
{
    [TestClass]
    public class BigNumberInt20BaseTest
    {
        [TestMethod]
        public void Constructor_TwoDigitValue_CorrectDigits()
        {
            const ulong value = (1 << 30) - 1;

            var number = new BigNumberInt20Base((uint)value);

            const ulong secondDigit = value >> 20;
            const ulong firstDigit = value - (secondDigit << 20);
            Assert.AreEqual(2, number.DigitCount);
            Assert.AreEqual(firstDigit, number[0]);
            Assert.AreEqual(secondDigit, number[1]);
        }
    }
}
