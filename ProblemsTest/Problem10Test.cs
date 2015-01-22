using Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems;

namespace ProblemsTest
{
    [TestClass]
    public class Problem10Test
    {
        private PrimeNumbers _primeNumbers;

        [TestInitialize]
        public void SetUp()
        {
            _primeNumbers = new PrimeNumbers();
        }

        [TestMethod]
        public void Solve_Limit10_17()
        {
            var problem = new Problem10(10, _primeNumbers);

            Assert.AreEqual(17, problem.Solve());
        }

        [TestMethod]
        public void Solve_Limit2e6_142913828922()
        {
            var problem = new Problem10(2000000, _primeNumbers);

            Assert.AreEqual(142913828922, problem.Solve());
        }
    }
}
