using Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CommonTest
{
    [TestClass]
    public class BigNumberInt32BaseTest
    {
        [TestMethod]
        public void Constructor_TwoDigitValue_CorrectDigits()
        {
            const ulong value = (((ulong)1) << 34) - 1;

            var number = new BigNumberInt32Base(value);

            const ulong secondDigit = value >> 32;
            const ulong firstDigit = value - (secondDigit << 32);
            Assert.AreEqual(2, number.DigitCount);
            Assert.AreEqual(firstDigit, number[0]);
            Assert.AreEqual(secondDigit, number[1]);
        }
    }
}
