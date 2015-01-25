using Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CommonTest
{
    [TestClass]
    public class BigNumberInt16BaseTest
    {
        [TestMethod]
        public void Constructor_TwoDigitValue_CorrectDigits()
        {
            const uint value = (1 << 20) - 1;

            var number = new BigNumberInt16Base(value);

            const uint secondDigit = value >> 16;
            const uint firstDigit = value - (secondDigit << 16);
            Assert.AreEqual(firstDigit, number[0]);
            Assert.AreEqual(secondDigit, number[1]);
        }
    }
}
