using Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems;

namespace ProblemsTest
{
    [TestClass]
    public class Problem7Test
    {
        private PrimeNumbers _primeNumbers;

        [TestInitialize]
        public void SetUp()
        {
            _primeNumbers = new PrimeNumbers();
        }

        [TestMethod]
        public void Solve_Count6_13()
        {
            var problem = new Problem7(6, _primeNumbers);

            Assert.AreEqual(13, problem.Solve());
        }

        [TestMethod]
        public void Solve_Count10001_104743()
        {
            var problem = new Problem7(10001, _primeNumbers);

            Assert.AreEqual(104743, problem.Solve());
        }
    }
}
