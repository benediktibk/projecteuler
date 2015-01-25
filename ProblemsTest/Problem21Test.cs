using Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems;

namespace ProblemsTest
{
    [TestClass]
    public class Problem21Test
    {
        private Problem21 _problem;

        [TestInitialize]
        public void SetUp()
        {
            _problem = new Problem21(new FactorizationCache(new PrimeNumbers()));
        }

        [TestMethod]
        public void CalculateDivisorSum_220_284()
        {
            Assert.AreEqual(284, _problem.CalculateDivisorSum(220));
        }

        [TestMethod]
        public void CalculateDivisorSum_284_220()
        {
            Assert.AreEqual(220, _problem.CalculateDivisorSum(284));
        }

        [TestMethod]
        public void Solve_Empty_31626()
        {
            Assert.AreEqual(31626, _problem.Solve());
        }
    }
}
