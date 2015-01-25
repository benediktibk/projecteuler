using Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CommonTest
{
    [TestClass]
    public class FactorizationTest
    {
        private FactorizationCache _factorizationCache;

        [TestInitialize]
        public void SetUp()
        {
            _factorizationCache = new FactorizationCache(new PrimeNumbers());
        }

        [TestMethod]
        public void CalculateAllPossibleDivisors_220_CorrectResult()
        {
            var factorization = _factorizationCache.Factorize(220);

            var divisors = factorization.CalculateAllPossibleDivisors();

            Assert.AreEqual(factorization.CountOfPossibleDivisors, divisors.Count);
            Assert.IsTrue(divisors.Contains(1));
            Assert.IsTrue(divisors.Contains(2));
            Assert.IsTrue(divisors.Contains(4));
            Assert.IsTrue(divisors.Contains(5));
            Assert.IsTrue(divisors.Contains(10));
            Assert.IsTrue(divisors.Contains(11));
            Assert.IsTrue(divisors.Contains(20));
            Assert.IsTrue(divisors.Contains(22));
            Assert.IsTrue(divisors.Contains(44));
            Assert.IsTrue(divisors.Contains(55));
            Assert.IsTrue(divisors.Contains(110));
        }
    }
}
