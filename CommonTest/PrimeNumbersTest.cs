using Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CommonTest
{
    [TestClass]
    public class PrimeNumbersTest
    {
        private PrimeNumbers _primeNumbers;

        [TestInitialize]
        public void SetUp()
        {
            _primeNumbers = new PrimeNumbers();
        }

        [TestMethod]
        public void UpTo_5_CorrectResult()
        {
            var result = _primeNumbers.UpTo(5);

            Assert.AreEqual(3, result.Count);
            Assert.AreEqual(2, result[0]);
            Assert.AreEqual(3, result[1]);
            Assert.AreEqual(5, result[2]);
        }

        [TestMethod]
        public void UpTo_25_CorrectResult()
        {
            var result = _primeNumbers.UpTo(25);

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
            _primeNumbers.UpTo(25);
            var result = _primeNumbers.UpTo(5);

            Assert.AreEqual(3, result.Count);
            Assert.AreEqual(2, result[0]);
            Assert.AreEqual(3, result[1]);
            Assert.AreEqual(5, result[2]);
        }

        [TestMethod]
        public void UpTo_5And25_CorrectResult()
        {
            _primeNumbers.UpTo(5);
            var result = _primeNumbers.UpTo(25);

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
        public void Factorize_5_CorrectResult()
        {
            var result = _primeNumbers.Factorize(5);

            Assert.AreEqual(1, result.Count);
            Assert.AreEqual(1, result[5]);
        }

        [TestMethod]
        public void Factorize_25_CorrectResult()
        {
            var result = _primeNumbers.Factorize(25);

            Assert.AreEqual(1, result.Count);
            Assert.AreEqual(2, result[5]);
        }

        [TestMethod]
        public void Factorize_12_CorrectResult()
        {
            var result = _primeNumbers.Factorize(12);

            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(2, result[2]);
            Assert.AreEqual(1, result[3]);
        }

        [TestMethod]
        public void UpperBorderForNumberOfPrimeNumbers_100_AtLeast25()
        {
            Assert.IsTrue(_primeNumbers.UpperBorderForNumberOfPrimeNumbers(100) >= 25);
        }

        [TestMethod]
        public void UpperBorderForNumberOfPrimeNumbers_1000_AtLeast168()
        {
            Assert.IsTrue(_primeNumbers.UpperBorderForNumberOfPrimeNumbers(1000) >= 168);
        }

        [TestMethod]
        public void UpperBorderForNumberOfPrimeNumbers_10000_AtLeast1229()
        {
            Assert.IsTrue(_primeNumbers.UpperBorderForNumberOfPrimeNumbers(10000) >= 1229);
        }
    }
}
