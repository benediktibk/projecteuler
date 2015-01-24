using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems;

namespace ProblemsTest
{
    [TestClass]
    public class Problem16Test
    {
        [TestMethod]
        public void Solve_Exponent15_26()
        {
            var problem = new Problem16(15);

            Assert.AreEqual(26, problem.Solve());
        }

        [TestMethod]
        public void Solve_Exponent1000_1366()
        {
            var problem = new Problem16(1000);

            Assert.AreEqual(1366, problem.Solve());
        }
    }
}
