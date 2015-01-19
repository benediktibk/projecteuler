using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems;

namespace ProblemsTest
{
    [TestClass]
    public class Problem2Test
    {
        [TestMethod]
        public void Solve_Limit100_44()
        {
            var problem = new Problem2(100);

            Assert.AreEqual(44, problem.Solve());
        }

        [TestMethod]
        public void Solve_Limit4e6_4613732()
        {
            var problem = new Problem2(4000000);

            Assert.AreEqual(4613732, problem.Solve());
        }
    }
}
