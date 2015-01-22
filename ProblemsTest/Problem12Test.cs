using Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems;

namespace ProblemsTest
{
    [TestClass]
    public class Problem12Test
    {
        private FactorizationCache _factorizationCache;

        [TestInitialize]
        public void SetUp()
        {
            _factorizationCache = new FactorizationCache(new PrimeNumbers());
        }

        [TestMethod]
        public void Solve_5Divisors_28()
        {
            var problem = new Problem12(_factorizationCache, 5);

            Assert.AreEqual(28, problem.Solve());
        }

        [TestMethod]
        public void Solve_1Divisor_3()
        {
            var problem = new Problem12(_factorizationCache, 1);

            Assert.AreEqual(3, problem.Solve());
        }

        [TestMethod]
        public void Solve_2Divisors_6()
        {
            var problem = new Problem12(_factorizationCache, 2);

            Assert.AreEqual(6, problem.Solve());
        }

        [TestMethod]
        public void Solve_3Divisors_6()
        {
            var problem = new Problem12(_factorizationCache, 3);

            Assert.AreEqual(6, problem.Solve());
        }

        [TestMethod]
        public void Solve_4Divisors_28()
        {
            var problem = new Problem12(_factorizationCache, 4);

            Assert.AreEqual(28, problem.Solve());
        }
    }
}
