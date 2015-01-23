using Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems;

namespace ProblemsTest
{
    [TestClass]
    public class Problem12Test
    {
        private FactorizationCache _factorizationCache;
        private PrimeNumbers _primeNumbers;

        [TestInitialize]
        public void SetUp()
        {
            _primeNumbers = new PrimeNumbers();
            _factorizationCache = new FactorizationCache(_primeNumbers);
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

        [TestMethod]
        public void Solve_6Divisors_36()
        {
            var problem = new Problem12(_factorizationCache, 6);

            Assert.AreEqual(36, problem.Solve());
        }

        [TestMethod]
        public void Solve_7Divisors_36()
        {
            var problem = new Problem12(_factorizationCache, 7);

            Assert.AreEqual(36, problem.Solve());
        }

        [TestMethod]
        public void Solve_8Divisors_36()
        {
            var problem = new Problem12(_factorizationCache, 8);

            Assert.AreEqual(36, problem.Solve());
        }

        [TestMethod]
        public void Solve_9Divisors_120()
        {
            var problem = new Problem12(_factorizationCache, 9);

            Assert.AreEqual(120, problem.Solve());
        }

        [TestMethod]
        public void Solve_10Divisors_120()
        {
            var problem = new Problem12(_factorizationCache, 10);

            Assert.AreEqual(120, problem.Solve());
        }

        [TestMethod]
        public void Solve_11Divisors_120()
        {
            var problem = new Problem12(_factorizationCache, 11);

            Assert.AreEqual(120, problem.Solve());
        }

        [TestMethod]
        public void Solve_12Divisors_120()
        {
            var problem = new Problem12(_factorizationCache, 12);

            Assert.AreEqual(120, problem.Solve());
        }

        [TestMethod]
        public void Solve_13Divisors_120()
        {
            var problem = new Problem12(_factorizationCache, 13);

            Assert.AreEqual(120, problem.Solve());
        }

        [TestMethod]
        public void Solve_14Divisors_120()
        {
            var problem = new Problem12(_factorizationCache, 14);

            Assert.AreEqual(120, problem.Solve());
        }

        [TestMethod]
        public void Solve_15Divisors_120()
        {
            var problem = new Problem12(_factorizationCache, 15);

            Assert.AreEqual(120, problem.Solve());
        }

        [TestMethod]
        public void Solve_16Divisors_120()
        {
            var problem = new Problem12(_factorizationCache, 16);

            Assert.AreEqual(300, problem.Solve());
        }

        [TestMethod]
        public void Solve_500Divisors_76576500()
        {
            var problem = new Problem12(_factorizationCache, 500);

            Assert.AreEqual(76576500, problem.Solve());
        }
    }
}
