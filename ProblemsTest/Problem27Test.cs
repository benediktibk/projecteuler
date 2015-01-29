using Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems;

namespace ProblemsTest
{
    [TestClass]
    public class Problem27Test
    {
        private Problem27 _problem;

        [TestInitialize]
        public void SetUp()
        {
            _problem = new Problem27(new PrimeNumbers());
        }

        [TestMethod]
        public void CalculateLengthOfPrimeSequence_1And41_40()
        {
            Assert.AreEqual(40, _problem.CalculateLengthOfPrimeSequence(1, 41));
        }

        [TestMethod]
        public void CalculateLengthOfPrimeSequence_Minus79And1601_80()
        {
            Assert.AreEqual(80, _problem.CalculateLengthOfPrimeSequence(-79, 1601));
        }

        [TestMethod]
        public void Solve_Empty_CorrectResult()
        {
            Assert.AreEqual(0, _problem.Solve());
        }
    }
}
