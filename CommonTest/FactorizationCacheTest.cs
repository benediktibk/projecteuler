using Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CommonTest
{
    [TestClass]
    public class FactorizationCacheTest
    {
        private PrimeNumbers _primeNumbers;
        private FactorizationCache _factorizationCache;

        [TestInitialize]
        public void SetUp()
        {
            _primeNumbers = new PrimeNumbers();
            _factorizationCache = new FactorizationCache(_primeNumbers);
        }

        [TestMethod]
        public void Factorize_28_CorrectResult()
        {
            var factorization = _factorizationCache.Factorize(28);

            Assert.AreEqual(3, factorization.TotalFactorCount);
            Assert.AreEqual(2, factorization[2]);
            Assert.AreEqual(1, factorization[7]);
        }
    }
}
