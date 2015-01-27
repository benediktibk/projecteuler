using Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems;

namespace ProblemsTest
{
    [TestClass]
    public class Problem23Test
    {
        [TestMethod]
        public void Solve_Empty_CorrectResult()
        {
            var problem = new Problem23(new FactorizationCache(new PrimeNumbers()));

            Assert.AreEqual(4179871, problem.Solve());
        }
    }
}
