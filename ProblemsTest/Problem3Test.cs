using Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems;

namespace Problem1Test
{
    [TestClass]
    public class Problem3Test
    {
        private PrimeNumbers _primeNumbers;

        [TestInitialize]
        public void SetUp()
        {
            _primeNumbers = new PrimeNumbers();
        }

        [TestMethod]
        public void Solve_NumberIs2_2()
        {
            Assert.AreEqual(2, new Problem3(2, _primeNumbers).Solve());
        }

        [TestMethod]
        public void Solve_NumberIs23_23()
        {
            var problem = new Problem3(23, _primeNumbers);

            Assert.AreEqual(23, problem.Solve());
        }

        [TestMethod]
        public void Solve_NumberIs13195_29()
        {
            var problem = new Problem3(13195, _primeNumbers);

            Assert.AreEqual(29, problem.Solve());
        }

        [TestMethod]
        public void Solve_NumberIs600851475143_6857()
        {
            var problem = new Problem3(600851475143, _primeNumbers);

            Assert.AreEqual(6857, problem.Solve());
        }
    }
}
