using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems;

namespace ProblemsTest
{
    [TestClass]
    public class Problem20Test
    {
        [TestMethod]
        public void Solve_10_27()
        {
            var problem = new Problem20(10);

            Assert.AreEqual(27, problem.Solve());
        }

        [TestMethod]
        public void Solve_100_648()
        {
            var problem = new Problem20(100);

            Assert.AreEqual(648, problem.Solve());
        }
    }
}
