using Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CommonTest
{
    [TestClass]
    public class PrimeNumbersTest
    {
        [TestMethod]
        public void UpTo_5_CorrectResult()
        {
            var primeNumbers = new PrimeNumbers();

            var result = primeNumbers.UpTo(5);

            Assert.AreEqual(3, result.Count);
            Assert.AreEqual(2, result[0]);
            Assert.AreEqual(3, result[1]);
            Assert.AreEqual(5, result[2]);
        }

        [TestMethod]
        public void UpTo_25_CorrectResult()
        {
            var primeNumbers = new PrimeNumbers();

            var result = primeNumbers.UpTo(25);

            Assert.AreEqual(9, result.Count);
            Assert.AreEqual(2, result[0]);
            Assert.AreEqual(3, result[1]);
            Assert.AreEqual(5, result[2]);
            Assert.AreEqual(7, result[3]);
            Assert.AreEqual(11, result[4]);
            Assert.AreEqual(13, result[5]);
            Assert.AreEqual(17, result[6]);
            Assert.AreEqual(19, result[7]);
            Assert.AreEqual(23, result[8]);
        }

        [TestMethod]
        public void UpTo_25And5_CorrectResult()
        {
            var primeNumbers = new PrimeNumbers();

            primeNumbers.UpTo(25);
            var result = primeNumbers.UpTo(5);

            Assert.AreEqual(3, result.Count);
            Assert.AreEqual(2, result[0]);
            Assert.AreEqual(3, result[1]);
            Assert.AreEqual(5, result[2]);
        }

        [TestMethod]
        public void UpTo_5And25_CorrectResult()
        {
            var primeNumbers = new PrimeNumbers();

            primeNumbers.UpTo(5);
            var result = primeNumbers.UpTo(25);

            Assert.AreEqual(9, result.Count);
            Assert.AreEqual(2, result[0]);
            Assert.AreEqual(3, result[1]);
            Assert.AreEqual(5, result[2]);
            Assert.AreEqual(7, result[3]);
            Assert.AreEqual(11, result[4]);
            Assert.AreEqual(13, result[5]);
            Assert.AreEqual(17, result[6]);
            Assert.AreEqual(19, result[7]);
            Assert.AreEqual(23, result[8]);
        }
    }
}
